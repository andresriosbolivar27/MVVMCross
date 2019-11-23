using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public interface IQuadraticEquationService
    {
        void GetQuadraticEquation(double a, double b, double c, out double x1, out double x2);
    }
}
