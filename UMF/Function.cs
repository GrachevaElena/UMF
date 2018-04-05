using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMF
{
    public abstract class Function
    {
        const double beta = 1;

        abstract public double Calc(double x);
        abstract public double Calc(double x, int grUsl, int n);

        public double Fi(double x, int k)
        {
            return 0.5 * Math.Atan(-x / beta) + Math.PI * k;
        }

        public double FindSqrtLambda(int k)
        {
            int N = 20;
            double l = Math.PI;
            double x = k * l;
            for (int i = 0; i < N; i++)
            {
                x = Fi(x, k);
            }
            return x;
        }
    }
}
