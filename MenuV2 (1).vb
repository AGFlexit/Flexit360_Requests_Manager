﻿Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Text.RegularExpressions
Imports DevExpress.XtraGrid.Views.Base
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.Threading
Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel
Imports System.Linq

Partial Public Class MenuV2
    Private CurrentUserID As Integer

    Public Sub New()
        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard


        Select Case UCase(Environment.UserName)
            Case "T989040", "T970773", "T931026" ', "HELLF"
                navBarControl.ActiveGroup = DefectsNavBarGroup
                'Me.GridControl1.Visible = False
                'Me.GridControl2.Visible = True
            Case Else
                navBarControl.ActiveGroup = RequestsNavBarGroup
                'Me.GridControl1.Visible = True
                'Me.GridControl2.Visible = False
        End Select
        'Dim RichTxtEdit As RichTextBox
        AddHandler GVIssues.EditFormPrepared, Sub(s, e)
                                                  ' The 'e.BindableControls' collection contains the editors in the Edit Form.
                                                  Dim RichTxtEdit As Control = e.BindableControls(GridColumn34)
                                                  'RichTxtEdit.Text = e.RowHandle
                                                  Dim row As DataRow = GVIssues.GetDataRow(e.RowHandle)
                                                  'Dim description As String = row("Description").ToString()
                                                  RichTxtEdit.Text = If(String.IsNullOrEmpty(row("Description").ToString()), String.Empty, String.Format(StripTags(row("Description").ToString()))) 'StripTags(row("Description").ToString())
                                                  'For Each item As Control In e.BindableControls
                                                  NewCommentIssueID = CInt(row("ID").ToString)
                                                  Dim MemoAudit As Control = e.BindableControls(colAudit)
                                                  Dim rowAudit As DataRow() = row.GetChildRows("IssuesAudit")
                                                  If rowAudit.Count > 0 Then
                                                      'MemoAudit.Text = rowAudit(rowAudit.Count - 1)("Comment").ToString
                                                      Dim highestID As Integer = rowAudit.Max(Function(r) Convert.ToInt32(r("ID")))
                                                      Dim highestIDRow As DataRow = rowAudit.FirstOrDefault(Function(r) Convert.ToInt32(r("ID")) = highestID)
                                                      If highestIDRow IsNot Nothing Then
                                                          MemoAudit.Text = highestIDRow("Comment").ToString()
                                                          MemoAudit.Tag = highestIDRow("Comment").ToString()
                                                          'MemoAudit.
                                                      End If
                                                  End If
                                              End Sub

    End Sub
    Private Sub MenuV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataAsync()
    End Sub

    Private Sub GridView1_CalcPreviewText(sender As Object, e As CalcPreviewTextEventArgs) Handles GVIssues.CalcPreviewText
        e.PreviewText = CalculateMyPreviewText(e.RowHandle)
    End Sub

    Private Function CalculateMyPreviewText(rowHandle As Integer) As String
        On Error Resume Next
        Dim row As DataRow = GVIssues.GetDataRow(rowHandle)
        'Dim mpgcity As String = row("MPG City").ToString()
        'Dim mpghwy As String = row("MPG Highway").ToString()
        Dim description As String = row("Description").ToString()
        Return If(String.IsNullOrEmpty(description), String.Empty, String.Format(StripTags(description)))

    End Function

    Function StripTags(ByVal html As String) As String
        On Error Resume Next
        'Return Regex.Replace(html, "<(.|\n)*?>", String.Empty)
        Return Regex.Replace(Regex.Replace(Regex.Replace(Replace(html, "&nbsp;", String.Empty), "<(.|\n)*?>", String.Empty), "(\r?\n){2,}", vbCrLf), "^[\s]+|[\s]+$", String.Empty, RegexOptions.Multiline)
    End Function

    Private Sub RepositoryItemRichTextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemRichTextEdit1.EditValueChanged
        'Me.RepositoryItemRichTextEdit1.DocumentFormat
        'Me.RepositoryItemRichTextEdit1.ConvertEditValueToPlainText(Me.RepositoryItemRichTextEdit1.ToString)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim oFrm As New RadForm1
        oFrm.Show()
    End Sub

    Private Sub BarToggleSwitchPreview_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarToggleSwitchPreview.CheckedChanged
        If Me.BarToggleSwitchPreview.Checked = False Then
            If navigationFrame.SelectedPage Is Me.DefectsNavigationPage Then
                Me.GridView9.OptionsView.ShowPreview = False
            ElseIf navigationFrame.SelectedPage Is Me.RequestsNavigationPage Then
                Me.GVIssues.OptionsView.ShowPreview = False
            End If
        Else
            If navigationFrame.SelectedPage Is Me.DefectsNavigationPage Then
                Me.GridView9.OptionsView.ShowPreview = True
            ElseIf navigationFrame.SelectedPage Is Me.RequestsNavigationPage Then
                Me.GVIssues.OptionsView.ShowPreview = True
            End If
        End If
    End Sub

    Private Sub RepoButtonHours_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepoButtonHours.ButtonClick
        'Dim view As GridView = CType(GCtrlRequests.FocusedView, GridView)
        'Dim rowHandle As Integer = view.FocusedRowHandle

        '' Get values from the row if needed
        'Dim value1 As Object = view.GetRowCellDisplayText(rowHandle, "ID")
        'Dim value2 As Object = view.GetRowCellDisplayText(rowHandle, "Channel")
        ''view.g

        '' Perform your action here
        'MessageBox.Show("Button clicked in row: " & rowHandle.ToString())
        'MessageBox.Show(value1 & ": " & value2)
    End Sub

    Private Sub RepoButtonHours_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles RepoButtonHours.ButtonPressed
        'Dim view As GridView = CType(GCtrlRequests.FocusedView, GridView)
        'Dim rowHandle As Integer = view.FocusedRowHandle

        '' Get values from the row if needed
        'Dim value1 As Object = view.GetRowCellDisplayText(rowHandle, "ID")
        'Dim value2 As Object = view.GetRowCellDisplayText(rowHandle, "Channel")

        '' Perform your action here
        'MessageBox.Show("Button clicked in row: " & rowHandle.ToString())
        'MessageBox.Show(value1 & ": " & value2)

        'RemoveHandler RepoButtonHours.ButtonPressed, AddressOf RepoButtonHours_ButtonPressed
    End Sub

    Private Sub RepoButtonHours_Click(sender As Object, e As EventArgs) Handles RepoButtonHours.Click
        Dim view As GridView = CType(GCtrlRequests.FocusedView, GridView)
        Dim rowHandle As Integer = view.FocusedRowHandle

        '' Get values from the row if needed
        Dim value1 As Object = view.GetRowCellValue(rowHandle, "ID")
        Dim value2 As Object = view.GetRowCellValue(rowHandle, "Channel")

        '' Perform your action here
        MessageBox.Show("Button clicked in row: " & rowHandle.ToString())
        MessageBox.Show(value1 & ": " & value2)
    End Sub

    Private Sub GridView1_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GVIssues.CustomRowCellEdit
        'If e.Column.Caption = "Hours" Then
        '    Dim buttonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit = CType(e.RepositoryItem, DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit)
        '    AddHandler buttonEdit.ButtonPressed, AddressOf RepoButtonHours_ButtonPressed
        'End If
    End Sub

