using System;
using System.Collections.Generic;
using System.Text;

namespace SerieTaylor.Core.Services
{
    public class SerieTaylorService : ISerieTaylorService
    {
        public double GetSerieTaylor(int numTerms, double x)
        {
            double taylor, sumatoria = 0;
            for (int i = 0; i < numTerms; i++)
            {                
                taylor = (Math.Pow(x, i) / (GetFactorial(i)));
                sumatoria += taylor;
            }
            return sumatoria;
        }

        public double GetFactorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * GetFactorial(n - 1);
        }
    }
}
