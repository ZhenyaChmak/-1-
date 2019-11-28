using System;
using MyClassLib;

namespace Перегрузка_операторов_танки_
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите количество танков:");
                int kol1;
                int.TryParse(Console.ReadLine(), out kol1); //при вводе 0 будет исключение
                int kol = 10;
            
            try
            {
                int a = kol / kol1;
                if (kol1 != 5)
                    throw new Exception("\nВвели не соответствующее количество танков \nTанков должно быть 5"); //при вводе не 5танков будет исключение
               
                Tank T34_1 = new Tank("T34_1");
                Tank Pantera_1 = new Tank("Pantera_1");
                T34_1.PrintCharacteristic();
                Pantera_1.PrintCharacteristic();
                Console.WriteLine(T34_1 * Pantera_1);

                Tank T34_2 = new Tank("T34_2");
                Tank Pantera_2 = new Tank("Pantera_2");
                T34_2.PrintCharacteristic();
                Pantera_2.PrintCharacteristic();
                Console.WriteLine(T34_2 * Pantera_2);

                Tank T34_3 = new Tank("T34_3");
                Tank Pantera_3 = new Tank("Pantera_3");
                T34_3.PrintCharacteristic();
                Pantera_3.PrintCharacteristic();
                Console.WriteLine(T34_3 * Pantera_3);

                Tank T34_4 = new Tank("T34_4");
                Tank Pantera_4 = new Tank("Pantera_4");
                T34_4.PrintCharacteristic();
                Pantera_4.PrintCharacteristic();
                Console.WriteLine(T34_4 * Pantera_4);

                Tank T34_5 = new Tank("T34_5");
                Tank Pantera_5 = new Tank("Pantera_5");
                T34_5.PrintCharacteristic();
                Pantera_5.PrintCharacteristic();
                Console.WriteLine(T34_5 * Pantera_5);

                Tank tank = new Tank("Test");
                Console.WriteLine(tank.Result());

                Console.WriteLine("Вывод отдельно всех методов:");
                Console.WriteLine(tank.GetName());
                Console.WriteLine(tank.GetAmmunitionLoad());
                Console.WriteLine(tank.GetArmor());
                Console.WriteLine(tank.GetManeuverablility());

                tank.PrintCharacteristic();
            }

            catch (Exception ex) 
            {
                Console.WriteLine($"Исключение: { ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
           
        }
    }
}
