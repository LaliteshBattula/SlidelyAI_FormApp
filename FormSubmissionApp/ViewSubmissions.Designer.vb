<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissions
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
        prevBtn = New Button()
        nxtBtn = New Button()
        nameLabel = New Label()
        emailLabel = New Label()
        phoneLabel = New Label()
        githubLabel = New Label()
        timerLabel = New Label()
        nameTxt = New TextBox()
        emailTxt = New TextBox()
        phoneTxt = New TextBox()
        githubTxt = New TextBox()
        timerTxt = New TextBox()
        Label6 = New Label()
        deleteBtn = New Button()
        SuspendLayout()
        ' 
        ' prevBtn
        ' 
        prevBtn.BackColor = Color.Khaki
        prevBtn.Font = New Font("Segoe UI", 12F)
        prevBtn.Location = New Point(162, 364)
        prevBtn.Name = "prevBtn"
        prevBtn.Size = New Size(224, 38)
        prevBtn.TabIndex = 0
        prevBtn.Text = "PREVIOUS (CTRL + P)"
        prevBtn.UseVisualStyleBackColor = False
        ' 
        ' nxtBtn
        ' 
        nxtBtn.BackColor = Color.SkyBlue
        nxtBtn.Font = New Font("Segoe UI", 12F)
        nxtBtn.Location = New Point(392, 364)
        nxtBtn.Name = "nxtBtn"
        nxtBtn.Size = New Size(225, 38)
        nxtBtn.TabIndex = 1
        nxtBtn.Text = "NEXT (CTRL + N)"
        nxtBtn.UseVisualStyleBackColor = False
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Segoe UI", 12F)
        nameLabel.Location = New Point(171, 70)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(52, 21)
        nameLabel.TabIndex = 2
        nameLabel.Text = "Name"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Font = New Font("Segoe UI", 12F)
        emailLabel.Location = New Point(171, 114)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(48, 21)
        emailLabel.TabIndex = 3
        emailLabel.Text = "Email"
        ' 
        ' phoneLabel
        ' 
        phoneLabel.Font = New Font("Segoe UI", 12F)
        phoneLabel.Location = New Point(161, 157)
        phoneLabel.Name = "phoneLabel"
        phoneLabel.Size = New Size(105, 26)
        phoneLabel.TabIndex = 4
        phoneLabel.Text = "Phone Num"
        ' 
        ' githubLabel
        ' 
        githubLabel.Font = New Font("Segoe UI", 12F)
        githubLabel.Location = New Point(161, 196)
        githubLabel.Name = "githubLabel"
        githubLabel.Size = New Size(93, 42)
        githubLabel.TabIndex = 5
        githubLabel.Text = "Github Link For Task 2"
        githubLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' timerLabel
        ' 
        timerLabel.Font = New Font("Segoe UI", 12F)
        timerLabel.Location = New Point(162, 255)
        timerLabel.Name = "timerLabel"
        timerLabel.Size = New Size(92, 48)
        timerLabel.TabIndex = 6
        timerLabel.Text = "Stopwatch Time"
        timerLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' nameTxt
        ' 
        nameTxt.BackColor = SystemColors.ActiveBorder
        nameTxt.BorderStyle = BorderStyle.FixedSingle
        nameTxt.Font = New Font("Segoe UI", 12F)
        nameTxt.Location = New Point(317, 68)
        nameTxt.Multiline = True
        nameTxt.Name = "nameTxt"
        nameTxt.ReadOnly = True
        nameTxt.Size = New Size(299, 38)
        nameTxt.TabIndex = 7
        nameTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' emailTxt
        ' 
        emailTxt.BackColor = SystemColors.ActiveBorder
        emailTxt.BorderStyle = BorderStyle.FixedSingle
        emailTxt.Font = New Font("Segoe UI", 12F)
        emailTxt.Location = New Point(317, 112)
        emailTxt.Multiline = True
        emailTxt.Name = "emailTxt"
        emailTxt.ReadOnly = True
        emailTxt.Size = New Size(299, 37)
        emailTxt.TabIndex = 8
        emailTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' phoneTxt
        ' 
        phoneTxt.BackColor = SystemColors.ActiveBorder
        phoneTxt.BorderStyle = BorderStyle.FixedSingle
        phoneTxt.Font = New Font("Segoe UI", 12F)
        phoneTxt.Location = New Point(317, 155)
        phoneTxt.Multiline = True
        phoneTxt.Name = "phoneTxt"
        phoneTxt.ReadOnly = True
        phoneTxt.Size = New Size(299, 37)
        phoneTxt.TabIndex = 9
        phoneTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' githubTxt
        ' 
        githubTxt.BackColor = SystemColors.ActiveBorder
        githubTxt.BorderStyle = BorderStyle.FixedSingle
        githubTxt.Font = New Font("Segoe UI", 12F)
        githubTxt.Location = New Point(317, 196)
        githubTxt.Multiline = True
        githubTxt.Name = "githubTxt"
        githubTxt.ReadOnly = True
        githubTxt.Size = New Size(299, 49)
        githubTxt.TabIndex = 10
        githubTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' timerTxt
        ' 
        timerTxt.BackColor = SystemColors.ActiveBorder
        timerTxt.BorderStyle = BorderStyle.FixedSingle
        timerTxt.Font = New Font("Segoe UI", 12F)
        timerTxt.Location = New Point(317, 251)
        timerTxt.Multiline = True
        timerTxt.Name = "timerTxt"
        timerTxt.ReadOnly = True
        timerTxt.Size = New Size(299, 37)
        timerTxt.TabIndex = 11
        timerTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 16F)
        Label6.Location = New Point(161, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(468, 25)
        Label6.TabIndex = 12
        Label6.Text = "Lalitesh Battula, Slidely Task 2 - View Submissions"
        ' 
        ' deleteBtn
        ' 
        deleteBtn.BackColor = Color.Salmon
        deleteBtn.Font = New Font("Segoe UI", 12F)
        deleteBtn.Location = New Point(162, 320)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(454, 38)
        deleteBtn.TabIndex = 13
        deleteBtn.Text = "DELETE (CTRL + D)"
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(deleteBtn)
        Controls.Add(Label6)
        Controls.Add(timerTxt)
        Controls.Add(githubTxt)
        Controls.Add(phoneTxt)
        Controls.Add(emailTxt)
        Controls.Add(nameTxt)
        Controls.Add(timerLabel)
        Controls.Add(githubLabel)
        Controls.Add(phoneLabel)
        Controls.Add(emailLabel)
        Controls.Add(nameLabel)
        Controls.Add(nxtBtn)
        Controls.Add(prevBtn)
        Name = "ViewSubmissions"
        Text = "ViewSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents prevBtn As Button
    Friend WithEvents nxtBtn As Button
    Friend WithEvents nameLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents githubLabel As Label
    Friend WithEvents timerLabel As Label
    Friend WithEvents nameTxt As TextBox
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents phoneTxt As TextBox
    Friend WithEvents githubTxt As TextBox
    Friend WithEvents timerTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents deleteBtn As Button
End Class
