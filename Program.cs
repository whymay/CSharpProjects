using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;

            Console.WriteLine("Write the first number");
            
            a = int.Parse(Console.ReadLine());

            b = a % 2;

            if (b == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number isn't even");
            }

        }
    }
}
