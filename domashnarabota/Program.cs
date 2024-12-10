using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashnarabota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad1
            Point<int> point = new Point<int>(3, 4);
            Console.WriteLine($"normalni:\nx = {point.X}\ny = {point.Y}");
            point.Swap();
            Console.WriteLine($"razmeneni:\nx = {point.X}\ny = {point.Y}");


            //zad2
            Point<double> point1 = new Point<double>(1.0, 2.0);
            Point<double> point2 = new Point<double>(4.0, 6.0);
            double razstoqnie = point1.DistanceTo(point2);
            Console.WriteLine($"Razstoqnieto mejdu tochkite ({point1.X} {point1.Y}) i ({point2.X} {point2.Y}) e {razstoqnie}");


            //zad3
            Point<int> point3 = new Point<int>(2, 4);
            Point<int> point4 = new Point<int>(6, 8);
            Point<double> srednaTochka = Point<int>.Midpoint(point3, point4);

            Console.WriteLine($"Srednata tochka mejdu ({point3.X},{point4.Y}) i ({point4.X},{point4.Y}) e ({srednaTochka.X},{srednaTochka.Y})");
        }
    }
}
