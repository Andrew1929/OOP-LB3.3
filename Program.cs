using System;

namespace OOP_LB_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Figure figure = new Figure(5,5,"П'ятиугольник");
            figure.Show();
            figure.LengthSide();
            figure.PerimeterCalculator();
        }
    }
}
