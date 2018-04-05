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
            double s = 0;
            switch (grUsl)
            {
                case 1:
                    for (int i = 1; i < n; i++)
                        s += 4.0 / (Math.PI * Math.PI*(2*i-1)*(2*i-1))*(Math.Pow(-1, i+1)) * Math.Sin(Math.PI * (2*i-1) * x / 2);
                    return s;
                case 2:
                    for (int i = 1; i < n; i++)
                        s += -(1-Math.Pow(-1, i))/(i*i*Math.PI*Math.PI) * Math.Cos(Math.PI * i * x );
                    return s;
                case 3:
                    for (int i = 1; i < n; i++)
                    {
                        double sqrtLambda = FindSqrtLambda(i);
                        double ck = -2.0 / sqrtLambda + (1+1/sqrtLambda)*Math.Sin(2*sqrtLambda);
                        s += ck * (Math.Sin(sqrtLambda * x) + sqrtLambda * Math.Cos(sqrtLambda * x));
                    }
                    return s;
                default: return 0;
            }
        }
    }
}
