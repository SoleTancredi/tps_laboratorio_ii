using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        ///  Deberá validar que el operador recibido sea +, -, / o *. 
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>En caso contrario retornará +.</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                return '+';
            }
            return operador;
        }

        /// <summary>
        /// Validará y realizará la operación pedida entre ambos números.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Retornará el resultado de la operación.</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operador1 = ValidarOperador(operador);
            Double.TryParse(num1.Numero, out double result1);
            Double.TryParse(num2.Numero, out double result2);
            double resultadoFinal = 0;

            switch (operador1)
            {
                case '+':
                    resultadoFinal = result1 + result2;                
                    break;
                case '-':
                    resultadoFinal= result1 - result2;
                    break;
                case '/':
                    if(result2 == 0)
                    {
                        resultadoFinal = double.MinValue;
                    }
                    else
                    {
                        resultadoFinal = result1 / result2;
                    }
                    break;
                case '*':
                    resultadoFinal= result2 * result1;
                    break;
            }
            return resultadoFinal;
        }
    }
}
