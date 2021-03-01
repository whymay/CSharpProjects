using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;

            Console.WriteLine("Write the first number");

            number1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Write the second number");
            
            number2 = Convert.ToDouble(Console.ReadLine());
            
            double result = (number1 + number2) / 2;
            
            Console.WriteLine(result);
            
            Console.ReadLine();
        }
    }
}
