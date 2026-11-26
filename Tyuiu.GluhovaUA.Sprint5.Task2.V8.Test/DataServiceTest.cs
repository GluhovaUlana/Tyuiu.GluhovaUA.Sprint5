using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GluhovaUA.Sprint5.Task2.V8.Lib;
namespace Tyuiu.GluhovaUA.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileinfo = new FileInfo(path);
            fileinfo.Refresh();
            bool fileExists = fileinfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
