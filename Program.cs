using System;

namespace SumCalculator_LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            Calculator sum = new SumCalculatorApp(numbers);
            Console.WriteLine($"The sum of the number: {sum.Calculate()}");

            Console.WriteLine();

            Calculator evenSum = new EvenNumbersSumcalculator(numbers);
            Console.WriteLine($"The sum of the even numbers: {evenSum.Calculate()}");

            Console.ReadLine();
        }
    }
}
