using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint5.Task7.V7.Lib;

namespace Tyuiu.GluhovaUA.Sprint5.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Глухова У. А. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Глухова У. А. | ПИНб-26-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти количество трехзначных чисел в заданной строке.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine("C:\\DataSprint5", "InPutDataFileTask7V7.txt");
            string ps= Path.Combine(Path.GetTempPath(), "OutPutFileTask7V7.txt");
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

