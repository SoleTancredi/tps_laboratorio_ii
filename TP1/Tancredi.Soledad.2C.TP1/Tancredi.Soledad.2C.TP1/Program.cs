using System;
using System.Text;
using System.Linq;
using Entidades;


namespace Tancredi.Soledad._2C.TP1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operando op = new Operando();

            op.Numero = "10300";

            Console.WriteLine(op.Numero);

            Console.WriteLine(op.BinarioDecimal("11111111111011111110"));// deberia ret 1048318
            Console.WriteLine(op.BinarioDecimal("1115200"));// deberia ret false
            Console.WriteLine(op.BinarioDecimal("111LKDSAd"));// deberia ret false


        }

    }

   
}
