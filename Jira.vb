Imports Newtonsoft.Json.Linq
Imports System.Net

Public Class JiraIssue
	Public Property Key As String
	Public Property Status As String
	Public Property Summary As String
	Public Property Description As String
	Public Property Assignee As String
	Public Property Reporter As String
	Public Property Priority As String
	Public Property Labels As String
	Public Property Carriers As String
	Public Property Created As DateTime
	Public Property Updated As DateTime
	Public Property FLEXSClients As String
	Public Property FixVersion As String
	Public Property PropRelease As String

End Class

Public Class JiraAPI
	Private _baseURL As String
	Private _token As String

	Public Sub New(baseURL As String, token As String)
		_baseURL = baseURL
		_token = token
	End Sub

	Public Function GetIssue(key As String) As JiraIssue

		On Error Resume Next

		Dim url As String = String.Format("{0}/rest/api/latest/issue/{1}", _baseURL, key)
		Dim request As HttpWebRequest = WebRequest.Create(url)
		request.Headers.Add("Authorization", String.Format("Bearer {0}", _token))
		request.Method = "GET"
		Dim response As HttpWebResponse = request.GetResponse()

		If response.StatusCode = HttpStatusCode.OK Then
			Dim stream As System.IO.Stream = response.GetResponseStream()
			Dim reader As New System.IO.StreamReader(stream)
			Dim json As String = reader.ReadToEnd()

			Dim issue As JiraIssue = New JiraIssue()
			Dim obj As JObject = JObject.Parse(json)

			issue.Key = obj("key").ToString()
			issue.Status = obj("fields")("status")("name").ToString()
			issue.Summary = obj("fields")("summary").ToString()
			issue.Description = obj("fields")("description").ToString()
			'issue.Assignee = If(obj("fields")("assignee") = vbNullString,
			'    "Unassigned",
			'    obj("fields")("assignee")("displayName").ToString())
			issue.Assignee = If(obj("fields")("assignee").Count <> 0, obj("fields")("assignee")("displayName").ToString(), "Unassigned")
			If obj("fields")("fixVersions").Count <> 0 Then
				issue.FixVersion = obj("fields")("fixVersions").Item(0)("name").ToString()
				issue.FixVersion += vbNewLine & obj("fields")("fixVersions").Item(0)("releaseDate").ToString()
				'If obj("fields")("fixVersions").Item(0)("releaseDate").Count <> 0 Then
				'	issue.FixVersion += vbNewLine & obj("fields")("fixVersions").Item(0)("releaseDate").ToString()
				'End If
			Else
				issue.FixVersion = ""
			End If

			'issue.FixVersion = If(obj("fields")("fixVersions").Count <> 0, obj("fields")("fixVersions").Item(0)("name").ToString(), "")
			'	If obj("fields")("fixVersions")("releaseDate").Count <> 0 Then
			'		issue.FixVersion += vbNewLine & obj("fields")("fixVersions").Item(0)("releaseDate").ToString()
			'	End If  '& Chr(10) & obj("fields")("fixVersions").Item(0)("releaseDate").ToString(), "")
			'issue.FixVersion = obj("fields")("fixVersions").Item(0)("name").ToString()
			issue.Reporter = obj("fields")("reporter")("displayName").ToString()
			issue.Priority = obj("fields")("priority")("name").ToString()
			issue.Labels = Trim(Replace(Replace(Replace(Replace(Replace(obj("fields")("labels").ToString(), """", ""), "[" & vbCrLf, ""), vbCrLf & "]", ""), vbCrLf, ""), "  ", " "))
			issue.Created = CDate(obj("fields")("created").ToString())
			issue.Updated = CDate(obj("fields")("updated").ToString())

			If obj("fields")("customfield_12704").Count <> 0 Then
				For i = 0 To obj("fields")("customfield_12704").Count - 1
					If i = 0 Then
						issue.Carriers = obj("fields")("customfield_12704").Item(i)("value").ToString
					Else
						issue.Carriers += ", " & obj("fields")("customfield_12704").Item(i)("value").ToString
					End If
				Next
			End If
			issue.PropRelease = obj("fields")("customfield_12138").ToString
			issue.FLEXSClients = Trim(Replace(Replace(Replace(Replace(Replace(obj("fields")("customfield_12705").ToString(), """", ""), "[" & vbCrLf, ""), vbCrLf & "]", ""), vbCrLf, ""), "  ", " "))

			Return issue
		End If

		Return Nothing
	End Function

End Class
