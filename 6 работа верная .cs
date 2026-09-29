//*************************************************************************************************************
//*Практическая работа 6                                                                                      *
//*Выполнил: Костюченков В.С.,группа 2ИСПд                                                                    *
//*Задание: составить программу работы алгоритма усложненного ветвления с обработкой ошибок времени выполнения*
//*************************************************************************************************************
//***



using System;
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
                double distance = Math.Pow(x, 2) + Math.Pow(y, 2); //дистанция от центра до точки
                double radiusSquared = Math.Pow(radius, 2); //диаметр
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
                                        Console.WriteLine($"Ошибка.");
                                        break;
                                }
                                break;
                        }
                        break;
                }
            }
            catch (OverflowException oex) //Число вне диапозона (слишком большое либо слишком маленькое)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что то пошло не так. Ошибка: {oex.Message}");
            }
            catch (FormatException fex) //Неверный формат вводимого
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что то пошло не так. Ошибка: {fex.Message}");
            }
            catch (Exception e) // общее исключение
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Что то пошло не так. Ошибка: " + e.Message);
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
