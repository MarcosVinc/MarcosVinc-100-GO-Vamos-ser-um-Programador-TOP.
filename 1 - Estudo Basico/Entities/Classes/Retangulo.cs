using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BasicoPOO.Entities.Classes
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double a = 0.0;
            return a = Largura * Altura;
        }
        public double Perimetro()
        {
            double p = 0.0;

            return p = (Altura + Altura) + (Largura + Largura);

        }
        public double Diagonal()
        {
            double d = 0.0;

            return d = Math.Sqrt((Largura * Largura) + (Altura * Altura));

        }

        public override string ToString()
        {
            return "Area = " + Area().ToString("F2", CultureInfo.InvariantCulture) + ", Perimetro = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + ", Diagonal = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
