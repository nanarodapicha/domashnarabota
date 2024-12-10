using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashnarabota
{
    public class Point<T>
    {
        private T x, y;

        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        //zad1
        public void Swap()
        {
            T temp = x;
            x = y;
            y = temp;
        }
        //zad2
        public double DistanceTo(Point<T> vtori)
        {
            double x1 = Convert.ToDouble(this.x);
            double y1 = Convert.ToDouble(this.y);
            double x2 = Convert.ToDouble(vtori.X);
            double y2 = Convert.ToDouble(vtori.Y);

            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        //zad3
        public static Point<double> Midpoint(Point<T> p1, Point<T> p2)
        {
            double x1 = Convert.ToDouble(p1.X);
            double y1 = Convert.ToDouble(p1.Y);
            double x2 = Convert.ToDouble(p2.X);
            double y2 = Convert.ToDouble(p2.Y);
            double sredaX = (x1 + x2) / 2;
            double sredaY = (y1 + y2) / 2;

            return new Point<double>(sredaX, sredaY);
        }
    }
}
