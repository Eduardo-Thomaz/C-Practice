using System;

namespace C_Tests
{
    class Program
    { 
        static void Main(string[] args)
        {
          Console.WriteLine("What's your name?");
           string name = Console.ReadLine();
           Console.WriteLine($"Hello {name}");
           Welcome(name);
        }
        static void Welcome(string user)
        {
            if(DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine($"Good day {user}!");
            }
            else
            {
                Console.WriteLine($"Good night {user}!");
            }
        }
    }
} 