#Region "Data Updates"

    Private Sub GVIssues_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GVIssues.RowUpdated
        'Dim view As ColumnView = TryCast(GCtrlRequests.FocusedView, ColumnView)

        'view.CloseEditor()
        'If view.UpdateCurrentRow() Then
        Try
            IssuesTableAdapter1.Update(Me.ProdSupport_DataSet1.Issues)
        Catch Ex As Exception
            MsgBox("Update failed!" & vbNewLine & vbNewLine & Ex.Message, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
        MsgBox("Successfully updated the record!", MsgBoxStyle.Information, "Success")
        'End If
    End Sub


    Private Sub GVIssues_HiddenEditor(sender As Object, e As EventArgs) Handles GVIssues.HiddenEditor

    End Sub

    Private Sub GVIssues_DataSourceChanged(sender As Object, e As EventArgs) Handles GVIssues.DataSourceChanged

    End Sub

    Private NewCommentIssueID As Integer = Nothing

    Private Sub GVIssues_EditFormHidden(sender As Object, e As EditFormHiddenEventArgs) Handles GVIssues.EditFormHidden
        'If e.Result = EditFormResult.Update Then
        '    If e.BindableControls(colAudit).Text <> e.BindableControls(colAudit).Tag Then
        '        Dim NewAudit As DataRow = Me.ProdSupport_DataSet1.Audit.NewRow()
        '        NewAudit("IssueID") = CInt(GVIssues.GetDataRow(e.RowHandle)("ID").ToString())
        '        NewAudit("DateCreated") = Now()
        '        NewAudit("Username") = UCase(Environment.UserName)
        '        NewAudit("Comment") = e.BindableControls(colAudit).Text
        '        Me.ProdSupport_DataSet1.Audit.Rows.Add(NewAudit)
        '        GVIssues.GetDataRow(e.RowHandle)("ID").ToString()
        '        AuditTableAdapter1.Adapter.Update(Me.ProdSupport_DataSet1.Audit)
        '    End If
        'End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim conn As New OleDbConnection(My.Settings.DB_Connection)
        Dim cmd As New OleDbCommand("INSERT INTO Audit (IssueID, DateAdded, Username, Comment) VALUES (" & NewCommentIssueID & ", #" & Now() & "#, '" + UCase(Environment.UserName) & "', '" & Me.TextEdit2.Text & "')", conn)
        'cmd.Parameters.AddWithValue("@username", UCase(Environment.UserName))

        Using conn
            conn.Open()
            If CInt(cmd.ExecuteNonQuery) > 0 Then
                MsgBox("Comment saved!", "Success!")
                Me.AuditTableAdapter1.Fill(Me.ProdSupport_DataSet1.Audit)
            Else
                MsgBox("Comment failed to save!", "Error!")
            End If
        End Using
        conn.Close()

        'Dim SQLAddAudit As New OleDbCommand("INSERT INTO Audit (IssueID, DateAdded, Username, Comment) VALUES (" + Me.TxtID.Text + ", #" + Now() + "#, '" + UCase(Environment.UserName) + "', '" + comment + "')", Me.AuditTableAdapter.Connection)
        ''Me.AuditTableAdapter.Connection.Open()

        ''If CInt(SQLAddAudit.ExecuteNonQuery) > 0 Then
        ''    RadCallout.Show(callout, Me.BtnAddComment, $"The comment has been saved!", "Success")
        ''    Me.AuditTableAdapter.Fill(Me.ProdSupport_DataSet.Audit)
        ''Else
        ''    RadCallout.Show(callout, Me.BtnAddComment, $"There was a problem! Try again!", "Failed")
        ''End If
        ''Me.AuditTableAdapter.Connection.Close()
        'Dim NewAudit As DataRow = Me.ProdSupport_DataSet1.Audit.NewRow()
        'NewAudit("IssueID") = NewCommentIssueID 'CInt(GVIssues.GetDataRow(e.RowHandle)("ID").ToString())
        'NewAudit("DateAdded") = Now()
        'NewAudit("Username") = UCase(Environment.UserName)
        'NewAudit("Comment") = Me.TextEdit2.Text
        'Me.ProdSupport_DataSet1.Audit.Rows.Add(NewAudit)
        ''AuditTableAdapter1.Adapter.
        'AuditTableAdapter1.Adapter.Update(Me.ProdSupport_DataSet1.Audit)
    End Sub

#End Region

#Region "Navigation"

    Private Sub navBarControl_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles navBarControl.ActiveGroupChanged
        Select Case e.Group.Name
            Case "RequestsNavBarGroup"
                navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group)
                Me.BarToggleSwitchPreview.Checked = Me.GVIssues.OptionsView.ShowPreview = True
            Case "DefectsNavBarGroup"
                navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group)
                Me.BarToggleSwitchPreview.Checked = Me.GridView9.OptionsView.ShowPreview = True
            Case Else
        End Select
        'navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group)
    End Sub

    Private Sub navigationFrame_SelectedPageChanging(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs) Handles navigationFrame.SelectedPageChanging
        'MsgBox(e.OldPage.Caption)
    End Sub

    Private Sub svgFLEXSBack_Click(sender As Object, e As EventArgs) Handles svgFLEXSBack.Click
        Me.navigationFrame.SelectPrevPage()
        Me.NavBarJIRASync.Enabled = True
    End Sub

    Private Sub barButtonNavigation_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles requestsBarButtonItem.ItemClick, DefectsBarButtonItem.ItemClick
        navBarControl.ActiveGroup = If(e.Item.Caption = "Requests", RequestsNavBarGroup, DefectsNavBarGroup)
    End Sub

    Private Sub NavBarJIRASync_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarJIRASync.LinkClicked
        navigationFrame.SelectedPage = Me.JIRASyncNavigationPage 'navigationFrame.Pages(2)
        Me.NavBarJIRASync.Enabled = False
    End Sub

    Private Sub navBarControl_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarControl.LinkClicked
        If e.Link.Caption = "JIRA Sync" And Me.navigationFrame.SelectedPage IsNot Me.JIRASyncNavigationPage Then
            Me.NavBarJIRASync.Enabled = False
            navigationFrame.SelectedPage = Me.JIRASyncNavigationPage
        ElseIf e.Link.Caption IsNot "JIRA Sync" And Me.navigationFrame.SelectedPage Is Me.JIRASyncNavigationPage Then
            Me.NavBarJIRASync.Enabled = True
            If e.Link.Group.Name = "DefectsNavBarGroup" And Me.navigationFrame.SelectedPage IsNot Me.DefectsNavigationPage Then
                navigationFrame.SelectedPage = Me.DefectsNavigationPage
            ElseIf e.Link.Group.Name = "RequestsNavBarGroup" And Me.navigationFrame.SelectedPage IsNot Me.RequestsNavigationPage Then
                navigationFrame.SelectedPage = Me.RequestsNavigationPage
            End If
        End If
        LoadDataAsync_NavBar(e.Link.Caption)
    End Sub

