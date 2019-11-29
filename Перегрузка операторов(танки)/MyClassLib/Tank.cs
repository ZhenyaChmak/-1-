using System;

namespace MyClassLib
{
    public class Tank
    {
        private string Name { get; set; }                //название танка
        private int AmmunitionLoad { get; set; }         // боекомплект
        private double Armor { get; set; }               //уровень брони
        private double Maneuverablility { get; set; }     //уровень маневренности

        static Random rnd = new Random();
      
        public Tank(string name)
        {
            Name = name;
            AmmunitionLoad = rnd.Next(0, 100);
            Armor = rnd.NextDouble()*100; 
            Maneuverablility = rnd.NextDouble() * 100;
        }
        
        public override string ToString()
        {
            return $"Название танка: {Name}\n " +
                $"Боекомплект: {AmmunitionLoad}\n " +
                $"Уровень брони: {String.Format("{0:#.##}", Armor)}\n " +
                $"Уровень маневренности: {String.Format("{0:#.##}", Maneuverablility)}";
        }

        public static string operator * (Tank T34, Tank Pantera)
        {
            if (T34 > Pantera)
                return "Победил: T34\n";
            else 
                return "Победил: Pantera\n";
        }

        public static bool operator > (Tank T34, Tank Pantera)
        {
            if (T34.AmmunitionLoad > Pantera.AmmunitionLoad && T34.Armor > Pantera.Armor ||
                T34.AmmunitionLoad > Pantera.AmmunitionLoad && T34.Maneuverablility > Pantera.Maneuverablility ||
                T34.Armor > Pantera.Armor && T34.Maneuverablility > Pantera.Maneuverablility)
                return true;
            else
                return false;
        }

        public static bool operator < (Tank T34, Tank Pantera)
        {
            if (T34.AmmunitionLoad < Pantera.AmmunitionLoad && T34.Armor < Pantera.Armor ||
                T34.AmmunitionLoad < Pantera.AmmunitionLoad && T34.Maneuverablility < Pantera.Maneuverablility ||
                T34.Armor < Pantera.Armor && T34.Maneuverablility < Pantera.Maneuverablility)
                return false;
            else
                return true;
        }
    }
}
