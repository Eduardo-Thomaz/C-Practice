using System;

namespace C_Tests
{
    class Program
    { 
        static void Main(string[] args)
        {
          double radius;
          double areaCircle;

          Console.WriteLine("Inform the radius: ");
          radius = double.Parse(Console.ReadLine());
          areaCircle = CircleArea(radius);
          Console.WriteLine("Area = {0:N}", areaCircle);

        }
        static double CircleArea(double radius)
        {
          double pi = 3.14;
          double area = pi * radius * radius;
          return area;
        }

    }
} 