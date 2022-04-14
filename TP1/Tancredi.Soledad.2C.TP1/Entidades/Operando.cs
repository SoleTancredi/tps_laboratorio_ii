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
            if (Double.TryParse(strNumero, out double resul) == true)
            {       
                return resul;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Propiedad que muestra o asigna un valor al atributo numero, de forma segura.
        /// </summary>
        public string Numero
        {
            get
            { 
                return this.numero.ToString();
            }
            set 
            {
                double retornoValidador = ValidarOperando(value);

                if (retornoValidador != 0)
                {
                    this.numero = retornoValidador;
                }
                
            } 
        }

  

        

        

    }
}
