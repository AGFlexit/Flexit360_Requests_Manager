Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.Text

Public Class JIRADetails

    Private Sub JIRADetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim baseURL As String = "https://jira.tools.telushealth.com"
        Dim token As String = "ODAwNDc5MDE5OTk4Op6GvljcN/HFEyy5z1uJQyoV8F6m"

        Dim jira As JiraAPI = New JiraAPI(baseURL, token)
        'Dim issue As JiraIssue = jira.GetIssue("FLEX-" & ShapedForm1.RadTextBox2.Text.ToUpper)
        Dim issue As JiraIssue = jira.GetIssue("FLEXS-" & Main.TxtFLEXS.Text.ToUpper)

        If issue IsNot Nothing Then
            Me.txtFLEXNb.Text = issue.Key
            Me.txtAssignee.Text = issue.Assignee
            Me.txtReporter.Text = issue.Reporter
            Me.txtPriority.Text = issue.Priority
            Me.txtSummary.Text = issue.Summary
            Me.txtDesc.Text = issue.Description
            Me.txtStatus.Text = issue.Status
            Me.txtLabels.Text = issue.Labels
            Me.dtCreated.Value = issue.Created
            Me.dtUpdated.Value = issue.Updated
            Me.txtCarriers.Text = issue.Carriers
            Me.txtClients.Text = issue.FLEXSClients
            Me.txtFixVersion.Text = issue.FixVersion
            Me.txtPropRelease.Text = issue.PropRelease
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

        Dim payload As JObject = New JObject(
    New JProperty("fields",
        New JObject(
            New JProperty("project",
                New JObject(
                    New JProperty("key", "FLEX")
                )
            ),
            New JProperty("summary", "This is a test"),
            New JProperty("description", "This is a test description"),
            New JProperty("issuetype",
                New JObject(
                    New JProperty("name", "Task")
                )
            ),
            New JProperty("customfield_12500", "9999"), ' Replace 12345 with the ID of your first custom field
            New JProperty("customfield_12501", "9999") ' Replace 67890 with the ID of your second custom field
        )
    )
)

        Using client As New WebClient()
            client.Headers.Add("Authorization", "Bearer ODAwNDc5MDE5OTk4Op6GvljcN/HFEyy5z1uJQyoV8F6m") ' Replace YOUR_API_TOKEN with your JIRA API token
            client.Headers.Add("Content-Type", "application/json")

            Dim responseBytes As Byte() = client.UploadData("https://jira.tools.telushealth.com/rest/api/2/issue/", "POST", Encoding.UTF8.GetBytes(payload.ToString()))

            Dim responseString As String = Encoding.UTF8.GetString(responseBytes)

            ' Parse the JSON response to get the ticket key
            Dim ticketKey As String = JObject.Parse(responseString).SelectToken("key").ToString()
            MsgBox(ticketKey)
        End Using


    End Sub
End Class
