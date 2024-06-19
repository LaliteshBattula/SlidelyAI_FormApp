Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ViewSubmissions
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)
    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submissions = New List(Of Submission)
        Await LoadSubmissions()
        DisplaySubmission()
        Me.KeyPreview = True ' This ensures the form receives key events before any control
    End Sub

    Private Async Function LoadSubmissions() As Task
        ' Fetch submissions from the backend
        Dim index As Integer = 0
        While True
            Dim submissionJson = Await ApiClient.GetSubmission(index)
            If submissionJson IsNot Nothing Then
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(submissionJson)
                If submission IsNot Nothing Then
                    submissions.Add(submission)
                    index += 1
                Else
                    Exit While
                End If
            Else
                Exit While
            End If
        End While
    End Function

    Private Sub DisplaySubmission()
        If submissions.Count > 0 Then
            Dim currentSubmission As Submission = submissions(currentIndex)

            If currentSubmission IsNot Nothing Then
                nameTxt.Text = currentSubmission.name
                emailTxt.Text = currentSubmission.email
                phoneTxt.Text = currentSubmission.phone
                githubTxt.Text = currentSubmission.github_link
                timerTxt.Text = currentSubmission.stopwatch_time
            Else
                MessageBox.Show("Error: Unable to parse the submission.")
            End If
        Else
            nameTxt.Text = "No submissions available."
            emailTxt.Text = "No submissions available."
            phoneTxt.Text = "No submissions available."
            githubTxt.Text = "No submissions available."
            timerTxt.Text = "No submissions available."
        End If
    End Sub

    Private Sub ViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            prevBtn.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            nxtBtn.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.D Then
            deleteBtn.PerformClick()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles prevBtn.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles nxtBtn.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub
    Private Async Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If submissions.Count > 0 Then
            Dim currentSubmission As Submission = submissions(currentIndex)
            Dim deleteSuccess = Await ApiClient.DeleteSubmission(currentSubmission.id)
            If deleteSuccess Then
                MessageBox.Show("Submission deleted successfully")
                submissions.RemoveAt(currentIndex)
                If currentIndex >= submissions.Count Then
                    currentIndex = submissions.Count - 1
                End If
                DisplaySubmission()
            Else
                MessageBox.Show("Deletion failed")
            End If
        End If
    End Sub
    Public Class Submission
        Public Property id As Integer
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class

End Class
