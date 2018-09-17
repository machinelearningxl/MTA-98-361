using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{   

    class Rectangle
    {
        private double lenght;
        private double weight;

        public Rectangle(double l, double w)
        {

            lenght = l;
            weight = w;
        }

        public double getArea()
        {
            return lenght * weight;
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 10);
            double area = rect.getArea();
            Console.WriteLine("Area of the rectangle {0}", area);
            Console.ReadLine();

        }
    }
}
