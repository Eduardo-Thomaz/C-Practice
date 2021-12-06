using System;

namespace C_Tests
{
    class Program
    {
        static void Main(string[] args)
        {

         string [] names;
         double [] grades;
         double avg;
         int amount;

         Console.WriteLine("Number of students: ");

         amount = int.Parse(Console.ReadLine());

         names = new string[amount];
         grades = new double[amount];
         avg = 0;

            //Loops command for one student at a time, following grade, decimal possible.
         for(int i = 0; i < amount; i++){

           Console.WriteLine("Student name: ");
           names [i] = Console.ReadLine();
           Console.WriteLine("Student grade: ");
           grades [i] = double.Parse(Console.ReadLine());

           avg = avg + grades[i];

         }

          avg = avg / amount;

          Console.WriteLine("Average: {0:N}", avg);

          for (int i = 0; i < amount; i++){

            if(grades[i]>= avg)

              Console.WriteLine("Student {0} above average. Grade {1}", names[i], grades[i]);

          }

          Console.WriteLine("End");
   
        }
    }
}
