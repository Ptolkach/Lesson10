using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол с указанием градусов, минут, секунд (ввести 3 целочисленных значения)");
            int gradus = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int sec = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(gradus,min,sec);
            double radians = angle.ToRadians();
            Console.WriteLine(radians);
            Console.ReadKey();
        }
    }
}
