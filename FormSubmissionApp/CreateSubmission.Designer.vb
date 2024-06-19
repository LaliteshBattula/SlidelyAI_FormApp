<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmission
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        submitBtn = New Button()
        timerBtn = New Button()
        nameLabel = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        emailLabel = New Label()
        phoneLabel = New Label()
        githubLabel = New Label()
        timerLabel = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' submitBtn
        ' 
        submitBtn.BackColor = Color.SkyBlue
        submitBtn.Font = New Font("Segoe UI", 12F)
        submitBtn.Location = New Point(123, 368)
        submitBtn.Name = "submitBtn"
        submitBtn.Padding = New Padding(5)
        submitBtn.Size = New Size(476, 43)
        submitBtn.TabIndex = 0
        submitBtn.Text = "SUBMIT (CTRL +S)"
        submitBtn.UseVisualStyleBackColor = False
        ' 
        ' timerBtn
        ' 
        timerBtn.BackColor = Color.Khaki
        timerBtn.Font = New Font("Segoe UI", 12F)
        timerBtn.Location = New Point(123, 286)
        timerBtn.Name = "timerBtn"
        timerBtn.Size = New Size(285, 50)
        timerBtn.TabIndex = 1
        timerBtn.Text = "TOGGLE STOPWATCH (CTRL + T)"
        timerBtn.UseVisualStyleBackColor = False
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Segoe UI", 12F)
        nameLabel.Location = New Point(139, 92)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(52, 21)
        nameLabel.TabIndex = 2
        nameLabel.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 12F)
        txtName.Location = New Point(270, 89)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(320, 30)
        txtName.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 12F)
        txtEmail.Location = New Point(270, 134)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(320, 28)
        txtEmail.TabIndex = 4
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Font = New Font("Segoe UI", 12F)
        txtPhone.Location = New Point(270, 180)
        txtPhone.Multiline = True
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(320, 28)
        txtPhone.TabIndex = 5
        ' 
        ' txtGithub
        ' 
        txtGithub.BorderStyle = BorderStyle.FixedSingle
        txtGithub.Font = New Font("Segoe UI", 12F)
        txtGithub.Location = New Point(270, 229)
        txtGithub.Multiline = True
        txtGithub.Name = "txtGithub"
        txtGithub.Size = New Size(320, 28)
        txtGithub.TabIndex = 6
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Font = New Font("Segoe UI", 12F)
        emailLabel.Location = New Point(139, 137)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(48, 21)
        emailLabel.TabIndex = 7
        emailLabel.Text = "Email"
        ' 
        ' phoneLabel
        ' 
        phoneLabel.AutoSize = True
        phoneLabel.Font = New Font("Segoe UI", 12F)
        phoneLabel.Location = New Point(123, 180)
        phoneLabel.Name = "phoneLabel"
        phoneLabel.Size = New Size(93, 21)
        phoneLabel.TabIndex = 8
        phoneLabel.Text = "Phone Num"
        ' 
        ' githubLabel
        ' 
        githubLabel.Font = New Font("Segoe UI", 12F)
        githubLabel.Location = New Point(123, 219)
        githubLabel.Name = "githubLabel"
        githubLabel.Size = New Size(94, 52)
        githubLabel.TabIndex = 9
        githubLabel.Text = "Github Link For Task 2"
        githubLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' timerLabel
        ' 
        timerLabel.BackColor = SystemColors.ActiveBorder
        timerLabel.Font = New Font("Segoe UI", 12F)
        timerLabel.Location = New Point(441, 295)
        timerLabel.Name = "timerLabel"
        timerLabel.Padding = New Padding(0, 5, 0, 0)
        timerLabel.Size = New Size(149, 32)
        timerLabel.TabIndex = 10
        timerLabel.Text = "00:00:00"
        timerLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F)
        Label1.Location = New Point(118, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 25)
        Label1.TabIndex = 11
        Label1.Text = "Lalitesh Battula, Slidely Task 2 - Create Submission"
        ' 
        ' CreateSubmission
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(timerLabel)
        Controls.Add(githubLabel)
        Controls.Add(phoneLabel)
        Controls.Add(emailLabel)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(nameLabel)
        Controls.Add(timerBtn)
        Controls.Add(submitBtn)
        Name = "CreateSubmission"
        Text = "CreateSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents submitBtn As Button
    Friend WithEvents timerBtn As Button
    Friend WithEvents nameLabel As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents githubLabel As Label
    Friend WithEvents timerLabel As Label
    Friend WithEvents Label1 As Label
End Class
