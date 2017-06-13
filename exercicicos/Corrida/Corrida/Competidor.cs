using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrida
{
    class Competidor
    {
        public string nome;
        public double t1, t2, t3;

        public double CalcularTempo()
        {
            double[] tempooficial = new double[3] { t1, t2, t3 };

            Array.Sort(tempooficial);
            double conta = tempooficial[0] + tempooficial[1];

            return conta;
        }
    }
}
