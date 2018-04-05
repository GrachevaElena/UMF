using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMF
{
    class FunctionC01: Function
    {
        public override double Calc(double x)
        {
            if (x < 1) return x;
            return 2 - x;
        }

        public override double Calc(double x, int grUsl, int n)
        {
            return 0;
        }
    }
}
