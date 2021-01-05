using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumCalculator_LiskovSubstitution
{
    class EvenNumbersSumcalculator: Calculator
    {
        public EvenNumbersSumcalculator(int[] numbers) : base(numbers)
        {

        }
        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
