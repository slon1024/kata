using System;
using RomanNumerals.Engine;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {

            var first  = "DCCCLXXXVIII";
            var second = "DCCCLXXXI";

            var calculator = new Calculator(new SimpleEngine());
            Console.WriteLine(String.Format("{0} + {1} = {2}{3}", first, second, calculator.Add(first, second), Environment.NewLine));

            
            Console.WriteLine("Please press any key");
            Console.ReadKey();
        }
    }
}
