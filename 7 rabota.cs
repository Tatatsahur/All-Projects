//*************************************************************************************************************
//*Практическая работа 7                                                                                      *
//*Выполнил: Костюченков В.С.,группа 2ИСПд                                                                    *
//*Задание: составить программу работы алгоритма *
//*************************************************************************************************************
//*****





using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace работа_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Практическая работа 7");
            int m, storage, numcar; // storage - кол-во коробок на складе,m - нужное кол-во коробок, numcar - номер машины
            Console.WriteLine("Склад неОЗОН \n");
            Console.WriteLine("Введите количество коробок: \n");
            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество коробок на складе: \n");
            Console.Write("storage = ");
            storage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер машины: \n");
            Console.Write("numcar = ");
            numcar = Convert.ToInt32(Console.ReadLine());
            if (storage == 0)
            {
                Console.WriteLine("Склад пуст");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < m; i++)
            {
                if (storage <= 0)
                {
                    break;
                }

                Console.WriteLine($"На складе сейчас {storage} коробок. Погрузка...");
                if (m >= storage)
                {
                    Console.WriteLine("На складе меньше коробок чем нужно. Ошибка.");
                    break;
                }
                if (m <= 0)
                {
                    Console.WriteLine("Ошибка. Число коробок не может быть меньше нуля");
                    break;
                }
                
                storage = storage - m;
                Console.WriteLine($"Погрузка {m} коробок в машину {numcar} прошла успешно. На складе осталось {storage} коробок");
                numcar = numcar + 1;


                
            }
            Console.ReadKey();


        }

       }
    }

