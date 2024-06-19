Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ApiClient
    Private Shared ReadOnly client As New HttpClient()

    Public Shared Async Function PingServer() As Task(Of Boolean)
        Dim response = Await client.GetAsync("http://localhost:2003/ping")
        Return response.IsSuccessStatusCode
    End Function

    Public Shared Async Function SubmitForm(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String) As Task(Of Boolean)
        Dim submission = New With {
            Key .name = name,
            Key .email = email,
            Key .phone = phone,
            Key .github_link = githubLink,
            Key .stopwatch_time = stopwatchTime
        }

        Dim json As String = Newtonsoft.Json.JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim response = Await client.PostAsync("http://localhost:2003/submit", content)
        Return response.IsSuccessStatusCode
    End Function

    Public Shared Async Function GetSubmission(index As Integer) As Task(Of String)
        Dim response = Await client.GetAsync("http://localhost:2003/read?index=" & index)
        If response.IsSuccessStatusCode Then
            Dim responseString = Await response.Content.ReadAsStringAsync()
            Dim jsonResponse = JsonConvert.DeserializeObject(Of ApiResponse)(responseString)
            If jsonResponse IsNot Nothing AndAlso jsonResponse.status = "success" Then
                Return JsonConvert.SerializeObject(jsonResponse.data)
            End If
        End If
        Return Nothing
    End Function

    Public Shared Async Function DeleteSubmission(id As Integer) As Task(Of Boolean)
        Try
            Dim response = Await client.DeleteAsync("http://localhost:2003/remove?index=" & id)
            If response.IsSuccessStatusCode Then
                Dim responseString = Await response.Content.ReadAsStringAsync()
                Dim jsonResponse = JsonConvert.DeserializeObject(Of ApiResponse)(responseString)
                If jsonResponse IsNot Nothing AndAlso jsonResponse.status = "success" Then
                    Return True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
        Return False
    End Function

    Public Class ApiResponse
        Public Property status As String
        Public Property data As Submission
    End Class

    Public Class Submission
        Public Property id As Integer
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class
End Class
