using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Backend.Oper
{
    internal class Add : Operator
    {
        private double result;
        public Add(double Num1, double Num2) : base(Num1, Num2)
        {
        }

        public override double Calc()
        {
            return result = Num1 + Num2;
        }
    }
}
