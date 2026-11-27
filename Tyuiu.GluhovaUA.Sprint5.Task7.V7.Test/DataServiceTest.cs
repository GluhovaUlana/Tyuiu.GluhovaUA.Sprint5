using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GluhovaUA.Sprint5.Task7.V7.Lib;
namespace Tyuiu.GluhovaUA.Sprint5.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadDataAndSave()
        {
            string path = Path.Combine("C:\\DataSprint5", "InPutDataFileTask7V7.txt");
            FileInfo fileinfo = new FileInfo(path);
            fileinfo.Refresh();
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
