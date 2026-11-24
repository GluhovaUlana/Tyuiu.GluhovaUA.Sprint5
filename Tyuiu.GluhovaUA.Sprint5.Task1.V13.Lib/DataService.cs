using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GluhovaUA.Sprint5.Task1.V13.Lib
{
    public class DataService : ISprint5Task1V13
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string stry;
            double z;
            for (int x= startValue;x<=stopValue; x++)
            {
                z = Math.Cos(x) + x;
                if (z == 0)
                {
                    y = 0;
                    stry = Convert.ToString(y);
                    File.AppendAllText(path, stry);
                }
                else
                {
                    y = Math.Round(((2 * x - 3) / (Math.Cos(x) + x))+5,2);
                    stry = Convert.ToString(y);
                    File.AppendAllText(path, stry+Environment.NewLine);
                }
            }
            return path;
        }
    }
}
