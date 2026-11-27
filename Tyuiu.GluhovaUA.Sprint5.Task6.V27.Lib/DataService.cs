using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GluhovaUA.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            string tr = File.ReadAllText(path);
            tr = tr.Replace('.', ',');
            string[] num = tr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string nums in num)
            {
                if (int.TryParse(nums, out int t))
                {
                    if ((t >= 100 && t < 1000) || (t <= -100 && t > -1000))
                    {
                        res += 1;
                    }
                }
            }

            return res;
        }
    }
}
