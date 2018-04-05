using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMF
{
    class FunctionD01 : Function
    {
        public override double Calc(double x)
        {
            if (x < 1) return 1;
            return -1;
        }

        public override double Calc(double x, int grUsl, int n)
        {
            double s = 0;
            switch (grUsl)
            {
                case 1:
                    for (int i = 0; i < n; i++)
                        s += 4.0 / (2 * i + 1) / Math.PI * Math.Sin(Math.PI * (2 * i + 1) * x);
                    return s;
                case 2:
                    for (int i = 1; i < n; i++)
                        s += 4.0 / (Math.PI * (2 * i - 1)) * Math.Cos(Math.PI * (2 * i - 1) * x/2) * Math.Pow(-1, i+1);
                    return s;
                case 3:
                    for (int i = 1; i < n; i++) {
                        double sqrtLambda = FindSqrtLambda(i);
                        s += (1 + Math.Cos(2 * sqrtLambda) - 2 * Math.Cos(sqrtLambda)) * Math.Sin(sqrtLambda * x) / Math.Sqrt(1 - Math.Sin(sqrtLambda * 4) / 4 / sqrtLambda);
                    }
                        return s;
                default: return 0;
            }

        }
    }
}
