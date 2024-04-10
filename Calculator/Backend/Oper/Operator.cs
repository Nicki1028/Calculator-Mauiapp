using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Backend.Oper
{
    internal abstract class Operator
    {
        public double Num1;
        public double Num2;
        protected Operator(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public abstract double Calc();
    }
}
