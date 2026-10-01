//*************************************************************************************************************
//*Практическая работа 7                                                                                     *
//*Выполнил: Костюченков В.С.,группа 2ИСПд                                                                    *
//*Задание: составить программу работы алгоритма *
//*************************************************************************************************************
//*****



using System;
namespace работа_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Практическая работа 7 \n");
            uint m, a, storage, numcar; // storage - кол-во коробок на складе,m - нужное кол-во коробок, limitcar - лимит ящиков для 1 машины
            Console.WriteLine("Склад неОЗОН \n");
            Console.Write("Введите нужное количество коробок = ");
            try
            {

                m = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Введите количество коробок на складе всего: \n");
                Console.Write("склад = ");
                storage = Convert.ToUInt32(Console.ReadLine());

                if (m > storage)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("На складе меньше коробок чем нужно. Ошибка.");
                   Console.BackgroundColor= ConsoleColor.Green;

                }
                else
                {
                    numcar = 1;
                    uint remaining = m; // remaining - остаток
                    for (uint i = 1; remaining > 0; i++)
                    {
                        Console.WriteLine($"\n--- Машина номер: {numcar} ---");
                        Console.WriteLine($"Осталось погрузить: {remaining} ");
                        Console.WriteLine($"Сколько коробок погрузить в машину {numcar} ");
                        uint loaded; //loaded - загрузка в машину
                        loaded = Convert.ToUInt32(Console.ReadLine());
                        if (loaded <= 0 || loaded > remaining)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ошибка. Введите число от 1 до {remaining}");
                            Console.BackgroundColor = ConsoleColor.Green;
                            continue;
                        }
                        remaining -= loaded;
                        a = storage -= loaded;

                        Console.WriteLine($"На складе сейчас {a} коробок. Погрузка...");
                        Console.WriteLine($"Погрузка {loaded} коробок в машину {numcar} прошла успешно.");
                        numcar++;
                    }
                    Console.WriteLine($"Все {m} коробки погружены");
                }
            }
            catch (FormatException fex) // недопустимый формат ввода
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что то пошло не так. {fex.Message}");
            }
            catch (OverflowException oex) // превышен диапозон возможных чисел (число слишком большое/маленькое)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что то пошло не так. {oex.Message}");
            }
            catch (Exception ex) //общее исключение
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что то пошло не так. {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
