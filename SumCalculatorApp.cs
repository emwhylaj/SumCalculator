using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumCalculator_LiskovSubstitution
{
    public class SumCalculatorApp: Calculator
    {
        public SumCalculatorApp(int [] numbers)
            :base(numbers)
        {
           
        }
        public override int Calculate() => _numbers.Sum();
    }
}