#End Region

#Region "Data Loading"

    Private Sub LoadDataAsync()

        Telerik.WinControls.UI.RadOverlayManager.Show(GCtrlRequests)

        ' Start a new thread to load the data asynchronously
        Dim loadThread As New Thread(Sub()

                                         'FillData("FillPriorities")
                                         'FillData("FillStatuses")
                                         'FillData("FillCategories")
                                         FillData("FillContacts_Extended")
                                         FillData("FillAnalysts")
                                         FillData("FillClients")
                                         FillData("FillChannels")
                                         'FillData("FillIssues")
                                         FillData("FillHours")
                                         FillData("FillAudit")

                                         Me.Invoke(New Action(Sub()
                                                                  ' Enable UI controls
                                                                  'Me.Enabled = True
                                                                  Telerik.WinControls.UI.RadOverlayManager.Close()
                                                                  'SplashScreenManager1.CloseWaitForm()
                                                                  Dim conn As New OleDbConnection(My.Settings.DB_Connection)
                                                                  Dim cmd As New OleDbCommand("SELECT ID, [Contact Name] FROM [Contacts Extended] WHERE TELUS_ID = @username", conn)
                                                                  cmd.Parameters.AddWithValue("@username", UCase(Environment.UserName))

                                                                  Using conn
                                                                      conn.Open()
                                                                      'Me.Tag = cmd.ExecuteScalar.ToString
                                                                      Dim reader As OleDbDataReader = cmd.ExecuteReader()
                                                                      If reader.Read() Then
                                                                          CurrentUserID = CInt(reader("ID").ToString())
                                                                          Me.Tag = reader("Contact Name").ToString()
                                                                      End If
                                                                  End Using
                                                                  conn.Close()
                                                              End Sub))
                                     End Sub)

        ' Start the thread
        loadThread.Start()
    End Sub

    Private Sub FillData(ByVal fillMethod As String)
        ' Call the appropriate Fill method on the appropriate TableAdapter
        Try
            Select Case fillMethod
                'Case "FillPriorities"
                '    Me.PrioritiesTableAdapter.Fill(Me.ProdSupport_DataSet.Priorities)
                'Case "FillStatuses"
                '    Me.StatusesTableAdapter.Fill(Me.ProdSupport_DataSet.Statuses)
                'Case "FillCategories"
                '    Me.CategoriesTableAdapter.Fill(Me.ProdSupport_DataSet.Categories)
                Case "FillContacts_Extended"
                    Me.Contacts_ExtendedTableAdapter.Fill(Me.ProdSupport_DataSet1.Contacts_Extended)
                Case "FillAnalysts"
                    Me.AnalystsTableAdapter.Fill(Me.ProdSupport_DataSet1.Analysts)
                Case "FillClients"
                    Me.ClientsTableAdapter.Fill(Me.ProdSupport_DataSet1.Clients)
                Case "FillChannels"
                    Me.ChannelsTableAdapter.Fill(Me.ProdSupport_DataSet1.Channels)
                Case "FillHours"
                    Me.Tbl_HoursWorkedLogTableAdapter1.Fill(Me.ProdSupport_DataSet1.tbl_HoursWorkedLog)
                Case "FillAudit"
                    Me.AuditTableAdapter1.Fill(Me.ProdSupport_DataSet1.Audit)
                    'Case "FillIssues"
                    '    Me.IssuesTableAdapter1.FillByActive(Me.ProdSupport_DataSet.Issues)
            End Select
        Catch ex As Exception
            ' Log the exception details
            MessageBox.Show("An error occurred while filling the " & fillMethod & " data: " & ex.Message)
        End Try
    End Sub

    Private Sub FillData_NavBar(ByVal fillMethod As String)
        ' Call the appropriate Fill method on the appropriate TableAdapter
        Try
            Select Case fillMethod
                Case Me.NavBarResolved.Caption 'Resolved
                    IssuesTableAdapter1.FillByAll(ProdSupport_DataSet1.Issues)
                    issuesBindingSource.Filter = "Status NOT IN ('Escalated - Production Script', 'Escalated to IT', 'Escalated to Product', 'Future Work', 'In Progress', 'Not Started', 'On Hold (Client)', 'Projects', 'Recurring Task','AODA - Confirmed Defect','AODA - Enhancement','Confirmed Defect','Enhancement - Escalated to Product','AODA - Confirmed Defect Fixed','AODA - Enhancement Released','Confirmed Defect - Fixed','Enhancement - Released')"
                Case Me.NavBarAllRequests.Caption 'All Requests
                    IssuesTableAdapter1.FillByAll(ProdSupport_DataSet1.Issues)
                    issuesBindingSource.RemoveFilter()
                Case Me.NavBarAssignedMe.Caption 'Assigned To Me
                    IssuesTableAdapter1.FillByAnalyst(ProdSupport_DataSet1.Issues, CurrentUserID)
                    issuesBindingSource.Filter = "Status IN ('Escalated - Production Script', 'Escalated to IT', 'Escalated to Product', 'Future Work', 'In Progress', 'Not Started', 'On Hold (Client)', 'Projects', 'Recurring Task') AND [Assigned To] = " & CurrentUserID
                Case Me.NavBarUnresolved.Caption 'Unresolved
                    IssuesTableAdapter1.FillByActive(ProdSupport_DataSet1.Issues)
                    issuesBindingSource.Filter = "Status IN ('Escalated - Production Script', 'Escalated to IT', 'Escalated to Product', 'Future Work', 'In Progress', 'Not Started', 'On Hold (Client)', 'Projects', 'Recurring Task')"
                Case Me.NavBarDefects.Caption 'Open Defects
                    FLEXSMgmtTableAdapter.FillActiveDefects(ProdSupport_DataSet1.FLEXSMgmt)
                    FLEXSMgmtBindingSource.Filter = "Status IN ('AODA - Confirmed Defect','Confirmed Defect')"
                Case Me.NavBarEnh.Caption 'Open Enhancements
                    FLEXSMgmtTableAdapter.FillActiveEnhancements(ProdSupport_DataSet1.FLEXSMgmt)
                    FLEXSMgmtBindingSource.Filter = "Status IN ('AODA - Enhancement','Enhancement - Escalated to Product')"
                Case Me.NavBarFLEXSDone.Caption 'Closed FLEXS
                    FLEXSMgmtTableAdapter.Fill(ProdSupport_DataSet1.FLEXSMgmt)
                    FLEXSMgmtBindingSource.Filter = "Status IN ('AODA - Confirmed Defect Fixed','AODA - Enhancement Released','Confirmed Defect - Fixed','Enhancement - Released')"
                Case Me.NavBarFLEXS.Caption 'Active FLEXS
                    FLEXSMgmtTableAdapter.FillActiveFLEXS(ProdSupport_DataSet1.FLEXSMgmt)
                    FLEXSMgmtBindingSource.Filter = "Status IN ('AODA - Confirmed Defect','AODA - Enhancement','Confirmed Defect','Enhancement - Escalated to Product')"

            End Select
        Catch ex As Exception
            ' Log the exception details
            MessageBox.Show("An error occurred while filling the " & fillMethod & " data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadDataAsync_NavBar(ByVal FillWhat As String)

        Telerik.WinControls.UI.RadOverlayManager.Show(GCtrlRequests)

        ' Start a new thread to load the data asynchronously
        Dim loadThread As New Thread(Sub()
                                         'FillData_NavBar(FillWhat)

                                         Me.Invoke(New Action(Sub()
                                                                  FillData_NavBar(FillWhat)
                                                                  ' Enable UI controls
                                                                  'Me.Enabled = True
                                                                  Telerik.WinControls.UI.RadOverlayManager.Close()
                                                                  'SplashScreenManager1.CloseWaitForm()

                                                              End Sub))
                                     End Sub)

        ' Start the thread
        loadThread.Start()
    End Sub

#End Region

#Region "JIRA Code"

    Private JIRAdataTable As New DataTable()

    Private Sub Initialize_DGView()
        If GCtrlJIRASearch.DataSource Is Nothing Then
            Telerik.WinControls.UI.RadOverlayManager.Show(Me.GCtrlJIRASearch)

            With Me.GVJIRASearch
                .OptionsView.ColumnAutoWidth = False

                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "Key",
                    .Caption = "Key"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "Summary",
                    .Caption = "Summary"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "Status",
                    .Caption = "Status"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "Assignee",
                    .Caption = "Assignee"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "Reporter",
                    .Caption = "Reporter"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "Created",
                    .Caption = "Created"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "Updated",
                    .Caption = "Updated"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "Labels",
                    .Caption = "Labels"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "Carriers",
                    .Caption = "Carriers"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "FLEXSClients",
                    .Caption = "Clients"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "EpicName",
                    .Caption = "Epic Name"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "EpicLink",
                    .Caption = "Epic Link"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "ReleaseDate",
                    .Caption = "Release Date"
                })
                .Columns.Add(New DevExpress.XtraGrid.Columns.GridColumn() With {
                    .FieldName = "ReleaseName",
                    .Caption = "Release"
                })
                .BestFitColumns()
            End With
        Else
            Telerik.WinControls.UI.RadOverlayManager.Show(Me.GCtrlJIRASearch)
            GCtrlJIRASearch.DataSource = Nothing
        End If

        JIRAdataTable = New DataTable

        With JIRAdataTable.Columns
            .Add("Key", GetType(String))
            .Add("Summary", GetType(String))
            .Add("Status", GetType(String))
            .Add("Assignee", GetType(String))
            .Add("Reporter", GetType(String))
            .Add("Created", GetType(DateTime))
            .Add("Updated", GetType(DateTime))
            .Add("Labels", GetType(String))
            .Add("Carriers", GetType(String))
            .Add("FLEXSClients", GetType(String))
            .Add("EpicName", GetType(String))
            .Add("EpicLink", GetType(String))
            .Add("ReleaseDate", GetType(String))
            .Add("ReleaseName", GetType(String))
        End With

        GCtrlJIRASearch.DataSource = JIRAdataTable
        'GridControl3.MainView. = JIRAdataTable

    End Sub

    Private Sub TxtJQLString_EditValueChanged(sender As Object, e As EventArgs) Handles TxtJQLString.EditValueChanged
        Me.GVJIRASearch.Columns.Clear()

    End Sub

    Private Sub btnSearchFLEXS_Click(sender As Object, e As EventArgs) Handles btnSearchFLEXS.Click
        Initialize_DGView()
        ' Construct the Jira search URL
        Dim url As String = "https://jira.tools.telushealth.com/rest/api/2/search?jql=" + TxtJQLString.Text + "&maxResults=50" '+ SpinMaxRes.Value.ToString

        Try
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
                Catch
                End Try

                Dim ReleaseName As String = ""
                Try
                    ReleaseName = issue("fields")("fixVersions").Item(0)("name").ToString()
                Catch
                End Try
                JIRAdataTable.Rows.Add(key, summary, Status, Assignee, Reporter, Created, Updated, Labels, Carriers, FLEXSClients, EpicName, EpicLink, ReleaseDate, ReleaseName)

            Next

            Me.GCtrlJIRASearch.RefreshDataSource()
            Me.GVJIRASearch.RefreshData()

            For Each gridColumn As DevExpress.XtraGrid.Columns.GridColumn In GVJIRASearch.Columns
                gridColumn.Visible = True
            Next
            GVJIRASearch.BestFitColumns()



        Catch Ex As Exception
            Select Case Ex.Message
                Case "The remote server returned an error: (400) Bad Request."
                    MsgBox("The request is invalid!", vbExclamation, "Invalid Request")
                Case Else
                    MsgBox(Ex.Message)
            End Select

        End Try
        Telerik.WinControls.UI.RadOverlayManager.Close()
    End Sub

    Private Sub btnJQLSnippets_ListItemClick(sender As Object, e As DevExpress.XtraBars.ListItemClickEventArgs) Handles btnJQLSnippets.ListItemClick
        Dim coucou As DevExpress.XtraBars.BarListItem = e.Item ')(DevExpress.XtraBars.BarListItem = e.Item)
        Me.TxtJQLString.Text = coucou.Strings(e.Index)
        'MsgBox(coucou.Strings(e.Index))
        'Dim cheee As String = coucou.Strings(e.Index)
        'Dim aaa As String = ((e.Item As DevExpress.XtraBars.BarListItem).Strings(e.index))
    End Sub

    Private Sub TxtJQLString_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TxtJQLString.ButtonClick
        'Me.TxtJQLString.SelectAll()
        Me.TxtJQLString.Text = String.Empty
        Me.TxtJQLString.Focus()
    End Sub

