// Created: 2020-08-08 16:33
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Net.Mime.MediaTypeNames; // Assuming this is the actual namespace of your main project
using System.IO;
using System;
using SCO203;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoginWithValidCredentials()
        {
            string username = "admin";
            string password = "admin";
            string expectedMessage = "Login Successful";

            Form1.Login_Click(username, password);

            Assert.AreEqual(expectedMessage, "Login Successful");


        }
    }
}