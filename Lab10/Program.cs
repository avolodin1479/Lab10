using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Градусы ");
                int degree1 = Convert.ToInt32(Console.ReadLine());
                if (degree1 < 0 || degree1 > 360)
                {
                    Console.WriteLine("Значение должно быть от 0 до 360");
                    Console.Write("Градусы ");
                    degree1 = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Минуты ");
                int min1 = Convert.ToInt32(Console.ReadLine());
                if (min1 < 0 || min1 > 360)
                {
                    Console.WriteLine("Значение должно быть от 0 до 60");
                    Console.Write("Минуты ");
                    min1 = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Секунды ");
                int sec1 = Convert.ToInt32(Console.ReadLine());
                if (sec1 < 0 || sec1 > 360)
                {
                    Console.WriteLine("Значение должно быть от 0 до 60");
                    sec1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Секунды ");
                }
                double R1;

                Angle angle1 = new Angle(degree1, min1, sec1);

                angle1.ToRadians(degree1, min1, sec1, out R1);
                Console.WriteLine("Угол равен {0} радиан", R1);
            }
            catch (Exception)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            Console.ReadKey();
        }
    }

    class Angle
    {
        public int degree;
        public int min;
        public int sec;

        public Angle(int degree, int min, int sec)
        {
            this.degree = degree;
            this.min = min;
            this.sec = sec;
        }
        public void ToRadians(double degree, double min, double sec, out double Rezult)
        {
            Rezult = (degree + (min + sec / 60) / 60) * (Math.PI / 180);
        }
    }
}






