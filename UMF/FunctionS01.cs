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
            double s = 0;
            switch (grUsl)
            {
                case 1:
                    for (int i = 1; i < n; i++)
                        s += -2.0 * (1 - Math.Pow(-1, i+1)) / (Math.PI * i) * Math.Sin(Math.PI * i * x / 2);
                    return s;
                case 2:
                    for (int i = 1; i < n; i++)
                        s += -4.0 * (1 - Math.Pow(-1, i)) / (Math.PI * Math.PI * i * i) * Math.Cos(Math.PI * i * x / 2);
                    return s;
                case 3:
                    for (int i = 1; i < n; i++)
                    {
                        double sqrtLambda = FindSqrtLambda(i);
                        double ck = -3.0 / sqrtLambda * Math.Cos(sqrtLambda) + 1 / sqrtLambda * Math.Cos(2 * sqrtLambda) + 2 / (sqrtLambda * sqrtLambda) * Math.Sin(sqrtLambda) - 1 / (sqrtLambda * sqrtLambda) * Math.Sin(2 * sqrtLambda);
                        s += ck * (Math.Sin(sqrtLambda * x)+sqrtLambda*Math.Cos(sqrtLambda * x));
                    }
                    return s;
                default: return 0;
            }
        }
    }
}
