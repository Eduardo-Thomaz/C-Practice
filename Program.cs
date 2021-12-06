using System;

namespace C_Tests
{
    class Program
    {
        static void Main(string[] args)
        {

          double [] n1;
          double [] n2;
          double [] nt;
          int arraySize;

          Console.WriteLine("Inform array size:");
          arraySize = int.Parse(Console.ReadLine());

          n1 = new double[arraySize];
          n2 = new double[arraySize];
          nt = new double[arraySize];

          for (int n = 0; n < arraySize; n++)
          {

            Console.WriteLine("Inform n1:");
            n1[n] = double.Parse(Console.ReadLine());

            Console.WriteLine("Inform n2:");
            n2[n] = double.Parse(Console.ReadLine());

            nt[n] = n1[n] + n2[n];
            Console.WriteLine("nt is: {0:N}", nt[n]);
          }

          Console.WriteLine("End of shenanigans!");
   
        }
    }
}
