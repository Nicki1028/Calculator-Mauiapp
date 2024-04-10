using Calculator.Backend.Oper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Backend
{
    internal class Calculate
    {
        private Double _num1 = 0;
        private Double _num2 = 0;

        //型別轉換(get/set()
        public string Num1
        {
            get => _num1.ToString();
            set
            {
                _num1 = Double.Parse(value);
            }

        }
        public string Num2
        {
            get => _num2.ToString();
            set
            {
                _num2 = Double.Parse(value);
            }

        }
        public string Oper
        { get; set; }

        public string Cal()
        {
            OperatorFactory of = new OperatorFactory();
            Operator op = of.operresult(Oper, _num1, _num2);
            return op.Calc().ToString();
        }
    }
}
