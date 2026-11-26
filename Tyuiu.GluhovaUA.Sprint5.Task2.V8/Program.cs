using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint5.Task2.V8.Lib;

namespace Tyuiu.GluhovaUA.Sprint5.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { {9, 4, -6 },
                                         { 3, 9, 9 },
                                        {- 6, 7, -4 }};
            int r = mtrx.GetUpperBound(0)+1;
            int c = mtrx.Length / r;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Глухова У. А. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Глухова У. А. | ПИНб-26-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить положительные элементы массива на 1, отрицательные на 0.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив: *");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{mtrx[i,j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}

