using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            numero = 0;
        }

        private double ValidarOperando(string strNumero)
        {
            if (strNumero.All(char.IsDigit))
            {
                return numero;
            }
            else
            {
                return 0;
            }
        }

    }
}
