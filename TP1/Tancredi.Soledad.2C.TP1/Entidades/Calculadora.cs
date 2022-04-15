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
            double resultadoFinal = 0;

            switch (operador1)
            {
                case '+':
                    resultadoFinal = num1 + num2;            
                    break;
                case '-':
                    resultadoFinal = num1 - num2;
                    break;
                case '/':
                    resultadoFinal = num1 / num2;
                    break;
                case '*':
                    resultadoFinal= num1 * num2;
                    break;
            }
            return resultadoFinal;
        }
    }
}
