using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GluhovaUA.Sprint5.Task7.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)
        {
            string ps = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V7.txt");
            FileInfo fileInfo = new FileInfo(ps);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(ps);
            }
            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        bool r = (c >= 'А' && c <= 'Я') || c == 'Ё';
                        bool e = (c >= 'A' && c <= 'Z');

                        if (!r && !e)
                        {
                            strLine += c;
                        }

                    }

                    File.AppendAllText(ps, strLine + Environment.NewLine);

                    strLine = "";
                }
            }

            return ps;
        }
    }
}