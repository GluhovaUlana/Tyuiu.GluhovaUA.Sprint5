using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GluhovaUA.Sprint5.Task1.V13.Lib;
namespace Tyuiu.GluhovaUA.Sprint5.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            DataService ds = new DataService();
            ds.SaveToFileTextData(-5,5);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileinfo = new FileInfo(path);
            fileinfo.Refresh();
            bool fileExists = fileinfo.Exists;
            
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}