#End Region

#Region "JIRA Information on a ticket"
    Private Sub MemoEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles MemoEdit1.EditValueChanged


    End Sub

    Private Sub MemoEdit1_Click(sender As Object, e As EventArgs) Handles MemoEdit1.Click
        Dim ticketKey As String = "FLEX-2798"
        ' Fetch the ticket details, including comments and activity history
        Dim detailsRequest As HttpWebRequest = DirectCast(WebRequest.Create("https://jira.tools.telushealth.com/rest/api/2/issue/" & ticketKey & "?expand=changelog"), HttpWebRequest)
        detailsRequest.Headers.Add("Authorization", "Bearer ODAwNDc5MDE5OTk4Op6GvljcN/HFEyy5z1uJQyoV8F6m") ' Replace YOUR_API_TOKEN with your JIRA API token
        detailsRequest.ContentType = "application/json"
        detailsRequest.Method = "GET"

        Dim detailsResponse As WebResponse = detailsRequest.GetResponse()
        Dim detailsReader As StreamReader = New StreamReader(detailsResponse.GetResponseStream())
        Dim detailsResponseString As String = detailsReader.ReadToEnd()

        ' Parse the JSON response to get the comments and activity history
        Dim details As JObject = JObject.Parse(detailsResponseString)
        Dim comments As JArray = details.SelectToken("fields.comment.comments")
        Dim activityHistory As JArray = details.SelectToken("changelog.histories")

        ' Populate the commentsTextBox
        Dim commentsText As New StringBuilder()
        For Each comment As JObject In comments
            Dim author As String = comment.SelectToken("author.displayName").ToString()
            Dim created As String = comment.SelectToken("created").ToString()
            Dim body As String = comment.SelectToken("body").ToString()

            ' Replace tagged usernames with display names
            Dim regex As New Regex("\[~(\w+)\]")
            Dim matches As MatchCollection = regex.Matches(body)

            For Each match As Match In matches
                Dim taggedUsername As String = match.Groups(1).Value
                Dim taggedDisplayName As String = GetDisplayNameFromUsername(taggedUsername, "ODAwNDc5MDE5OTk4Op6GvljcN/HFEyy5z1uJQyoV8F6m") ' Replace MY_API_TOKEN with your JIRA API token
                body = body.Replace(taggedUsername, taggedDisplayName)
            Next

            commentsText.AppendLine($"Author: {author}")
            commentsText.AppendLine($"Created: {created}")
            commentsText.AppendLine($"Comment: {body}")
            commentsText.AppendLine(New String("-"c, 40))
        Next
        Me.MemoEdit1.Text = commentsText.ToString()

        ' Populate the activityHistoryTextBox
        Dim activityText As New StringBuilder()
        For Each activity As JObject In activityHistory
            Dim user As String = activity.SelectToken("author.displayName").ToString()
            Dim created As String = activity.SelectToken("created").ToString()
            Dim items As JArray = activity.SelectToken("items")

            activityText.AppendLine($"User: {user}")
            activityText.AppendLine($"Created: {created}")

            For Each item As JObject In items
                Dim field As String = item.SelectToken("field").ToString()
                Dim fromString As String = item.SelectToken("fromString").ToString()
                Dim toString As String = item.SelectToken("toString").ToString()

                activityText.AppendLine($"Field: {field}")
                activityText.AppendLine($"From: {fromString}")
                activityText.AppendLine($"To: {toString}")
            Next

            activityText.AppendLine(New String("-"c, 40))
        Next
        Me.MemoEdit2.Text = activityText.ToString()
    End Sub

    Private Function GetDisplayNameFromUsername(ByVal username As String, ByVal apiToken As String) As String
        Dim userRequest As HttpWebRequest = DirectCast(WebRequest.Create("https://jira.tools.telushealth.com/rest/api/2/user?username=" & username), HttpWebRequest)
        userRequest.Headers.Add("Authorization", "Bearer " & apiToken) ' Use the provided API token
        userRequest.ContentType = "application/json"
        userRequest.Method = "GET"

        Dim userResponse As WebResponse = userRequest.GetResponse()
        Dim userReader As StreamReader = New StreamReader(userResponse.GetResponseStream())
        Dim userResponseString As String = userReader.ReadToEnd()

        Dim userDetails As JObject = JObject.Parse(userResponseString)
        Return userDetails.SelectToken("displayName").ToString()
    End Function



#End Region

End Class

