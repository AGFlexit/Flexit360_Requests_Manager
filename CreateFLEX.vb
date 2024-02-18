Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Helpers
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.Text
Imports DevExpress.XtraBars.Docking2010

Partial Public Class CreateFLEX

    Public Sub New()
        InitializeComponent()

        'dataLayoutControl1.DataSource = GetDataSource()
        'dataLayoutControl1.RetrieveFields()

        'Dim flatList As List(Of BaseLayoutItem) = (New FlatItemsList()).GetItemsList(dataLayoutControl1.Root)
        'Dim aboutItem As BaseLayoutItem = flatList.First(Function(e) e.Text = "About")
        'aboutItem.TextLocation = DevExpress.Utils.Locations.Top
    End Sub

    Private Sub CreateFLEX_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim baseURL As String = "https://jira.tools.telushealth.com"
        Dim token As String = "ODAwNDc5MDE5OTk4Op6GvljcN/HFEyy5z1uJQyoV8F6m"

        'TODO: This line of code loads data into the 'ProdSupport_DataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.ProdSupport_DataSet.Clients)
        'Me.ComboBoxEdit1.DataBindings.
        TxtClientID.EditValue = MenuV2.GVIssues.GetFocusedRowCellValue("Client")
        CboClientName.EditValue = MenuV2.GVIssues.GetFocusedRowCellDisplayText("Client")
        TxtSummary.EditValue = CboClientName.Text & " - Refresh UAT"
    End Sub

    Private Sub Chk2FA_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2FA.CheckedChanged
        If Chk2FA.Checked Then
            TxtDescription.EditValue = TxtDescription.EditValue & vbCrLf & "Client uses 2FA, please do not change admin email addresses!"
        Else
            TxtDescription.EditValue = TxtDescription.EditValue.ToString.Replace(vbCrLf & "Client uses 2FA, please do not change admin email addresses!", "")
        End If
    End Sub

    Private Sub windowsUIButtonPanelMain_ButtonClick(sender As Object, e As ButtonEventArgs) Handles windowsUIButtonPanelMain.ButtonClick
        If e.Button.Properties.Caption = "Create JIRA" Then
            CreateJIRA()
        ElseIf e.Button.Properties.Caption = "Cancel" Then
            Me.Close()
        End If
    End Sub

    Sub CreateJIRA()

        If TxtJIRAToken.Text = "" Then Exit Sub

        Dim JIRAToken As String
        Dim payload As JObject = New JObject(
    New JProperty("fields",
        New JObject(
            New JProperty("project",
                New JObject(
                    New JProperty("key", "FLEX")
                )
            ),
            New JProperty("summary", TxtSummary.EditValue),
            New JProperty("description", TxtDescription.EditValue),
            New JProperty("issuetype",
                New JObject(
                    New JProperty("name", "DB Restore Request")
                )
            ),
            New JProperty("customfield_12500", CboClientName.EditValue), ' Client Name
            New JProperty("customfield_12501", TxtClientID.EditValue) ' Client ID
        )
    )
)
        If TxtJIRAToken.Text <> "" Then
            JIRAToken = TxtJIRAToken.Text
        Else
            JIRAToken = "ODAwNDc5MDE5OTk4Op6GvljcN/HFEyy5z1uJQyoV8F6m"
        End If
        Using client As New WebClient()
            client.Headers.Add("Authorization", "Bearer " & JIRAToken) ' Replace YOUR_API_TOKEN with your JIRA API token
            client.Headers.Add("Content-Type", "application/json")

            Dim responseBytes As Byte() = client.UploadData("https://jira.tools.telushealth.com/rest/api/2/issue/", "POST", Encoding.UTF8.GetBytes(payload.ToString()))

            Dim responseString As String = Encoding.UTF8.GetString(responseBytes)

            ' Parse the JSON response to get the ticket key
            'Dim ticketKey As String = "FLEX-3510"
            Dim ticketKey As String = JObject.Parse(responseString).SelectToken("key").ToString()

            ' After issue creation
            If ChkDevStatus.Checked Then
                TransitionIssue(ticketKey, "101", JIRAToken)
            End If

            MsgBox(ticketKey & " was successfully created!")
            TxtFLEXNb.Text = ticketKey.ToString.Replace("FLEX-", "")
            MenuV2.GVIssues.SetFocusedRowCellValue("FLEX Ticket", CInt(ticketKey.ToString.Replace("FLEX-", "")))
        End Using

    End Sub

    Sub TransitionIssue(issueKey As String, transitionId As String, token As String)
        Dim JIRAToken As String = If(TxtJIRAToken.Text <> "", TxtJIRAToken.Text, "ODAwNDc5MDE5OTk4Op6GvljcN/HFEyy5z1uJQyoV8F6m")
        Dim transitionPayload As JObject = New JObject(
        New JProperty("transition",
            New JObject(
                New JProperty("id", transitionId)
            )
        )
    )

        Using client As New WebClient()
            client.Headers.Add("Authorization", "Bearer " & token)
            client.Headers.Add("Content-Type", "application/json")

            Dim responseBytes As Byte() = client.UploadData($"https://jira.tools.telushealth.com/rest/api/2/issue/{issueKey}/transitions", "POST", Encoding.UTF8.GetBytes(transitionPayload.ToString()))
            Dim responseString As String = Encoding.UTF8.GetString(responseBytes)
            ' Assuming success, you might want to log this or handle errors appropriately
        End Using
    End Sub


End Class
