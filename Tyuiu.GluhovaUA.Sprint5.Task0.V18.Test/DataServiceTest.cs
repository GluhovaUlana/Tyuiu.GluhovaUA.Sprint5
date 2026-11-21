using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GluhovaUA.Sprint5.Task0.V18.Lib;
namespace Tyuiu.GluhovaUA.Sprint5.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;
            ds.SaveToFileTextData(x);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}