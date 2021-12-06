using System;

namespace C_Tests
{
    class Program
    { 
      
        static void Main(string[] args)
        {
          int aSize;
          int [] array;
          int min;

          Console.WriteLine("Inform array size:");
          aSize = int.Parse(Console.ReadLine());

          array = new int[aSize];

          for(int i = 0; i < aSize; i++)
          {
            
            Console.WriteLine("Inform value:");
            array[i] = int.Parse(Console.ReadLine());

          }
        
          min = LowestValue(array);
          Console.WriteLine(min);

        }

        static int LowestValue(int [] array)
        {

          int aSize;
          int min = array[0];

          Console.WriteLine("Inform array size:");
          aSize = int.Parse(Console.ReadLine());

          for(int i = 0; i < aSize; i++)
          {
            int n = array[i];
            if(n < min)
            {
              min = n;
            }
          }
          return min;
        }

    }
} 