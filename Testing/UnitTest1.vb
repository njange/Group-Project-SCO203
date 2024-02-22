Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System
' Test Class


Namespace Testing
    <TestClass>
    Public Class UnitTest1
        <TestMethod>
        Sub TestSub()
            'Arrange
            Dim Username As String = "admin"
            Dim Password As String = "admin"
            Dim expected As String = "Login Successful"
            Dim actual As String
            'Act
            If Username = "admin" And Password = "admin" Then
                actual = "Login Successful"
            Else
                actual = "Invalid Username or Password"
            End If
            'Assert
            Assert.AreEqual(expected, actual)
        End Sub
    End Class
End Namespace

