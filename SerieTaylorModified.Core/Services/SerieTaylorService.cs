using System;
using System.Collections.Generic;
using System.Text;

namespace SerieTaylorModified.Core.Services
{
    public class SerieTaylorModifiedService : ISerieTaylorModifiedService
    {
        public double GetSerieTaylorModified(int numTerms, double x)
        {
            double taylor, sumatoria = 0;
            int signo = 1;
            for (int i = 0; i < numTerms; i++)
            {                
                taylor = (Math.Pow(x, i) / (GetFactorial(i)))*signo;
                signo *= -1;
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
