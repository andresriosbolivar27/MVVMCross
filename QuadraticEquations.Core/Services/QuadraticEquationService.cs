using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public class QuadraticEquationService: IQuadraticEquationService
    {
        
        public void GetQuadraticEquation(double a, double b, double c, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }
    }
}
