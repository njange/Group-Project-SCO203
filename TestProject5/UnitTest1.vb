Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Net.Mime.MediaTypeNames
Imports System.IO
Imports System
Imports grp203

<TestClass()>
Public Class UnitTest1
    <TestMethod()>
    Public Sub TestLoginWithValidCredentials()
        Dim username As String = "admin"
        Dim password As String = "admin"
        Dim expectedMessage As String = "Login Successful"

        Dim form As New Form1() ' Using Form1 from the imported grp203 namespace

        form.Login_Click(username, password)

        Assert.AreEqual(expectedMessage, "Login Successful")
    End Sub
End Class
