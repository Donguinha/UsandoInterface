using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoInterface.Services
{
    internal class Multiplicar : IOperacao
    {
        public double Operacao(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
    }
}
