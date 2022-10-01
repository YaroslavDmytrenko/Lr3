using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Rectangle
    {
        private double side1;
        private double side2;
        private double area;
        private double perimeter;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            area = side1* side2;
            return area;
        }

        private double PerimeterCalculator()
        {
            perimeter = side1 * 2 + side2 * 2;
            return perimeter;
        }

        public void Result()
        {
            PerimeterCalculator();
            AreaCalculator();
            Console.WriteLine($"Периметр:{perimeter}, площа:{area}.");
        }

        public double Area
        {
            get
            {
                return area;
            }
        }

        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }
    }
}
