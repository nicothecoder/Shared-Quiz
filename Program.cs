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
            // This part will tell the user their age in a string
            Console.WriteLine("How old are you?");
            double age = Convert.ToInt32(Console.ReadLine());
            // This part tells you if you can drive based on your age
            Console.WriteLine($"You are {age} years old");
            // Young person
            if (age < 17)
            {
                Console.WriteLine("You are not allowed to drive!");
            }
            // Person aged 17
            else if (age == 17) 
            {
                Console.WriteLine("Well done! You are now allowed to drive!");
            }
            // Person aged over 17
            else
            {
                Console.WriteLine("You are allowed to drive!");
            }
            Console.WriteLine("");
            if
            {

            }
        }
    }
}
