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

         Console.WriteLine("Informe qtde alunos: ");

         amount = int.Parse(Console.ReadLine());

         names = new string[amount];
         grades = new double[amount];
         avg = 0;

         for(int i = 0; i < amount; i++){

           Console.WriteLine("Nome do aluno: ");
           names [i] = Console.ReadLine();
           Console.WriteLine("Nota do aluno: ");
           grades [i] = double.Parse(Console.ReadLine());

           avg = avg + grades[i];

         }

          avg = avg / amount;

          Console.WriteLine("Média: {0:N}", avg);

          for (int i = 0; i < amount; i++){

            if(grades[i]>= avg)

              Console.WriteLine("Aluno {0} acima da média. Nota {1}", names[i], grades[i]);

          }

          Console.WriteLine("Fim do programa");
   
        }
    }
}
