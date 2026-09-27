//*************************************************************************************************************
//*Практическая работа 6                                                                                      *
//*Выполнил: Костюченков В.С.,группа 2ИСПд                                                                    *
//*Задание: составить программу работы алгоритма усложненного ветвления с обработкой ошибок времени выполнения*
//*************************************************************************************************************
//***



using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace работа_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Практическая работа 6");
            int x, y, radius;
            Console.Write("Введите radius: \n");
            Console.Write("radius = ");
            try
            {
                radius = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите координаты x,y: \n");
                Console.Write("x = ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y = ");
                y = Convert.ToInt32(Console.ReadLine());
                double distance = Math.Pow(x, 2) + Math.Pow(y, 2);
                double radiusSquared = Math.Pow(radius, 2);
                int resultcheck;
                switch (distance < radiusSquared)
                {
                    case true:
                        Console.WriteLine($"Координаты точки A x = {x},y = {y} внутри круга ");
                        break;
                    case false:
                        switch (distance == radiusSquared)
                        {
                            case true:
                                Console.WriteLine($"Координаты точки A x = {x},y = {y} на границе круга ");
                                break;
                            case false:
                                switch (distance > radiusSquared)
                                {
                                    case true:
                                        Console.WriteLine($"Координаты точки A x = {x},y = {y} за пределами круга ");
                                        break;
                                    default:
                                        Console.WriteLine($"error reskovski");
                                        break;
                                }
                                break;
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что то пошло не так. Ошибка: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}