using System;
using System.Collections.Generic;
using System.Text;

namespace SerieTaylorModified.Core.Services
{
    public interface ISerieTaylorModifiedService
    {
        double GetSerieTaylorModified(int numTerms, double x); 
    }
}
