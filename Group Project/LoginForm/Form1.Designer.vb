<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Login = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Username = New TextBox()
        Password = New TextBox()
        SeePassword = New CheckBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Login
        ' 
        Login.Location = New Point(298, 296)
        Login.Name = "Login"
        Login.Size = New Size(245, 49)
        Login.TabIndex = 0
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(298, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(298, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' Username
        ' 
        Username.Location = New Point(382, 148)
        Username.Name = "Username"
        Username.Size = New Size(161, 23)
        Username.TabIndex = 3
        ' 
        ' Password
        ' 
        Password.Location = New Point(382, 177)
        Password.Name = "Password"
        Password.Size = New Size(161, 23)
        Password.TabIndex = 4
        ' 
        ' SeePassword
        ' 
        SeePassword.AutoSize = True
        SeePassword.Location = New Point(549, 179)
        SeePassword.Name = "SeePassword"
        SeePassword.Size = New Size(97, 19)
        SeePassword.TabIndex = 5
        SeePassword.Text = "See Password"
        SeePassword.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(233, 233)
        Label3.Name = "Label3"
        Label3.Size = New Size(448, 15)
        Label3.TabIndex = 6
        Label3.Text = "Password must be at least 8 characters and contain a number and special characters"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(SeePassword)
        Controls.Add(Password)
        Controls.Add(Username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Login)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents SeePassword As CheckBox
    Friend WithEvents Label3 As Label
End Class
