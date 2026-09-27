//*********************************************************
//*Практическая работа 5                                  *
//*Выполнил: Костюченков В.С.,группа 2ИСПд                *
//*Задание: составить программу работы алгоритма ветвления*
//*********************************************************




using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace работа_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Здраствуйте!");
            Console.WriteLine("Практическая работа 5");
            int x, y, radius;
            Console.Write("Введите radius: \n");
            Console.Write("radius = ");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты x,y: \n");
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());

            if (Math.Pow(x,2)+Math.Pow(y,2) < Math.Pow(radius,2))
            {
                Console.WriteLine($"Координаты точки A x = {x},y = {y} внутри круга ");
            }
            else if (Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(radius, 2))
            {
                Console.WriteLine($"Координаты точки A x = {x},y = {y} на границе круга ");
            }
            else if (Math.Pow(x, 2) + Math.Pow(y, 2) > Math.Pow(radius, 2))
            {
                Console.WriteLine($"Координаты точки A x = {x},y = {y} за пределами круга ");
            }
            Console.ReadKey();
        }
    }
}

