using System;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Number!");
            string input = Console.ReadLine();
            float number = float.Parse(input);
            if(number / 2 == 0)
            {
                Console.WriteLine("The number is Integer.");
            }
            else
            {
                Console.WriteLine("The number is not Integer.");
            }
        }
    }
}