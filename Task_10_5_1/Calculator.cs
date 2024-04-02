using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_5_1
{
    internal class Calculator : ICalcSum
    {
        public double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
