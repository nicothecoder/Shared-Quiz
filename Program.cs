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
            // This part tells you if you are a higher priority based on your age
            Console.WriteLine($"You are {age} years old");
            // Young person
            if (age < 17)
            {
                Console.WriteLine("You are a low priority for the coronavirus vaccine.");
            }
            // Person aged over 17
            else if (age >= 17) 
            {
                if (age < 60)
                {
                    Console.WriteLine("You are a lower priority for the coronavirus vaccine.");
                }
                else
                {
                    Console.WriteLine("You are a higher priority for the coronavirus vaccine.");
                }
            }
            //New project
            Console.WriteLine("How much do you tax each citizen?");
            double taxValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many citizens are in your country?");
            double citizens = Convert.ToInt32(Console.ReadLine());
            double earnings = taxValue * citizens;
            Console.WriteLine($"You are earning {earnings}");
            // Cost of buying something + tax
            Console.WriteLine("How much does the product cost that you are buying?");
            double productCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much is the tax in your country, percentage wise?");
            double buyTax = Convert.ToInt32(Console.ReadLine());
            double taxTotal = productCost  *  buyTax  /  100;
            Console.WriteLine($"The tax you will pay on top of the original price is {taxTotal}.");
            double productTotal = taxTotal + productCost;
            Console.WriteLine($"The total price of the product is now {productTotal}");

            
        }
    }
}