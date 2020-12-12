using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string input = Console.ReadLine();
            Console.WriteLine($"Hello {input}!");
            /* This part will tell the user their age in a string */
            Console.WriteLine("How old are you?");
            double age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You are {age} years old");
            if (age < 17) 
            {
                Console.WriteLine("You are not allowed to drive");
            }
            else;
            {
                Console.WriteLine("");
            }
            Console.WriteLine("Next Part....");
            Console.WriteLine("Next.");
        }
    }
}
