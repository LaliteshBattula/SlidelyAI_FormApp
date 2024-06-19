<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        viewBtn = New Button()
        createBtn = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' viewBtn
        ' 
        viewBtn.BackColor = Color.Khaki
        viewBtn.Font = New Font("Segoe UI", 12F)
        viewBtn.Location = New Point(106, 138)
        viewBtn.Name = "viewBtn"
        viewBtn.Size = New Size(464, 49)
        viewBtn.TabIndex = 0
        viewBtn.Text = "VIEW SUBMISSIONS (CTRL + V)"
        viewBtn.UseVisualStyleBackColor = False
        ' 
        ' createBtn
        ' 
        createBtn.BackColor = Color.SkyBlue
        createBtn.Font = New Font("Segoe UI", 12F)
        createBtn.Location = New Point(106, 193)
        createBtn.Name = "createBtn"
        createBtn.Size = New Size(464, 47)
        createBtn.TabIndex = 1
        createBtn.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        createBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F)
        Label1.Location = New Point(106, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(464, 25)
        Label1.TabIndex = 2
        Label1.Text = "Lalitesh Battula, Slidely Task 2 - Slidely Form App"
        ' 
        ' BaseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(createBtn)
        Controls.Add(viewBtn)
        Name = "BaseForm"
        Text = "BaseForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents viewBtn As Button
    Friend WithEvents createBtn As Button
    Friend WithEvents Label1 As Label

End Class
