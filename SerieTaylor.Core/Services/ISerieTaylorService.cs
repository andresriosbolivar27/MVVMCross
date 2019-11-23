using System;
using System.Collections.Generic;
using System.Text;

namespace SerieTaylor.Core.Services
{
    public interface ISerieTaylorService
    {
        double GetSerieTaylor(int numTerms, double x); 
    }
}
