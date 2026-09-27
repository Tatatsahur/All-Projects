            using System;
            using System.Net.NetworkInformation;
namespace Практическая_4
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Title = "Практическая работа 4";
                double x, y, z;
                double v1, v2, v3, v4, v5, v6;
                Console.WriteLine("Добрый день!");
                Console.Write("Введите x = ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите y = "); //ввод исходных данных
                y = Convert.ToDouble(Console.ReadLine());

                //расчет значения выражения
                v1 = Math.Cos(x * Math.PI);
                v2 = Math.Pow(v1, 2);
                v3 = Math.Exp(x);
                v4 = v3 * Math.Sqrt(y);
                v5 = 0.314 * v4;
                v6 = 1.0 / 7 - v5;
                z = v2 / v6;

            //вывод результата на экран
            Console.WriteLine("Результат: z = {0: 0.###}",z);
                Console.ReadKey();
            }
        }
    }
