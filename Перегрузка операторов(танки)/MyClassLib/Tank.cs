using System;

namespace MyClassLib
{
    public class Tank
    {
        private string Name { get; set; }                //название танка
        private int AmmunitionLoad { get; set; }         // боекомплект
        private double Armor { get; set; }               //уровень брони
        private double Maneuverablility { get; set; }     //уровень маневренности
        static private int counter = 0;

        Random rnd = new Random();
      
        public Tank(string name)
        {
            Name = name;
            AmmunitionLoad = rnd.Next(0, 100);
            Armor = rnd.NextDouble()*100; 
            Maneuverablility = rnd.NextDouble() * 100;
            System.Threading.Thread.Sleep(20);                  //пауза для рандома
        }

        public void PrintCharacteristic()
        {
            Console.Write($"Название танка: {Name}\n " +
                $"Боекомплект: {AmmunitionLoad}\n " +
                $"Уровень брони: {String.Format("{0:#.##}",Armor)}\n " +
                $"Уровень маневренности: {String.Format("{0:#.##}",Maneuverablility)}");
            Console.WriteLine();
        }

        public static string operator * (Tank T34, Tank Pantera)
        {
            if (T34.AmmunitionLoad > Pantera.AmmunitionLoad && T34.Armor > Pantera.Armor ||
                T34.AmmunitionLoad > Pantera.AmmunitionLoad && T34.Maneuverablility > Pantera.Maneuverablility ||
                T34.Armor > Pantera.Armor && T34.Maneuverablility > Pantera.Maneuverablility)
            {
                counter++;
                return "Победил: Т34\n";
            }
            else
            {
                counter--;
                return "Победил: Pantera\n";
            }
        }

        public string Result()
        {
            if (counter > 0)
                return "В ТАНКОВОМ БОЮ ПОБЕДИЛА КОМАНДА ТАНКОВ Т34\n";
            else
                return "В ТАНКОВОМ БОЮ ПОБЕДИЛА КОМАНДА ТАНКОВ Pantera\n";
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAmmunitionLoad()
        {
            return AmmunitionLoad;
        }

        public double GetArmor()
        {
            return Armor;
        }

        public double GetManeuverablility()
        {
            return Maneuverablility;
        }
    }
}
