<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        TextBoxID = New TextBox()
        Button1 = New Button()
        ButtonCheckOut = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(332, 61)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(100, 23)
        TextBoxID.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(260, 332)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ButtonCheckOut
        ' 
        ButtonCheckOut.Location = New Point(464, 332)
        ButtonCheckOut.Name = "ButtonCheckOut"
        ButtonCheckOut.Size = New Size(75, 23)
        ButtonCheckOut.TabIndex = 3
        ButtonCheckOut.Text = "Checkout"
        ButtonCheckOut.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(233, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 4
        Label1.Text = "IDNo"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(ButtonCheckOut)
        Controls.Add(Button1)
        Controls.Add(TextBoxID)
        Name = "Form5"
        Text = "Checkout"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonCheckOut As Button
    Friend WithEvents Label1 As Label
End Class
