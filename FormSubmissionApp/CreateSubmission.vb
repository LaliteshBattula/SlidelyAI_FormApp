Imports System.Threading.Tasks
Imports System.Diagnostics
Public Class CreateSubmission
    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim success = Await ApiClient.SubmitForm(txtName.Text, txtEmail.Text, txtPhone.Text, txtGithub.Text, timerLabel.Text)
        If success Then
            MessageBox.Show("Submission successful!")
            txtName.Text = String.Empty
            txtEmail.Text = String.Empty
            txtPhone.Text = String.Empty
            txtGithub.Text = String.Empty
            timerLabel.Text = "00:00:00"
            stopwatch.Reset()
        Else
            MessageBox.Show("Submission failed!")
        End If
    End Sub
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Interval = 1000 ' Set the interval to 1 second
        timer.Start()
        stopwatch.Start()
        Me.KeyPreview = True ' This ensures the form receives key events before any control
    End Sub
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            submitBtn.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.T Then
            timerBtn.PerformClick()
        End If
    End Sub

    Private Sub timerBtn_Click(sender As Object, e As EventArgs) Handles timerBtn.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
        Else
            stopwatch.Start()
            timer.Start()
        End If
    End Sub
    Private Sub UpdateStopwatchLabel()
        timerLabel.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        UpdateStopwatchLabel()
    End Sub

End Class
