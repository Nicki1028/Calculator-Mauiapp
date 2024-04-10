using Calculator.Backend.Oper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Backend
{
    internal class OperatorFactory
    {
        public Operator operresult(string oper, double num1, double num2)
        {
            Operator op = null;
            switch (oper)
            {
                case "+":
                    op = new Add(num1, num2);
                    break;
                case "-":
                    op = new Minus(num1, num2);
                    break;
                case "*":
                    op = new Mutiply(num1, num2);
                    break;
                case "/":
                    op = new Division(num1, num2);
                    break;
            }
            return op;

        }

    }
}
