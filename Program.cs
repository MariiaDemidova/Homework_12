using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle.Length(radius);
            Circle.Square(radius);
            Console.WriteLine("Введите координату точки X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату точки Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Circle.CheckPosition(radius, x, y);
            Console.ReadKey();
        }
    }
    public static class Circle
    {
        public static void Length(double radius)
        {
            Console.WriteLine("Длина окружности = {0:F2}", 2*Math.PI*radius);
        }
        public static void Square(double radius)
        {
            Console.WriteLine("Площадь круга = {0:F2}", Math.PI*Math.Pow(radius,2));
        }
        public static void CheckPosition(double radius, double x, double y)
        {
            double AB = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (AB <= radius)
            {
                Console.WriteLine("Точка x,y принадлежит кругу");
            }
            else
            {
                Console.WriteLine("Точка x,y не принадлежит кругу");
            }
        }
    }
}
