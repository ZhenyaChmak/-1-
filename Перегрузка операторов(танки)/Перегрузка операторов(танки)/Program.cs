using System;
using MyClassLib;

namespace Перегрузка_операторов_танки_
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите количество танков:"); //ввод танков добавлен для реализации исключения и для массива
                int kol1;
                int.TryParse(Console.ReadLine(), out kol1); //при вводе 0 будет исключение
                int kol = 10;
            
            try
            {
                int a = kol / kol1;
                if (kol1 != 5)
                    throw new Exception("\nВвели не соответствующее количество танков \nTанков должно быть 5"); //при вводе не 5-ти танков будетвыполнено исключение

                Tank[] tanks = new Tank[kol1*2];

                for (int i = 0; i < kol1; i++)
                {
                    tanks[i] = new Tank("T34_" + (i+1));
                    tanks[kol1+i] = new Tank("Pantera_" + (i+1));
                }

                Resalt resalt = new Resalt();

                for(int i = 0; i < kol1; i++)
                {
                    Console.WriteLine( tanks[i].ToString() + "\n" + tanks[kol1+i].ToString()); // вывод характеристик
                    Console.WriteLine(tanks[i]*tanks[kol1+i]); //сражение танков
                    if (tanks[i] > tanks[kol1 + i])
                        resalt.counter++;
                    else
                        resalt.counter--;
                }

                Console.WriteLine(resalt.Result()); // вывод общего результата
            }

            catch (Exception ex) 
            {
                Console.WriteLine($"Исключение: { ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
        }
    }
}
