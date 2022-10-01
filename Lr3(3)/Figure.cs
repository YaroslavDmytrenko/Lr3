using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class Figure
    {
        Point point1;
        Point point2;
        Point point3;
        Point point4;
        Point point5;
        int figure;
        public Figure(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            figure = 0;
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            figure = 1;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.point5 = point5;
            figure = 2;
        }

        public double LengthSide(Point A, Point B)
        {
            double lenght = Math.Pow(Math.Pow(B.X-A.X,2)+Math.Pow(B.Y - A.Y,2),0.5);
            return lenght;
        }

        public string Name()
        {
            string name = "";
            switch (figure)
            {

                case 0:
                    name = $"{point1.Name}{point2.Name}{point3.Name}";
                    break;
                case 1:
                    name = $"{point1.Name}{point2.Name}{point3.Name}{point4.Name}";
                    break;
                case 2:
                    name = $"{point1.Name}{point2.Name}{point3.Name}{point4.Name}{point5.Name}";
                    break;
                default:
                    break;
            }
            return name;
        }
        public double PerimeterCalculator()
        {
            double perimeter = 0;
            switch (figure)
            {
                
                case 0:
                    perimeter += LengthSide(point1, point2);
                    perimeter += LengthSide(point2, point3);
                    perimeter += LengthSide(point2, point1);
                    break;
                case 1:
                    perimeter += LengthSide(point1, point2);
                    perimeter += LengthSide(point2, point3);
                    perimeter += LengthSide(point3, point4);
                    perimeter += LengthSide(point4, point1);
                    break;
                case 2:
                    perimeter += LengthSide(point1, point2);
                    perimeter += LengthSide(point2, point3);
                    perimeter += LengthSide(point3, point4);
                    perimeter += LengthSide(point4, point5);
                    perimeter += LengthSide(point5, point1);
                    break;
                default:
                    break;
            }
            return perimeter;
        }
    }
}
