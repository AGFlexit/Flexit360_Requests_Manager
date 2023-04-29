﻿Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Text.RegularExpressions
Imports DevExpress.XtraGrid.Views.Base
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports System.Text

Partial Public Class MenuV2
    Private CurrentUserID As Integer

    Public Sub New()
        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
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

    End Sub
    Private Sub navBarControl_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles navBarControl.ActiveGroupChanged
        Select Case e.Group.Name
            Case "RequestsNavBarGroup"
                'Me.GridControl2.SuspendLayout()
                Me.GridControl1.Visible = True
                'Me.GridControl1.Dispose()
                Me.issuesBindingSource.Filter = "ID IS NULL"
                'Me.GridControl1.ResumeLayout()
                'Me.GridControl1.Invalidate()
                navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group)

                Me.GridControl2.Visible = False
            Case "DefectsNavBarGroup"
                'Me.GridControl1.SuspendLayout()
                Me.GridControl2.Visible = True
                Me.issuesBindingSource.Filter = "ID IS NULL"
                'Me.GridControl2.Dispose()
                'Me.GridControl2.ResumeLayout()
                'Me.GridControl2.Invalidate()
                navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group)
                Me.GridControl1.Visible = False
            Case Else
        End Select
        'navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group)
    End Sub
    Private Sub barButtonNavigation_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles requestsBarButtonItem.ItemClick, customersBarButtonItem.ItemClick
        navBarControl.ActiveGroup = If(e.Item.Caption = "Requests", RequestsNavBarGroup, DefectsNavBarGroup)
    End Sub

    Private Sub MenuV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProdSupport_DataSet1.Channels' table. You can move, or remove it, as needed.
        Me.ChannelsTableAdapter.Fill(Me.ProdSupport_DataSet1.Channels)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet1.Analysts' table. You can move, or remove it, as needed.
        Me.AnalystsTableAdapter.Fill(Me.ProdSupport_DataSet1.Analysts)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet1.Contacts_Extended' table. You can move, or remove it, as needed.
        Me.Contacts_ExtendedTableAdapter.Fill(Me.ProdSupport_DataSet1.Contacts_Extended)
        'TODO: This line of code loads data into the 'ProdSupport_DataSet1.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.ProdSupport_DataSet1.Clients)
        Me.AuditTableAdapter1.Fill(Me.ProdSupport_DataSet1.Audit)
        Me.Tbl_HoursWorkedLogTableAdapter1.Fill(Me.ProdSupport_DataSet1.tbl_HoursWorkedLog)

    End Sub

    Private Sub NavBarUnresolved_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarUnresolved.LinkClicked
        'Me.GridControl1.BeginInit()
        'Me.GridControl1.EndInit()
        'Me.GridControl1.BeginUpdate()
        'Me.GridControl1.PerformLayout()
        IssuesTableAdapter1.FillByActive(ProdSupport_DataSet1.Issues)
        issuesBindingSource.Filter = "Status IN ('Escalated - Production Script', 'Escalated to IT', 'Escalated to Product', 'Future Work', 'In Progress', 'Not Started', 'On Hold (Client)', 'Projects', 'Recurring Task')"
        'Me.GridControl1.EndUpdate()
        'Me.GridControl1.EndInit()
        ''TODO: This line of code loads data into the 'ProdSupport_DataSet1.Channels' table. You can move, or remove it, as needed.
        'Me.ChannelsTableAdapter.Fill(Me.ProdSupport_DataSet1.Channels)
        ''TODO: This line of code loads data into the 'ProdSupport_DataSet1.Analysts' table. You can move, or remove it, as needed.
        'Me.AnalystsTableAdapter.Fill(Me.ProdSupport_DataSet1.Analysts)
        ''TODO: This line of code loads data into the 'ProdSupport_DataSet1.Contacts_Extended' table. You can move, or remove it, as needed.
        'Me.Contacts_ExtendedTableAdapter.Fill(Me.ProdSupport_DataSet1.Contacts_Extended)
        ''TODO: This line of code loads data into the 'ProdSupport_DataSet1.Clients' table. You can move, or remove it, as needed.
        'Me.ClientsTableAdapter.Fill(Me.ProdSupport_DataSet1.Clients)
        'Me.AuditTableAdapter1.Fill(Me.ProdSupport_DataSet1.Audit)
        'Me.Tbl_HoursWorkedLogTableAdapter1.Fill(Me.ProdSupport_DataSet1.tbl_HoursWorkedLog)
    End Sub

    Private Sub NavBarAssignedMe_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarAssignedMe.LinkClicked
        IssuesTableAdapter1.FillByAnalyst(ProdSupport_DataSet1.Issues, CurrentUserID)
        issuesBindingSource.Filter = "Status IN ('Escalated - Production Script', 'Escalated to IT', 'Escalated to Product', 'Future Work', 'In Progress', 'Not Started', 'On Hold (Client)', 'Projects', 'Recurring Task') AND [Assigned To] = " & CurrentUserID
        ''TODO: This line of code loads data into the 'ProdSupport_DataSet1.Channels' table. You can move, or remove it, as needed.
        'Me.ChannelsTableAdapter.Fill(Me.ProdSupport_DataSet1.Channels)
        ''TODO: This line of code loads data into the 'ProdSupport_DataSet1.Analysts' table. You can move, or remove it, as needed.
        'Me.AnalystsTableAdapter.Fill(Me.ProdSupport_DataSet1.Analysts)
        ''TODO: This line of code loads data into the 'ProdSupport_DataSet1.Contacts_Extended' table. You can move, or remove it, as needed.
        'Me.Contacts_ExtendedTableAdapter.Fill(Me.ProdSupport_DataSet1.Contacts_Extended)
        ''TODO: This line of code loads data into the 'ProdSupport_DataSet1.Clients' table. You can move, or remove it, as needed.
        'Me.ClientsTableAdapter.Fill(Me.ProdSupport_DataSet1.Clients)
        'Me.AuditTableAdapter1.Fill(Me.ProdSupport_DataSet1.Audit)
        'Me.Tbl_HoursWorkedLogTableAdapter1.Fill(Me.ProdSupport_DataSet1.tbl_HoursWorkedLog)
    End Sub

    Private Sub NavBarResolved_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarResolved.LinkClicked
        IssuesTableAdapter1.FillByAll(ProdSupport_DataSet1.Issues)
        issuesBindingSource.Filter = "Status NOT IN ('Escalated - Production Script', 'Escalated to IT', 'Escalated to Product', 'Future Work', 'In Progress', 'Not Started', 'On Hold (Client)', 'Projects', 'Recurring Task','AODA - Confirmed Defect','AODA - Enhancement','Confirmed Defect','Enhancement - Escalated to Product','AODA - Confirmed Defect Fixed','AODA - Enhancement Released','Confirmed Defect - Fixed','Enhancement - Released')"
    End Sub

    Private Sub NavBarFLEXS_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarFLEXS.LinkClicked
        IssuesTableAdapter1.FillByActiveDefEnh(ProdSupport_DataSet1.Issues)
        issuesBindingSource.Filter = "Status IN ('AODA - Confirmed Defect','AODA - Enhancement','Confirmed Defect','Enhancement - Escalated to Product')"
    End Sub

    Private Sub NavBarDefects_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarDefects.LinkClicked
        IssuesTableAdapter1.FillByActiveDefects(ProdSupport_DataSet1.Issues)
        issuesBindingSource.Filter = "Status IN ('AODA - Confirmed Defect','Confirmed Defect')"
    End Sub

    Private Sub NavBarEnh_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEnh.LinkClicked
        IssuesTableAdapter1.FillByActiveEnh(ProdSupport_DataSet1.Issues)
        issuesBindingSource.Filter = "Status IN ('AODA - Enhancement','Enhancement - Escalated to Product')"
    End Sub

    Private Sub NavBarAllRequests_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarAllRequests.LinkClicked
        IssuesTableAdapter1.FillByAll(ProdSupport_DataSet1.Issues)
        issuesBindingSource.RemoveFilter()
    End Sub

    Private Sub NavBarFLEXSDone_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarFLEXSDone.LinkClicked
        issuesBindingSource.Filter = "Status IN ('AODA - Confirmed Defect Fixed','AODA - Enhancement Released','Confirmed Defect - Fixed','Enhancement - Released')"
    End Sub

    Private Sub GridView1_CalcPreviewText(sender As Object, e As CalcPreviewTextEventArgs) Handles GridView1.CalcPreviewText
        e.PreviewText = CalculateMyPreviewText(e.RowHandle)
    End Sub

    Private Function CalculateMyPreviewText(rowHandle As Integer) As String
        On Error Resume Next
        Dim row As DataRow = GridView1.GetDataRow(rowHandle)
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

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Dim view As ColumnView = TryCast(GridControl1.FocusedView, ColumnView)
        view.CloseEditor()
        If view.UpdateCurrentRow() Then
            Try
                IssuesTableAdapter1.Update(Me.ProdSupport_DataSet1.Issues)
            Catch Ex As Exception
                MsgBox("Update failed!" & vbNewLine & vbNewLine & Ex.Message, MsgBoxStyle.Critical, "Error")
                Exit Sub
            End Try
            MsgBox("Successfully updated the record!", MsgBoxStyle.Information, "Success")
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

    End Sub

    Private Sub RepositoryItemRichTextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemRichTextEdit1.EditValueChanged
        'Me.RepositoryItemRichTextEdit1.DocumentFormat
        Me.RepositoryItemRichTextEdit1.ConvertEditValueToPlainText(Me.RepositoryItemRichTextEdit1.ToString)
    End Sub

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

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim oFrm As New RadForm1
        oFrm.Show()
    End Sub
End Class