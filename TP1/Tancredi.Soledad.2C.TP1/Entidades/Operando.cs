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

        /// <summary>
        /// Constructor por defecto que inicializa en 0 el atributo numero
        /// </summary>
        public Operando()
        {
            numero = 0;
        }

        /// <summary>
        /// Método que valida si lo ingresado por el usuario es un número
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns> si es un numero de tipo double, retornará el mismo.
        /// De lo contrario retornará 0.</returns> 
        private double ValidarOperando(string strNumero)
        {
            if(!Double.TryParse(strNumero, out double result))
            {
                return 0;
            }

            return result;
      
        }

        /// <summary>
        /// Propiedad que asigna un valor al atributo numero, de forma segura.
        /// </summary>
        public string Numero
        {
            set 
            {
                double retornoValidador = ValidarOperando(value);

                if (retornoValidador != 0)
                {
                    this.numero = retornoValidador;
                }
                
            } 
        }

        /// <summary>
        /// Comprueba que la cadena de caracteres este compuesta solo por '0' o '1'
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            foreach(char c in binario)
            {
                if(c != '0' && c != '1')
                {
                    return false;
                }
            }

            return true;    
        }

        /// <summary>
        /// validará que se trate de un binario
        /// y luego convertirá ese número binario a decimal, 
        /// en caso de ser posible.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> Retornará el decimal en tipo string.
        /// Caso contrario retornará "Valor inválido".</returns>
        public string BinarioDecimal(string binario)
        {
            if(!EsBinario(binario))
            {
                return "Valor Inválido";
            }

            int len = binario.Length;
            double resultado;
            double acumulaResultado = 0;

            foreach (char c in binario)
            {
                int elementoBinario = ((byte)c) - 48;
                resultado = elementoBinario * Math.Pow(2, len - 1);
                acumulaResultado += resultado;
                len--;
            }

            return acumulaResultado.ToString(); 
        }

        /// <summary>
        /// Convertirán un número decimal a binario, en caso de ser posible.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retornará el binario en tipo string.
        /// De lo contrario "Valor inválido"</returns>
        public string DecimalBinario(double numero)
        {
            if (numero < 0)
            {
                return "Valor Inválido";
            }

            StringBuilder strBinario = new StringBuilder();
            int modulo;

            do
            {
                int resultado = (int)numero / 2;
                modulo = (int)numero % 2;
                numero = resultado;
                strBinario.Insert(0, modulo);
            }
            while (numero > 0);

            return strBinario.ToString();
        }

        /// <summary>
        /// Convertirán un número decimal a binario, en caso de ser posible.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retornará el binario en tipo string.
        /// De lo contrario "Valor inválido".</returns>
        public string DecimalBinario(string numero)
        {
            double numeroDecimal = ValidarOperando(numero);

            if(numeroDecimal == 0)
            {
                return "Valor inválido";
            }

            return DecimalBinario(numeroDecimal);
        }

        /// <summary>
        /// Sobrecarga del operador +, con parametros de tipo Operando.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador -, con parametros de tipo Operando.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador /, con parametros de tipo Operando.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>En caso de que el segundo parámetro sea 0, retornará el 
        /// valor minimo del tipo double.</returns>
        public static double operator /(Operando num1, Operando num2)
        {
            if(num2.numero == 0)
            {
                return double.MinValue;
            }
            return num1.numero / num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador *, con parametros de tipo Operando.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador ==, con parámetros del tipo Operando.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static bool operator ==(Operando num1, Operando num2)
        {
            return (num1.numero == num2.numero);    
        }

        /// <summary>
        /// Sobrecarga del operador !=, con parámetros del tipo Operando.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static bool operator !=(Operando num1, Operando num2)
        {
            return !(num1 == num2);
        }

        







    }
}
