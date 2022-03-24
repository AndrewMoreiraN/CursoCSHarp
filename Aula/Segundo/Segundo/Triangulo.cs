using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo
{
    public class Triangulo
    {
        public double a;
        public double b;
        public double c;

        public double CalculateArea()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}