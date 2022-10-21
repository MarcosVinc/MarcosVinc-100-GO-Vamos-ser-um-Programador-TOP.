using System;
using System.Collections.Generic;
using System.Text;

namespace BasicoPOO.Entities.Classes
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }

        /* public double CalcularArea(double La, double Lb, double Lc) 
          {
              A = La;
              B = Lb;
              C = Lc;

          }*/
    }
}
