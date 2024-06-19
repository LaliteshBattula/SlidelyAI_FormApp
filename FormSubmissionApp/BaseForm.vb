Public Class BaseForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        Dim createForm As New CreateSubmission()
        createForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles viewBtn.Click
        Dim viewForm As New ViewSubmissions()
        viewForm.ShowDialog()
    End Sub
    Private Sub BaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' This ensures the form receives key events before any control
    End Sub
    Private Sub Button_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            viewBtn.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            createBtn.PerformClick()
        End If
    End Sub
End Class
