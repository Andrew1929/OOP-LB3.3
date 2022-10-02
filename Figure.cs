using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB_3._3
{
    class Figure : Point
    {
        private double perimeter;
        private double lenthside;
        public Figure (int radius , int sides , string polygon) : base(radius, sides, polygon)
        {
        }
        public double LengthSide()
        {
            lenthside = 2*radius*Math.Sin(180/sides);
            Console.WriteLine($"lenth of one side = 2R * sin(180/n) = {lenthside}");
            return lenthside;
        }
        public void PerimeterCalculator()
        {
            lenthside = 2 * radius * Math.Sin(180 / sides);
            perimeter = lenthside * sides;
            Console.WriteLine($"perimeter = lenth of one side * sides = {perimeter}");
        }
        public void Show()
        {
            Console.WriteLine($"name of the polygon : {polygon}\n" +
            $"perimeter : {perimeter}");
        }
    }
}
