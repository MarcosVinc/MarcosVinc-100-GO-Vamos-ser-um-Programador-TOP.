using System;
using System.Collections.Generic;
using System.Text;

namespace BasicoPOO.Entities.Classes
{
    class BeneditoEscola
    {
        public string NOME;
        public double NOTAPRIMEIROTREMESTRE;
        public double NOTASEGUNGOTREMESTRE;
        public double NOTATERCEIROTREMESTRE;

        public double NotaFinal()
        {
            double media = NOTAPRIMEIROTREMESTRE + NOTASEGUNGOTREMESTRE + NOTATERCEIROTREMESTRE;
            return media;
        }
    }
}
