using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GluhovaUA.Sprint5.Task4.V12.Lib;
namespace Tyuiu.GluhovaUA.Sprint5.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = Path.Combine("C:\\DataSprint5", "InPutDataFileTask4V12.txt");
            FileInfo fileinfo = new FileInfo(path);
            fileinfo.Refresh();
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}