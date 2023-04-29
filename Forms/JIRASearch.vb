Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.IO
Imports Telerik.WinControls.UI
Imports System.Data.OleDb
Imports RequestsManager.ProdSupport_DataSetTableAdapters

Public Class JIRASearch

    Public Sub New(ByVal ddlChannel As Telerik.WinControls.UI.RadDropDownList, ByVal ddlClient As Telerik.WinControls.UI.RadDropDownList)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CopyDropDownListItems(ddlChannel, Me.CboChannel)
        CopyDropDownListItems(ddlClient, Me.CboClient)

    End Sub

    Private Sub CopyDropDownListItems(source As Telerik.WinControls.UI.RadDropDownList, target As Telerik.WinControls.UI.RadDropDownList)
        Dim dataTable As DataTable = TryCast(source.DataSource, DataTable)
        If dataTable IsNot Nothing Then
            target.DataSource = dataTable.Copy()
        Else
            ' Manually copy items if DataSource is not a DataTable
            For Each item As Telerik.WinControls.UI.RadListDataItem In source.Items
                target.Items.Add(New Telerik.WinControls.UI.RadListDataItem(item.Text, item.Value))
            Next
        End If

        target.DisplayMember = source.DisplayMember
        target.ValueMember = source.ValueMember
        'target.SelectedValue = source.SelectedValue
    End Sub


    Private Sub JIRASearch_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Initialize the DataGridView
        Initialize_DGView()
        'With RadGridView1
        '    .AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        '    .ColumnCount = 13


        '    With .Columns(0)
        '        .Name = "Key"
        '        '.Width = 75
        '        '.AutoSizeMode = BestFitColumnMode.AllCells
        '        .HeaderText = "Key"
        '    End With
        '    With .Columns(1)
        '        .Name = "Summary"
        '        '.Width = 810
        '        .HeaderText = "Summary"
        '    End With
        '    With .Columns(2)
        '        .Name = "Status"
        '        '.Width = 810
        '        .HeaderText = "Status"
        '    End With
        '    With .Columns(3)
        '        .Name = "Assignee"
        '        '.Width = 810
        '        .HeaderText = "Assignee"
        '    End With
        '    With .Columns(4)
        '        .Name = "Reporter"
        '        '.Width = 810
        '        .HeaderText = "Reporter"
        '    End With
        '    With .Columns(5)
        '        .Name = "Created"
        '        '.Width = 810
        '        .HeaderText = "Created"
        '    End With
        '    With .Columns(6)
        '        .Name = "Updated"
        '        '.Width = 810
        '        .HeaderText = "Updated"
        '    End With
        '    With .Columns(7)
        '        .Name = "Labels"
        '        '.Width = 810
        '        .HeaderText = "Labels"
        '    End With
        '    With .Columns(8)
        '        .Name = "Carriers"
        '        '.Width = 810
        '        .HeaderText = "Carriers"
        '    End With
        '    With .Columns(9)
        '        .Name = "FLEXSClients"
        '        '.Width = 810
        '        .HeaderText = "Clients"
        '    End With
        '    With .Columns(10)
        '        .Name = "EpicName"
        '        '.Width = 810
        '        .HeaderText = "Epic Name"
        '    End With
        '    With .Columns(11)
        '        .Name = "EpicLink"
        '        '.Width = 810
        '        .HeaderText = "Epic Link"
        '    End With
        '    With .Columns(12)
        '        .Name = "ReleaseDate"
        '        '.Width = 810
        '        .HeaderText = "Release Date"
        '    End With

        '    Dim checkBoxColumn As New GridViewCheckBoxColumn()
        '    checkBoxColumn.DataType = GetType(Integer)
        '    checkBoxColumn.Name = "AddtoDB"
        '    'checkBoxColumn.FieldName = "Discontinued"
        '    checkBoxColumn.HeaderText = "Selected"
        '    checkBoxColumn.EnableHeaderCheckBox = True
        '    RadGridView1.MasterTemplate.Columns.Add(checkBoxColumn)



        '    'With .Columns(13)
        '    '    .DataType = GetType(Integer)
        '    '    .Name = "AddtoDB"
        '    '    '.Width = 810
        '    '    .HeaderText = "Selected"
        '    'End With
        'End With
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        RadOverlayManager.Show(Me.RadGridView1)
        ' Clear the DataGridView
        RadGridView1.Rows.Clear()
        Initialize_DGView()

        ' Construct the Jira search URL
        Dim url As String = "https://jira.tools.telushealth.com/rest/api/2/search?jql=" + txtSearch.Text + "&maxResults=" + SpinMaxRes.Value.ToString

        ' Create a WebClient to download the JSON response
        Dim client As WebClient = New WebClient()
        client.Headers("Authorization") = "Bearer " + "ODAwNDc5MDE5OTk4Op6GvljcN/HFEyy5z1uJQyoV8F6m"
        Dim json As String = client.DownloadString(url)

        ' Parse the JSON response using Newtonsoft.Json
        Dim obj As JObject = JObject.Parse(json)
        Dim issues As JArray = obj("issues")
        For Each issue In issues
            ' Extract the key and summary fields from each issue
            Dim key As String = issue("key").ToString()
            Dim summary As String = issue("fields")("summary").ToString()
            Dim Status As String = issue("fields")("status")("name").ToString()
            Dim Assignee As String = If(issue("fields")("assignee").Count <> 0, issue("fields")("assignee")("displayName").ToString(), "Unassigned")
            Dim Reporter As String = issue("fields")("reporter")("displayName").ToString()
            Dim Created As DateTime = CDate(issue("fields")("created").ToString())
            Dim Updated As DateTime = CDate(issue("fields")("updated").ToString())
            Dim Labels As String = Trim(Replace(Replace(Replace(Replace(Replace(issue("fields")("labels").ToString(), """", ""), "[" & vbCrLf, ""), vbCrLf & "]", ""), vbCrLf, ""), "  ", " "))
            Dim Carriers As String = ""
            If issue("fields")("customfield_12704").Count <> 0 Then
                For i = 0 To issue("fields")("customfield_12704").Count - 1
                    If i = 0 Then
                        Carriers = issue("fields")("customfield_12704").Item(i)("value").ToString
                    Else
                        Carriers += ", " & issue("fields")("customfield_12704").Item(i)("value").ToString
                    End If
                Next
            End If
            Dim FLEXSClients As String = Trim(Replace(Replace(Replace(Replace(Replace(issue("fields")("customfield_12705").ToString(), """", ""), "[" & vbCrLf, ""), vbCrLf & "]", ""), vbCrLf, ""), "  ", " "))

            Dim EpicName As String = ""
            Dim EpicLink As String = ""

            Try
                EpicName = issue("fields")("customfield_10004").ToString()
                EpicLink = issue("key").ToString()
            Catch ex As Exception
                'MsgBox(ex.Message & vbNewLine & vbNewLine & "Update failed")
            End Try

            Try
                If EpicLink = "" Then EpicLink = issue("fields")("customfield_10002").ToString()
            Catch ex As Exception

                'MsgBox(ex.Message & vbNewLine & vbNewLine & "Update failed")
            End Try

            Dim ReleaseDate As String = ""
            Try
                ReleaseDate = issue("fields")("fixVersions").Item(0)("releaseDate").ToString()
                'If obj("fields")("fixVersions").Item(0)("releaseDate").Count <> 0 Then
                '	issue.FixVersion += vbNewLine & obj("fields")("fixVersions").Item(0)("releaseDate").ToString()
                'End If
            Catch
            End Try

            Dim ReleaseName As String = ""
            Try
                ReleaseName = issue("fields")("fixVersions").Item(0)("name").ToString()
                'If obj("fields")("fixVersions").Item(0)("releaseDate").Count <> 0 Then
                '	issue.FixVersion += vbNewLine & obj("fields")("fixVersions").Item(0)("releaseDate").ToString()
                'End If
            Catch
            End Try

            'Dim EpicName As String = If(issue("fields")("customfield_10004").Count <> 0, issue("key").ToString() + " - " + issue("fields")("customfield_10004").ToString(), "") 'issue("key").ToString() + " - " + issue("fields")("customfield_10004").ToString()
            'Dim EpicLink As String = If(issue("fields")("customfield_10002").Count <> 0, issue("fields")("customfield_10002").ToString(), "") 'issue("fields")("customfield_10002").ToString()

            ' Add the key and summary to the DataGridView
            RadGridView1.Rows.Add(key, summary, Status, Assignee, Reporter, Created, Updated, Labels, Carriers, FLEXSClients, EpicName, EpicLink, ReleaseDate, ReleaseName)

        Next
        RadGridView1.ShowHeaderCellButtons = True
        RadGridView1.Columns.Move(14, 0)
        RadGridView1.BestFitColumns()
        'RadGridView1.Columns(1).AutoSizeMode = BestFitColumnMode.AllCells
        'RadGridView1.Columns(2).AutoSizeMode = BestFitColumnMode.AllCells
        'RadGridView1.Columns(3).AutoSizeMode = BestFitColumnMode.AllCells
        'RadGridView1.Columns(4).AutoSizeMode = BestFitColumnMode.AllCells
        RadOverlayManager.Close()

    End Sub

    Private Sub BtnBatchUpd_Click(sender As Object, e As EventArgs) Handles BtnBatchUpd.Click

        Dim lstFLEXS As String = ""

        For row As Integer = 0 To RadGridView1.RowCount - 1
            If RadGridView1.Rows(row).Cells("Selected").Value = 1 Then
                If lstFLEXS = "" Then
                    lstFLEXS = RadGridView1.Rows(row).Cells("Key").Value.ToString().Replace("FLEXS-", "")
                Else
                    lstFLEXS += ", " & RadGridView1.Rows(row).Cells("Key").Value.ToString().Replace("FLEXS-", "")
                End If
            End If
        Next

        Dim queryString As String = "SELECT ID FROM Issues WHERE Status IN ('AODA - Confirmed Defect','AODA - Enhancement','Confirmed Defect','Enhancement - Escalated to Product') AND [FLEXS Ticket] IN (" & lstFLEXS & ")"
        Dim qryNbResults As String = "SELECT COUNT(ID) FROM Issues WHERE Status IN ('AODA - Confirmed Defect','AODA - Enhancement','Confirmed Defect','Enhancement - Escalated to Product') AND [FLEXS Ticket] IN (" & lstFLEXS & ")"
        Dim qryAddCommentBatch As String = ""

        Using connection As New OleDbConnection(My.Settings.DB_Connection)

            Dim command As New OleDbCommand(qryNbResults, connection)
            connection.Open()

            Dim nbResults As Integer = command.ExecuteScalar
            Dim i As Integer = 0
            Dim upd As Integer

            If nbResults > 0 Then
                command = New OleDbCommand(queryString, connection)
                If ChkUpdComment.Checked = True Then
                    If TxtNewComment.Text <> "" Then
                        Dim reader As OleDbDataReader = command.ExecuteReader()

                        While reader.Read()
                            Dim cmdAddComment As New OleDbCommand("INSERT INTO Audit (IssueID, DateAdded, Username, Comment) VALUES (" & reader(0).ToString() & ", #" & Now() & "#, 'ProdMgmt', '" & TxtNewComment.Text & "');", connection)
                            i += cmdAddComment.ExecuteNonQuery
                        End While
                        reader.Close()
                    Else
                        MsgBox("The comment field is empty!", MsgBoxStyle.Exclamation, "No comment entered!")
                    End If
                End If

                If ChkLastDateUpd.Checked = True Then
                    If RadGridView1.Rows(0).Cells("ReleaseDate").Value = "" Then
                        MsgBox("There is no date associated to the release! No date will be updated.", MsgBoxStyle.Exclamation, "No release date!")
                    Else
                        Dim RelDate As Date = CDate(RadGridView1.Rows(0).Cells("ReleaseDate").Value.ToString)
                        command = New OleDbCommand("UPDATE Issues SET [Last Status Update] = #" & RelDate & "# WHERE [FLEXS Ticket] IN (" & lstFLEXS & ")", connection)
                        upd = command.ExecuteNonQuery
                    End If
                End If
                '1
                If ChkStatUpd.Checked = True Then
                    command = New OleDbCommand("UPDATE Issues SET Status = 'AODA - Confirmed Defect Fixed' WHERE Status = 'AODA - Confirmed Defect' AND [FLEXS Ticket] IN (" & lstFLEXS & ")", connection)
                    upd = command.ExecuteNonQuery
                    command = New OleDbCommand("UPDATE Issues SET Status = 'Confirmed Defect - Fixed' WHERE Status = 'Confirmed Defect' AND [FLEXS Ticket] IN (" & lstFLEXS & ")", connection)
                    upd = command.ExecuteNonQuery
                    command = New OleDbCommand("UPDATE Issues SET Status = 'AODA - Enhancement Released' WHERE Status = 'AODA - Enhancement' AND [FLEXS Ticket] IN (" & lstFLEXS & ")", connection)
                    upd = command.ExecuteNonQuery
                    command = New OleDbCommand("UPDATE Issues SET Status = 'Enhancement - Released' WHERE Status = 'Enhancement - Escalated to Product' AND [FLEXS Ticket] IN (" & lstFLEXS & ")", connection)
                    upd = command.ExecuteNonQuery
                End If

                If i > 0 Then
                    Main.AuditTableAdapter.Fill(Main.ProdSupport_DataSet.Audit)
                    MsgBox("Successfully updated " & i & " records!")
                Else
                    MsgBox("Failed to update!")
                End If
            Else
                MsgBox("None of these tickets exist in the database! Exiting...", MsgBoxStyle.Exclamation, "No matching FLEXS found!")
            End If

        End Using


    End Sub

    Private Sub Initialize_DGView()

        RadGridView1.Columns.Clear()

        With RadGridView1

            .AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            .ColumnCount = 14


            With .Columns(0)
                .Name = "Key"
                '.Width = 55
                '.AutoSizeMode = BestFitColumnMode.AllCells
                .HeaderText = "Key"
            End With
            With .Columns(1)
                .Name = "Summary"
                '.Width = 310
                .HeaderText = "Summary"
            End With
            With .Columns(2)
                .Name = "Status"
                '.Width = 810
                .HeaderText = "Status"
            End With
            With .Columns(3)
                .Name = "Assignee"
                '.Width = 810
                .HeaderText = "Assignee"
            End With
            With .Columns(4)
                .Name = "Reporter"
                '.Width = 810
                .HeaderText = "Reporter"
            End With
            With .Columns(5)
                .Name = "Created"
                '.Width = 810
                .HeaderText = "Created"
            End With
            With .Columns(6)
                .Name = "Updated"
                '.Width = 810
                .HeaderText = "Updated"
            End With
            With .Columns(7)
                .Name = "Labels"
                '.Width = 810
                .HeaderText = "Labels"
            End With
            With .Columns(8)
                .Name = "Carriers"
                '.Width = 810
                .HeaderText = "Carriers"
            End With
            With .Columns(9)
                .Name = "FLEXSClients"
                '.Width = 810
                .HeaderText = "Clients"
            End With
            With .Columns(10)
                .Name = "EpicName"
                '.Width = 810
                .HeaderText = "Epic Name"
            End With
            With .Columns(11)
                .Name = "EpicLink"
                '.Width = 810
                .HeaderText = "Epic Link"
            End With
            With .Columns(12)
                .Name = "ReleaseDate"
                '.Width = 810
                .HeaderText = "Release Date"
            End With
            With .Columns(13)
                .Name = "ReleaseName"
                '.Width = 810
                .HeaderText = "Release"
            End With
        End With

        Dim checkBoxColumn As New GridViewCheckBoxColumn()
        checkBoxColumn.DataType = GetType(Integer)
        checkBoxColumn.Name = "Selected"
        'checkBoxColumn.FieldName = "Discontinued"
        checkBoxColumn.HeaderText = ""
        checkBoxColumn.EnableHeaderCheckBox = True
        RadGridView1.MasterTemplate.Columns.Add(checkBoxColumn)


    End Sub

    Private Sub BtnExists_Click(sender As Object, e As EventArgs) Handles BtnExists.Click
        RadOverlayManager.Show(Me.RadGridView1)

        If Not Me.RadGridView1.Columns.Contains("Exists") Then
            Dim checkBoxexistsColumn As New GridViewCheckBoxColumn()
            checkBoxexistsColumn.DataType = GetType(Integer)
            checkBoxexistsColumn.Name = "Exists"
            checkBoxexistsColumn.HeaderText = "Exists"
            RadGridView1.MasterTemplate.Columns.Add(checkBoxexistsColumn)

            'Dim obj = New ConditionalFormattingObject("GreenExisting", ConditionTypes.Greater, "0", "", True)
            'obj.RowBackColor = Color.PaleGreen
            'Me.RadGridView1.Columns("Exists").ConditionalFormattingObjectList.Add(obj)
        End If

        If Me.RadGridView1.Columns("Exists").ConditionalFormattingObjectList.Count > 0 Then Me.RadGridView1.Columns("Exists").ConditionalFormattingObjectList.Clear()
        Dim obj = New ConditionalFormattingObject("Existing", ConditionTypes.Greater, "0", "", True)
        Select Case Me.CboChannel.SelectedValue
        '1   Medavie Blue Cross
        '2   Canada Life
        '3   Green Shield Canada
        '4   Direct
        '5   Desjardins
        '6   Internal
        '7   Benefits Helpdesk
        '8   People Corp
        '9   TELUS
        '10  ALL
        '11  iA Financial Group
        '12  Internal-CAPEX
        '13  Hidden
            Case 1
                obj.RowBackColor = Color.DeepSkyBlue
                Me.RadGridView1.Columns("Exists").ConditionalFormattingObjectList.Add(obj)
            Case 2
                obj.RowBackColor = Color.Crimson
                obj.RowForeColor = Color.White
                Me.RadGridView1.Columns("Exists").ConditionalFormattingObjectList.Add(obj)
            Case 3
                obj.RowBackColor = Color.LimeGreen
                Me.RadGridView1.Columns("Exists").ConditionalFormattingObjectList.Add(obj)
            Case 5
                obj.RowBackColor = Color.SeaGreen
                obj.RowForeColor = Color.White
                Me.RadGridView1.Columns("Exists").ConditionalFormattingObjectList.Add(obj)
            Case 9
                obj.RowBackColor = Color.Indigo
                obj.RowForeColor = Color.White
                Me.RadGridView1.Columns("Exists").ConditionalFormattingObjectList.Add(obj)
            Case 11
                obj.RowBackColor = Color.MediumBlue
                obj.RowForeColor = Color.White
                Me.RadGridView1.Columns("Exists").ConditionalFormattingObjectList.Add(obj)
            Case Else
                obj.RowBackColor = Color.PaleGreen
                Me.RadGridView1.Columns("Exists").ConditionalFormattingObjectList.Add(obj)
        End Select

        Dim qryExists As String = "" '"SELECT COUNT(ID) FROM Issues WHERE [FLEXS Ticket] = (" & lstFLEXS & ")"

        Using connection As New OleDbConnection(My.Settings.DB_Connection)

            connection.Open()
            For row As Integer = 0 To RadGridView1.RowCount - 1
                qryExists = If(Me.CboChannel.SelectedIndex <> -1,
                    DirectCast("SELECT COUNT(ID) FROM Issues WHERE [Assigned To] = 226 AND [FLEXS Ticket] = (" & RadGridView1.Rows(row).Cells("Key").Value.ToString().Replace("FLEXS-", "") & ") AND Channel = " & Me.CboChannel.SelectedValue, String),
                    "SELECT COUNT(ID) FROM Issues WHERE [Assigned To] = 226 AND [FLEXS Ticket] = (" & RadGridView1.Rows(row).Cells("Key").Value.ToString().Replace("FLEXS-", "") & ")")
                If Me.CboClient.SelectedIndex <> -1 Then qryExists += " AND Client = " & Me.CboClient.SelectedValue

                Dim command As New OleDbCommand(qryExists, connection)
                Dim exists As Integer = command.ExecuteScalar
                RadGridView1.Rows(row).Cells("Exists").Value = If(exists > 0, 1, 0)
                'If exists > 0 Then
                '    RadGridView1.Rows(row).Cells("Exists").Value = 1
                'Else
                '    RadGridView1.Rows(row).Cells("Exists").Value = 0
                'End If
            Next
        End Using

        'Dim clientcol As New GridViewComboBoxColumn()
        'clientcol.DataType = GetType(Integer)
        'clientcol.Name = "Client"
        'clientcol.DataSource = Main.ClientsTableAdapter.GetData
        'clientcol.HeaderText = "Client"
        'clientcol.DisplayMember = "Client Name"
        'clientcol.ValueMember = "ID"
        'clientcol.ReadOnly = False
        'RadGridView1.MasterTemplate.Columns.Add(clientcol)

        RadOverlayManager.Close()
    End Sub

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click

        Dim i As Integer = 0

        Using connection As New OleDbConnection(My.Settings.DB_Connection)
            connection.Open()
            For row As Integer = 0 To RadGridView1.RowCount - 1
                If RadGridView1.Rows(row).Cells("Selected").Value = 1 Then
                    Dim cmdAddIssue As New OleDbCommand("INSERT INTO Issues (Channel, Client, Title, Description, [Assigned To], [Date Received], Status, Priority, [FLEXS Ticket]) VALUES (" & Me.CboChannel.SelectedValue & ", " & Me.CboClient.SelectedValue & ", '" & RadGridView1.Rows(row).Cells("Summary").Value.ToString().Replace("'", "''") & "' , 'FLEXS Ticket', 226, #" & RadGridView1.Rows(row).Cells("Created").Value & "#, '" & Me.CboStatus.SelectedItem.Text & "', NULL, " & RadGridView1.Rows(row).Cells("Key").Value.ToString().Replace("FLEXS-", "") & ");", connection)
                    i += cmdAddIssue.ExecuteNonQuery
                    'If lstFLEXS = "" Then
                    '    lstFLEXS = RadGridView1.Rows(row).Cells("Key").Value.ToString().Replace("FLEXS-", "")
                    'ElseCreated
                    '    lstFLEXS += ", " & RadGridView1.Rows(row).Cells("Key").Value.ToString().Replace("FLEXS-", "")
                    'End If
                End If
            Next

            If i = 1 Then
                MsgBox("1 Record Created!")
            ElseIf i > 0 Then
                MsgBox(i & " Records Created")
            End If

            'Dim queryString As String = "SELECT ID FROM Issues WHERE [FLEXS Ticket] IN (" & 1 & ")"

            'Dim command As New OleDbCommand(qryNbResults, connection)
            'connection.Open()

            'Dim nbResults As Integer = command.ExecuteScalar

            'Dim upd As Integer

            'command = New OleDbCommand(queryString, connection)
            'If ChkUpdComment.Checked = True Then
            '    If TxtNewComment.Text <> "" Then
            '        Dim reader As OleDbDataReader = command.ExecuteReader()

            '        While reader.Read()
            '            Dim cmdAddComment As New OleDbCommand("INSERT INTO Audit (IssueID, DateAdded, Username, Comment) VALUES (" & reader(0).ToString() & ", #" & Now() & "#, 'ProdMgmt', '" & TxtNewComment.Text & "');", connection)
            '            i += cmdAddComment.ExecuteNonQuery
            '        End While
            '        reader.Close()
            '    Else
            '        MsgBox("The comment field is empty!", MsgBoxStyle.Exclamation, "No comment entered!")
            '    End If
            'End If
        End Using

    End Sub
End Class
