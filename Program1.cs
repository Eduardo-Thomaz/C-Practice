using System;

namespace C_Tests
{
    class Program
    {
        static void Main(string[] args)
        {

          double [] n1;
          int arraySize = 10;

          n1 = new double[arraySize];

          Console.WriteLine("Inform the array: ");
          for (int i = 0; i < arraySize; i++)
          {

            n1[i] = double.Parse(Console.ReadLine());
            Console.WriteLine("Value is: {0:N}", n1[i]);

          }

          for (int i = 0; i < arraySize; i++)
          {
            if(n1[i] < 0)
            {
              n1[i] = 0;
              Console.WriteLine("Value is: {0:N}", n1[i]);
            }
          }
        }
    }
}
