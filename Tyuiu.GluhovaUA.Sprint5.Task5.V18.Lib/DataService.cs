using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GluhovaUA.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            string tr = File.ReadAllText(path);
            tr = tr.Replace('.', ',');
            string[] num = tr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string nums in num)
            {
                
                double t = Convert.ToDouble(nums);
                if ((t >= 10 && t < 100) || (t <= -10 && t > -100))
                {
                    res *= t;
                }
            }

            return Math.Round(res, 3);
        }
    }
}