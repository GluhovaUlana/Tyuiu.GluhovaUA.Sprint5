using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GluhovaUA.Sprint5.Task4.V12.Lib
{
    public class DataService : ISprint5Task4V12
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Replace('.', ',');
            double x = Convert.ToDouble(strx);
            double res = Math.Round(Math.Cos(Math.Pow(x, 3)) + x / 2, 3);
            return res;
        }
    }
}
