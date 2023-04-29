Imports System.ComponentModel
Imports System.Data.Common
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Html
Imports Telerik.WinForms.Documents.FormatProviders.Txt
Imports Telerik.WinForms.Documents.Model
Imports System.Text.RegularExpressions
Imports System.Data.OleDb
'Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls.UI.SplashScreen
Imports System.Threading.Tasks

Public Class Main
    Public provider As HtmlFormatProvider = New HtmlFormatProvider()
    Public htmlImportSettings As HtmlImportSettings = New HtmlImportSettings()
    Private timer As Timer
    Private random As Random = New Random()
    Private currentProgress As Integer = 0
    Public columnName As String = ""
    Public oldvalue As Object = ""
    Public newValue As Object = ""
    Public id As Integer = 0
    'Public provider2 As TxtFormatProvider = New TxtFormatProvider()
    Private WithEvents bgWorker As New BackgroundWorker

    Private Sub ShapedForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler RadFlyoutManager.FlyoutClosed, AddressOf Me.RadFlyoutManager_FlyoutClosed

        ThemeResolutionService.LoadPackageResource("RequestsManager.Office2019LightPurple.tssp")
        ThemeResolutionService.ApplicationThemeName = "Office2019LightPurple"
        Me.DtPckReceived.DateTimePickerElement.ShowTimePicker = True
        Me.DtPckUpdated.DateTimePickerElement.ShowTimePicker = True
        TryCast(Me.DtPckReceived.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar).DropDownMinSize = New System.Drawing.Size(330, 250)
        TryCast(Me.DtPckUpdated.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar).DropDownMinSize = New System.Drawing.Size(330, 250)

        Me.CboChannel.Enabled = False
        Me.CboClient.Enabled = False
        Me.CboAnalyst.Enabled = False
        Me.CboCat.Enabled = False
        Me.CboReporter.Enabled = False
        Me.CboStatus.Enabled = False

        ' Initialize the BackgroundWorker
        bgWorker.WorkerSupportsCancellation = True
        bgWorker.WorkerReportsProgress = True

        ' Start the BackgroundWorker
        'RadOverlayManager.Show(Me)
        bgWorker.RunWorkerAsync()
        'RadOverlayManager.Show(Me.RadLayoutControl1)
        'Me.IssuesTableAdapter.Adapter.

        '
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork

        bgWorker.ReportProgress(10, "FillPriorities")
        bgWorker.ReportProgress(20, "FillStatuses")
        bgWorker.ReportProgress(30, "FillCategories")
        bgWorker.ReportProgress(40, "FillContacts_Extended")
        bgWorker.ReportProgress(50, "FillClients")
        bgWorker.ReportProgress(60, "FillChannels")
        bgWorker.ReportProgress(70, "FillAnalysts")
        bgWorker.ReportProgress(80, "FillHours")
        bgWorker.ReportProgress(90, "FillAudit")
        bgWorker.ReportProgress(95, "FillIssues")
        bgWorker.ReportProgress(99, "TagFormUsername")

    End Sub

    'Private Async Sub bgWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgWorker.ProgressChanged
    '    Select Case e.UserState
    '        Case "FillPriorities"
    '            Await Task.Run(Sub() Me.PrioritiesTableAdapter.Fill(Me.ProdSupport_DataSet.Priorities))
    '        Case "FillStatuses"
    '            Await Task.Run(Sub() Me.StatusesTableAdapter.Fill(Me.ProdSupport_DataSet.Statuses))
    '            'Me.CboStatus.Enabled = True
    '        Case "FillCategories"
    '            Await Task.Run(Sub() Me.CategoriesTableAdapter.Fill(Me.ProdSupport_DataSet.Categories))
    ''            Me.CboCat.Enabled = True
    '        Case "FillContacts_Extended"
    '            Await Task.Run(Sub() Me.Contacts_ExtendedTableAdapter.Fill(Me.ProdSupport_DataSet.Contacts_Extended))
    ''            Me.CboReporter.Enabled = True
    '        Case "FillAnalysts"
    '            Await Task.Run(Sub() Me.AnalystsTableAdapter.Fill(Me.ProdSupport_DataSet.Analysts))
    ''            Me.CboAnalyst.Enabled = True
    '        Case "FillClients"
    '            Await Task.Run(Sub() Me.ClientsTableAdapter.Fill(Me.ProdSupport_DataSet.Clients))
    '            'Me.CboClient.Enabled = True
    '        Case "FillChannels"
    '            Await Task.Run(Sub() Me.ChannelsTableAdapter.Fill(Me.ProdSupport_DataSet.Channels))
    '            'Me.CboChannel.Enabled = True
    '        Case "FillHours"
    '            Await Task.Run(Sub() Me.Tbl_HoursWorkedLogTableAdapter.Fill(Me.ProdSupport_DataSet.tbl_HoursWorkedLog))
    '        'Case "FillAudit"
    '        '    Await Task.Run(Sub() Me.AuditTableAdapter.Fill(Me.ProdSupport_DataSet.Audit))
    '        Case "FillIssues"
    '            '    If UCase(Environment.UserName) = "T989040" Or UCase(Environment.UserName) = "T970773" Or UCase(Environment.UserName) = "T931026" Or UCase(Environment.UserName) = "T987667" Or UCase(Environment.UserName) = "HELLF" Then
    '            '        Await Task.Run(Sub() Me.IssuesTableAdapter.FillProductTeam(Me.ProdSupport_DataSet.Issues))
    '            '    Else
    '            '        Dim Answ As MsgBoxResult = MsgBox("Do you want to load the issues at this time?", vbYesNo, "Load issues data")
    '            '        If Answ = vbYes Then
    '            Await Task.Run(Sub() Me.IssuesTableAdapter.FillByActive(Me.ProdSupport_DataSet.Issues))
    '            '        End If
    '            '    End If
    '            'Case "TagFormUsername"
    '            '    Dim conn As New OleDbConnection(My.Settings.Item("DB_Connection"))
    '            '    Dim cmd As New OleDbCommand("SELECT [Contact Name] FROM [Contacts Extended] WHERE TELUS_ID = @username", conn)
    '            '    cmd.Parameters.AddWithValue("@username", UCase(Environment.UserName))

    '            '    Using conn

    '            '        conn.Open()
    '            '        Dim reader As OleDbDataReader = cmd.ExecuteReader()
    '            '        If reader.Read() Then
    '            '            'Me.Tag = reader("Contact Name").ToString()
    '            '        End If
    '            '    End Using
    '            '    conn.Close()
    '    End Select
    'End Sub


    Private Sub bgWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgWorker.ProgressChanged

        Select Case e.UserState
            Case "FillPriorities"
                Me.PrioritiesTableAdapter.Fill(Me.ProdSupport_DataSet.Priorities)
            Case "FillStatuses"
                Me.StatusesTableAdapter.Fill(Me.ProdSupport_DataSet.Statuses)
                Me.CboStatus.Enabled = True
            Case "FillCategories"
                Me.CategoriesTableAdapter.Fill(Me.ProdSupport_DataSet.Categories)
                Me.CboCat.Enabled = True
            Case "FillContacts_Extended"
                Me.Contacts_ExtendedTableAdapter.Fill(Me.ProdSupport_DataSet.Contacts_Extended)
                Me.CboReporter.Enabled = True
            Case "FillAnalysts"
                Me.AnalystsTableAdapter.Fill(Me.ProdSupport_DataSet.Analysts)
                Me.CboAnalyst.Enabled = True
            Case "FillClients"
                Me.ClientsTableAdapter.Fill(Me.ProdSupport_DataSet.Clients)
                Me.CboClient.Enabled = True
            Case "FillChannels"
                Me.ChannelsTableAdapter.Fill(Me.ProdSupport_DataSet.Channels)
                Me.CboChannel.Enabled = True
            Case "FillHours"
                Me.Tbl_HoursWorkedLogTableAdapter.Fill(Me.ProdSupport_DataSet.tbl_HoursWorkedLog)
            Case "FillAudit"
                Me.AuditTableAdapter.Fill(Me.ProdSupport_DataSet.Audit)
            Case "FillIssues"
                If UCase(Environment.UserName) = "T989040" Or UCase(Environment.UserName) = "T970773" Or UCase(Environment.UserName) = "T931026" Or UCase(Environment.UserName) = "T987667" Or UCase(Environment.UserName) = "HELLF" Then
                    Me.IssuesTableAdapter.FillProductTeam(Me.ProdSupport_DataSet.Issues)
                Else
                    'Dim Answ As MsgBoxResult = MsgBox("Do you want to load the issues at this time?", vbYesNo, "Load issues data")
                    'If Answ = vbYes Then
                    Me.IssuesTableAdapter.FillByActive(Me.ProdSupport_DataSet.Issues)
                    'End If
                End If
            Case "TagFormUsername"
                Dim conn As New OleDbConnection(My.Settings.Item("DB_Connection"))
                Dim cmd As New OleDbCommand("SELECT [Contact Name] FROM [Contacts Extended] WHERE TELUS_ID = @username", conn)
                cmd.Parameters.AddWithValue("@username", UCase(Environment.UserName))

                Using conn
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Me.Tag = reader("Contact Name").ToString()
                    End If
                End Using
                conn.Close()
        End Select

    End Sub
    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        ' Update the UI after the data is loaded
        If e.Error IsNot Nothing Then
            MessageBox.Show("Error: " & e.Error.Message)
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim ofrm As New ShapedForm2
        ofrm.Show()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim Allo As Integer = Me.RadGridView1.CurrentRow.Index
        Try
            Me.Validate()
            Me.IssuesBindingSource.EndEdit()
            Me.IssuesTableAdapter.Update(Me.ProdSupport_DataSet.Issues)
            MsgBox("Update successful")
            'Me.IssuesTableAdapter.FillByActive(Me.ProdSupport_DataSet.Issues)
            'Me.RadGridView1.Update()

            'Me.RadGridView1.Rows(Allo).IsSelected = True
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & "Update failed")
        End Try
    End Sub

    Private Sub RadRichTextEditor1_TextChanged(sender As Object, e As EventArgs) Handles RichTxtDesc.TextChanged
        'Me.RadRichTextEditor1.Document = provider.Import(Me.RadRichTextEditor1.Text)
    End Sub

    Private Sub RadRichTextEditor1_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles RichTxtDesc.PropertyChanged
        'Me.RadRichTextEditor1.Document = provider.Import(Me.RadRichTextEditor1.Text)
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellClick
        'Me.RadRichTextEditor1.Document.HasStyle = False
        'htmlImportSettings.UseDefaultStylesheetForFontProperties = True
        'htmlImportSettings.UseHtmlHeadingStyles = False
        'provider.ImportSettings = htmlImportSettings

        RichTxtDesc.RichTextBoxElement.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Comic Sans MS"))
        RichTxtDesc.RichTextBoxElement.ChangeFontSize(Unit.PointToDip(12))
        RichTxtDesc.RichTextBoxElement.ChangeFontStyle(Telerik.WinControls.RichTextEditor.UI.FontStyles.Italic)
        RichTxtDesc.RichTextBoxElement.ChangeFontWeight(Telerik.WinControls.RichTextEditor.UI.FontWeights.Bold)
        RichTxtDesc.DocumentInheritsDefaultStyleSettings = True

        'Me.RadRichTextEditor1.Document = provider.Import(Me.RadRichTextEditor1.Text)
        If Me.RichTxtDesc.Text <> "" Then Me.RichTxtDesc.Text = StripTags(Me.RichTxtDesc.Text)
        Me.RichTxtDesc.GetPlainText()
        Me.RichTxtDesc.DocumentEditor.ChangeFontSize(30)


        'Dim cococo As RadDocument = Me.RadRichTextEditor1.Document
        'cococo = Me.RadRichTextEditor1.Document
        'Dim provider2 As New TxtFormatProvider()
        'Me.RadRichTextEditor1.Document = provider2.Import(Me.RadRichTextEditor1.Text)

        'If Me.RadRichTextEditor1.Text <> "" Then Me.RadRichTextEditor1.Text = StripTags(Me.RadRichTextEditor1.Text)

        'Me.RadRichTextEditor1.Document.BeginStylesUpdate()
        'Me.RadRichTextEditor1.Document.ParagraphDefaultSpacingAfter = 1.5
        'Me.RadRichTextEditor1.Document.ParagraphDefaultSpacingBefore = 1.5
        'Me.RadRichTextEditor1.RichTextBoxElement.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Arial Nova"))
        'Me.RadRichTextEditor1.RichTextBoxElement.ChangeFontSize(9)
        'Me.RadRichTextEditor1.DocumentInheritsDefaultStyleSettings = True
        'Me.RadRichTextEditor1.Document.EndStylesUpdate()

    End Sub

    Function StripTags(ByVal html As String) As String
        On Error Resume Next
        'Return Regex.Replace(html, "<(.|\n)*?>", String.Empty)
        Return Regex.Replace(Regex.Replace(Regex.Replace(Replace(html, "&nbsp;", String.Empty), "<(.|\n)*?>", String.Empty), "(\r?\n){2,}", vbCrLf), "^[\s]+|[\s]+$", String.Empty, RegexOptions.Multiline)
    End Function

    Private Sub RadGridView1_DefaultValuesNeeded(sender As Object, e As GridViewRowEventArgs) Handles RadGridView1.DefaultValuesNeeded
        'e.Row.ViewTemplate.
        e.Row.Cells("Priority").Value = "(2) Medium"
        e.Row.Cells("Status").Value = "Not Started"
        e.Row.Cells("Category").Value = "Troubleshooting"
        'e.Row.Cells("Analyst").Value = 1
    End Sub

    Private Sub RadGridView1_RowSourceNeeded(sender As Object, e As GridViewRowSourceNeededEventArgs) Handles RadGridView1.RowSourceNeeded

    End Sub

    Private Sub RadGridView1_PageChanging(sender As Object, e As PageChangingEventArgs) Handles RadGridView1.PageChanging

    End Sub



    Private Sub RadMenuItem2_Click(sender As Object, e As EventArgs) Handles MenuBtnAddPerson.Click
        Dim ofrm As New ShapedForm2
        ofrm.Show()
    End Sub

    Public Function Gettxt(ByVal document As RadDocument) As String
        Dim provider2 As New TxtFormatProvider()
        Return provider2.Export(Me.RichTxtDesc.Document)
        RichTxtDesc.DocumentEditor.ChangeFontSize(6)
        RichTxtDesc.DocumentEditor.ChangeForeColor(Color.Coral)
    End Function

    Private Sub RadGridView1_RowsChanging(sender As Object, e As GridViewCollectionChangingEventArgs) Handles RadGridView1.RowsChanging

    End Sub

    Private Sub IssuesBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles IssuesBindingSource.CurrentItemChanged

        'If Me.IssuesBindingSource.List.Item Then

        'End If
    End Sub

    Private Sub RadGridView1_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs) Handles RadGridView1.CurrentRowChanged
        If Not Me.ProdSupport_DataSet.HasChanges Then Exit Sub
        If e.OldRow Is Nothing Then
            Return
        End If
        Dim dataRowView As DataRowView = TryCast(e.OldRow.DataBoundItem, DataRowView)
        If dataRowView IsNot Nothing Then
            Dim dataRow As DataRow = dataRowView.Row
            If dataRow.RowState = DataRowState.Modified Then
                If MsgBox("Update?", vbYesNo, "Oui?") = MsgBoxResult.No Then
                    e.CurrentRow.InvalidateRow()

                    Return
                End If

                If Me.IssuesTableAdapter.Update(dataRow) > 0 Then
                    MsgBox("Update successful")
                End If
            End If
        End If


        'Me.IssuesBindingSource.EndEdit()
        'Me.IssuesTableAdapter.Update(Me.ProdSupport_DataSet.Issues)
        'MsgBox("Update successful")
        'Me.IssuesTableAdapter.FillByActive(Me.ProdSupport_DataSet.Issues)
        'Me.RadGridView1.Update()

        'Me.RadGridView1.Rows(Allo).IsSelected = True
    End Sub

    Private Sub RadMenuItem3_Click(sender As Object, e As EventArgs) Handles MenuBtnFLEXSMgmt.Click
        Dim FLEXSfrm As New FLEXS_Mgmt
        FLEXSfrm.StartPosition = FormStartPosition.CenterScreen
        FLEXSfrm.ShowDialog()
    End Sub

    Private Sub RadGridView1_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles RadGridView1.UserAddedRow



        Dim dataRowView As DataRowView = TryCast(e.Rows(0).DataBoundItem, DataRowView)
        Dim row As DataRow = dataRowView.Row
        Me.IssuesTableAdapter.Update(row)
        Dim cmdNewID As New OleDbCommand("SELECT @@IDENTITY",
           Me.IssuesTableAdapter.Connection)
        'e.Rows(0).(0) = CInt(cmdNewID.ExecuteScalar)
        e.Rows(0).DataBoundItem("ID") = CInt(cmdNewID.ExecuteScalar)
    End Sub

    Private Shared Sub OnRowUpdated(
    ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
        ' Conditionally execute this code block on inserts only.
        If e.StatementType = StatementType.Insert Then
            ' Retrieve the Autonumber and store it in the CategoryID column.
            ' Dim cmdNewID As New OleDbCommand("SELECT @@IDENTITY",
            'connection)
            'e.Row("CategoryID") = CInt(cmdNewID.ExecuteScalar)
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub RadTextBox3_Click(sender As Object, e As EventArgs) Handles TxtFLEXS.Click
        If TxtFLEXS.Text = "" Then Exit Sub
        Dim JIRAfrm As New JIRADetails
        JIRAfrm.StartPosition = FormStartPosition.CenterScreen
        JIRAfrm.ShowDialog()
    End Sub

    Private Sub menuJIRA_Click(sender As Object, e As EventArgs) Handles menuJIRA.Click
        Dim frmJIRAsrch As New JIRASearch(Me.CboChannel, Me.CboClient) With {
            .StartPosition = FormStartPosition.CenterScreen
        }
        frmJIRAsrch.ShowDialog()
    End Sub

    Private Sub RadFlyoutManager_FlyoutClosed(ByVal e As FlyoutClosedEventArgs)
        If e.Content.Name = "FlyoutLogHours" Then
            Dim action As Action = New Action(Sub()
                                                  Dim content As FlyoutLogHours = TryCast(e.Content, FlyoutLogHours)

                                                  If content IsNot Nothing Then
                                                      Dim callout As RadCallout = New RadCallout()
                                                      callout.ArrowDirection = Telerik.WinControls.ArrowDirection.Down
                                                      'callout.ThemeName = Me.CurrentThemeName

                                                      If content.Result = DialogResult.OK Then
                                                          Dim dtHours As DateTime = $"{content.DateHours}"
                                                          Dim Hours As Double = $"{content.Hours}"
                                                          Dim Billable As Boolean = $"{content.Billable}"
                                                          Dim Details As String = $"{content.Details}"
                                                          Dim Employee As String = Me.Tag
                                                          'Me.AuditTableAdapter.update()
                                                          Try
                                                              Me.Tbl_HoursWorkedLogTableAdapter.Insert(CInt(Me.TxtID.Text), Nothing, Nothing, Employee, dtHours, CDec(Hours), Billable, Details)

                                                              Me.ProdSupport_DataSet.tbl_HoursWorkedLog.AcceptChanges()
                                                              Dim cococo As Integer = Me.Tbl_HoursWorkedLogTableAdapter.Update(Me.ProdSupport_DataSet.tbl_HoursWorkedLog)
                                                              'Me.Tbl_HoursWorkedLogTableAdapter.ClearBeforeFill = False
                                                              Me.Tbl_HoursWorkedLogTableAdapter.Fill(Me.ProdSupport_DataSet.tbl_HoursWorkedLog)
                                                              Exit Sub
                                                          Catch Ex As Exception
                                                              MsgBox(Ex.Message)
                                                              Exit Sub
                                                          End Try

                                                          Dim SQLAddHours As New OleDbCommand("INSERT INTO tbl_HoursWorkedLog (Issue_ID, Employee, Hours_Worked_Date, Hours_Worked_Amt, Billable, Details) VALUES (" & Me.TxtID.Text & ", '" & Employee & "', #" & dtHours & "#, " & CStr(Hours) & ", " & Billable & ", '" & Details & "')", Me.Tbl_HoursWorkedLogTableAdapter.Connection)
                                                          Me.Tbl_HoursWorkedLogTableAdapter.Connection.Open()

                                                          If CInt(SQLAddHours.ExecuteNonQuery) > 0 Then
                                                              RadCallout.Show(callout, Me.BtnLogTime, $"Hours were successfully logged!", "Success")
                                                              Me.Tbl_HoursWorkedLogTableAdapter.Fill(Me.ProdSupport_DataSet.tbl_HoursWorkedLog)
                                                          Else
                                                              RadCallout.Show(callout, Me.BtnLogTime, $"There was a problem! Try again!", "Failed")
                                                          End If
                                                          Me.Tbl_HoursWorkedLogTableAdapter.Connection.Close()
                                                      Else
                                                          RadCallout.Show(callout, Me.BtnLogTime, "Hours logging was cancelled!", "Cancelled")
                                                      End If
                                                  End If
                                              End Sub)
            Me.Invoke(action)
        ElseIf e.Content.Name = "FlyoutInteractiveContent" Then


            Dim action As Action = New Action(Sub()
                                                  Dim content As FlyoutInteractiveContent = TryCast(e.Content, FlyoutInteractiveContent)

                                                  If content IsNot Nothing Then
                                                      Dim callout As RadCallout = New RadCallout()
                                                      callout.ArrowDirection = Telerik.WinControls.ArrowDirection.Down
                                                      'callout.ThemeName = Me.CurrentThemeName

                                                      If content.Result = DialogResult.OK Then
                                                          Dim comment As String = $"{content.Comment}"
                                                          'Me.AuditTableAdapter.update()
                                                          Dim SQLAddAudit As New OleDbCommand("INSERT INTO Audit (IssueID, DateAdded, Username, Comment) VALUES (" + Me.TxtID.Text + ", #" + Now() + "#, '" + UCase(Environment.UserName) + "', '" + comment + "')", Me.AuditTableAdapter.Connection)
                                                          Me.AuditTableAdapter.Connection.Open()

                                                          If CInt(SQLAddAudit.ExecuteNonQuery) > 0 Then
                                                              RadCallout.Show(callout, Me.BtnAddComment, $"The comment has been saved!", "Success")
                                                              Me.AuditTableAdapter.Fill(Me.ProdSupport_DataSet.Audit)
                                                          Else
                                                              RadCallout.Show(callout, Me.BtnAddComment, $"There was a problem! Try again!", "Failed")
                                                          End If
                                                          Me.AuditTableAdapter.Connection.Close()
                                                      Else
                                                          RadCallout.Show(callout, Me.BtnAddComment, "The comment was not saved!", "Cancelled")
                                                      End If
                                                  End If
                                              End Sub)
            Me.Invoke(action)
        End If

    End Sub

    Private Sub BtnAddComment_Click(sender As Object, e As EventArgs) Handles BtnAddComment.Click
        'RadFlyoutManager.FlyoutInstance.ThemeName = Me.CurrentThemeName
        RadFlyoutManager.Show(Me, GetType(FlyoutInteractiveContent))
    End Sub

    Private Sub RadMenuItem5_Click(sender As Object, e As EventArgs) Handles MenuBtnCollapseAll.Click
        Me.RadGridView1.MasterTemplate.CollapseAll()

    End Sub

    Private Sub RadMenuItem4_Click(sender As Object, e As EventArgs) Handles MenuBtnHours.Click
        Dim FrmHoursSummary As New HoursSummary
        FrmHoursSummary.StartPosition = FormStartPosition.CenterScreen
        FrmHoursSummary.ShowDialog()
    End Sub

    Private Sub RadMenuItem6_Click(sender As Object, e As EventArgs) Handles MenuBtnViewAll.Click
        Me.IssuesTableAdapter.FillByAll(Me.ProdSupport_DataSet.Issues)
    End Sub

    Private Sub MenuRefresh_Click(sender As Object, e As EventArgs) Handles MenuBtnRefresh.Click
        RadOverlayManager.Show(Me.RadLayoutControl1)
        If TogActiveAll.Value = False Then
            Me.IssuesTableAdapter.FillByAll(Me.ProdSupport_DataSet.Issues)
        Else
            If UCase(Environment.UserName) = "T989040" Or UCase(Environment.UserName) = "T970773" Or UCase(Environment.UserName) = "T931026" Or UCase(Environment.UserName) = "T987667" Or UCase(Environment.UserName) = "HELLF" Then
                Me.IssuesTableAdapter.FillProductTeam(Me.ProdSupport_DataSet.Issues)
            Else
                Me.IssuesTableAdapter.FillByActive(Me.ProdSupport_DataSet.Issues)
            End If
        End If
        RadOverlayManager.Close()
        Me.Activate()
    End Sub

    Private Sub TogActiveAll_ValueChanged(sender As Object, e As EventArgs) Handles TogActiveAll.ValueChanged
        RadOverlayManager.Show(Me.RadLayoutControl1)
        If TogActiveAll.Value = False Then
            Me.IssuesTableAdapter.FillByAll(Me.ProdSupport_DataSet.Issues)
        Else
            Me.IssuesTableAdapter.FillByActive(Me.ProdSupport_DataSet.Issues)
        End If
        RadOverlayManager.Close()
    End Sub

    Private Sub BtnLogTime_Click(sender As Object, e As EventArgs) Handles BtnLogTime.Click
        RadFlyoutManager.Show(Me, GetType(FlyoutLogHours))
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub TogActiveAll_ToolTipTextNeeded(sender As Object, e As ToolTipTextNeededEventArgs) Handles TogActiveAll.ToolTipTextNeeded
        e.ToolTipText = "You can toggle between displaying only active requests" & vbNewLine & "or all of them including completed ones."
    End Sub

    Private Sub RadMenuItem1_Click(sender As Object, e As EventArgs) Handles MenuBtnAddClient.Click

    End Sub

    Private Sub BindingSource1_ListChanged(sender As Object, e As ListChangedEventArgs) Handles IssuesBindingSource.ListChanged
        If e.ListChangedType = ListChangedType.ItemChanged Then
            Dim rowView As DataRowView = CType(IssuesBindingSource.List(e.NewIndex), DataRowView)
            Dim changedTable As DataTable = rowView.Row.Table.GetChanges(DataRowState.Modified)

            If changedTable IsNot Nothing AndAlso changedTable.Rows.Count > 0 Then
                'RadOverlayManager.Show(Me.RadGridView1)
                'Dim connectionString As String = "Data Source=I:\Shared drives\Flexit360 Apps (Alain)\Access DBs\Backups\Tests_Dev\ProdSupport.db;Mode=ReadWriteCreate;Cache=Shared"
                ''Dim connectionString As String = "Data Source=\\\\l4pncdot01svm02\WebsInc\Access DB - Prod Support\ProdSupport.db;Mode=ReadWriteCreate;Cache=Shared"
                'Using connection As New SQLiteConnection(connectionString)
                '    connection.Open()

                For Each column As DataColumn In changedTable.Columns
                    If Not rowView.Row(column.ColumnName).Equals(rowView.Row(column.ColumnName, DataRowVersion.Original)) Then
                        If columnName & oldvalue & newValue & id = column.ColumnName & rowView.Row(column.ColumnName, DataRowVersion.Original) & rowView.Row(column.ColumnName) & rowView.Row("ID") Then Exit Sub
                        columnName = column.ColumnName
                        oldvalue = rowView.Row(column.ColumnName, DataRowVersion.Original)
                        newValue = rowView.Row(columnName)
                        id = rowView.Row("ID") ' Assuming you have an ID column as a primary key

                        '' Update the SQLite database here using the columnName and the new value
                        'Dim updateCommand As New OleDbCommand($"UPDATE Issues SET {columnName} = @newValue WHERE ID = @id", connection)
                        'updateCommand.Parameters.AddWithValue("@newValue", newValue)
                        'updateCommand.Parameters.AddWithValue("@id", id)

                        'updateCommand.ExecuteNonQuery()

                        If columnName = "Priority" Then
                            Dim updateAuditPriorityCommand As New OleDbCommand($"INSERT INTO Audit (IssueID, DateAdded, Username, Comment) VALUES (@id, '" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' , '" & UCase(Environment.UserName) & "', @newValue)", Me.AuditTableAdapter.Connection)
                            Me.AuditTableAdapter.Connection.Open()
                            updateAuditPriorityCommand.Parameters.AddWithValue("@id", id)
                            updateAuditPriorityCommand.Parameters.AddWithValue("@newValue", "Priority changed from " & oldvalue & " to " & newValue)

                            updateAuditPriorityCommand.ExecuteNonQuery()
                            Me.AuditTableAdapter.Connection.Close()
                            Me.AuditTableAdapter.Fill(Me.ProdSupport_DataSet.Audit)
                            'dsAudit = qryLastAudit(connectionString)
                            'bsAudit.ResetBindings(False) UCase(Environment.UserName)
                        End If
                    End If
                Next


                'End Using
                'RadOverlayManager.Close()
            End If
        End If
    End Sub

    'Private Sub IssuestblHoursWorkedLogBindingSource_ListChanged(sender As Object, e As ListChangedEventArgs) Handles IssuestblHoursWorkedLogBindingSource.ListChanged
    'If Not Me.ProdSupport_DataSet.HasChanges Then Exit Sub


    'If e.OldRow Is Nothing Then
    '    Return
    'End If
    'Dim dataRowView As DataRowView = TryCast(e.OldRow.DataBoundItem, DataRowView)
    'If dataRowView IsNot Nothing Then
    '    Dim dataRow As DataRow = dataRowView.Row
    '    If dataRow.RowState = DataRowState.Modified Then
    'If MsgBox("Update?", vbYesNo, "Oui?") = MsgBoxResult.No Then
    '    'e.OldIndex.

    '    Return
    '        End If
    'Me.ProdSupport_DataSet.tbl_HoursWorkedLog.AcceptChanges()

    'If Me.Tbl_HoursWorkedLogTableAdapter.Update(Me.ProdSupport_DataSet.tbl_HoursWorkedLog) > 0 Then
    '    MsgBox("Update successful")
    '    'End If
    'End If
    'End If
    'End Sub

    'Private Sub IssuestblHoursWorkedLogBindingSource_AddingNew(sender As Object, e As AddingNewEventArgs) Handles IssuestblHoursWorkedLogBindingSource.AddingNew
    '    If Not Me.ProdSupport_DataSet.HasChanges Then Exit Sub


    '    'If e.OldRow Is Nothing Then
    '    '    Return
    '    'End If
    '    'Dim dataRowView As DataRowView = TryCast(e.OldRow.DataBoundItem, DataRowView)
    '    'If dataRowView IsNot Nothing Then
    '    '    Dim dataRow As DataRow = dataRowView.Row
    '    '    If dataRow.RowState = DataRowState.Modified Then
    '    If MsgBox("Update?", vbYesNo, "Oui?") = MsgBoxResult.No Then
    '        'e.OldIndex.

    '        Return
    '    End If
    '    Me.ProdSupport_DataSet.tbl_HoursWorkedLog.AcceptChanges()

    '    If Me.Tbl_HoursWorkedLogTableAdapter.Update(Me.ProdSupport_DataSet.tbl_HoursWorkedLog) > 0 Then
    '        MsgBox("Update successful")
    '        'End If
    '    End If
    'End Sub

    'Private Sub RadGridView1_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles RadGridView1.CellFormatting
    '    'If TypeOf e.CellElement Is GridHeaderCellElement AndAlso Not TypeOf e.CellElement Is CustomGridHeaderCellElement Then
    '    '    e.CellElement = New CustomGridHeaderCellElement(e.CellElement.ColumnInfo, e.CellElement.RowElement) ' e.CellElement.Row)
    '    'End If
    'End Sub


    'Private Sub RadGridView1_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles RadGridView1.FilterChanged
    '    'For Each column As GridViewColumn In RadGridView1.Columns
    '    '    Dim headerCell As CustomGridHeaderCellElement = TryCast(RadGridView1.TableElement.GetHeaderCell(column), CustomGridHeaderCellElement)
    '    '    If headerCell IsNot Nothing Then
    '    '        headerCell.UpdateFilterButtonColor()
    '    '    End If
    '    'Next
    '    UpdateAllFilterButtonColors()
    'End Sub
    'Private Sub UpdateAllFilterButtonColors()
    '    For Each child As RadElement In RadGridView1.TableElement.VisualRows(0).Children
    '        Dim headerCell As CustomGridHeaderCellElement = TryCast(child, CustomGridHeaderCellElement)
    '        If headerCell IsNot Nothing Then
    '            headerCell.UpdateFilterButtonColor()
    '        End If
    '    Next
    'End Sub
    ' Step 2: Replace the default header cell element in the CreateCell event
    'Private Sub RadGridView1_CreateCell(sender As Object, e As GridViewCreateCellEventArgs) Handles RadGridView1.CreateCell
    '    If e.CellType Is GetType(GridHeaderCellElement) Then
    '        e.CellElement = New CustomGridHeaderCellElement(e.Column, Nothing)
    '        e.CellType = GetType(CustomGridHeaderCellElement)
    '    End If
    'End Sub

#Region "Inutile"
    'Me.RadRichTextEditor1.Text
    'Me.RadRichTextEditor1.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Arial Nova"))
    'Me.RadRichTextEditor1.DocumentEditor.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Arial Nova"))
    'Me.RadRichTextEditor1.DocumentEditor.ChangeFontSize(10)

    'Me.RadRichTextEditor1.Document.LineSpacing = 1
    'Me.RadRichTextEditor1.Document.ParagraphDefaultSpacingAfter = 1.5
    'Me.RadRichTextEditor1.Document.ParagraphDefaultSpacingBefore = 1.5
    'Me.RadRichTextEditor1.RichTextBoxElement.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Arial Nova"))
    'Me.RadRichTextEditor1.RichTextBoxElement.ChangeFontSize(9)
    'Me.RadRichTextEditor1.DocumentInheritsDefaultStyleSettings = True
    'Me.RadRichTextEditor1.Text = Me.RadRichTextEditor1.GetPlainText
    'Me.RadRichTextEditor1.
    'Me.RadRichTextEditor1.sect
    'Me.RadRichTextEditor1.CurrentEditingStyle.ParagraphProperties.LineSpacing = 1
    'With Me.RadRichTextEditor1.CurrentEditingStyle.ParagraphProperties
    '    .SpacingAfter = 1.5
    '    .SpacingBefore = 1.5

    'End With
    'With Me.RadRichTextEditor1.CurrentEditingStyle.SpanProperties
    '    .FontFamily = New Telerik.WinControls.RichTextEditor.UI.FontFamily("Arial Nova")
    'End With
    'Me.RadRichTextEditor1.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Arial Nova"))
    'Me.RadRichTextEditor1.ChangeFontSize(11)
    'Me.RadRichTextEditor1.DocumentEditor.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Arial Nova"))
    'Me.RadRichTextEditor1.DocumentEditor.ChangeFontSize(10)
#End Region
End Class


