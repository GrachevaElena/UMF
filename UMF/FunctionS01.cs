using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMF
{
    class FunctionS01 : Function
    {
        public override double Calc(double x)
        {
            return x - 1;
        }

        public override double Calc(double x, int grUsl, int n)
        {
            return 0;
        }
    }
}
