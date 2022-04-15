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
            Operando op1 = new Operando();
            Operando op2 = new Operando();
            Operando op3 = new Operando();
            Operando op4 = new Operando();

            Console.WriteLine(op.BinarioDecimal("11111111111011111110"));// deberia ret 1048318
            Console.WriteLine(op.BinarioDecimal("1115200"));// deberia ret false
            Console.WriteLine(op.BinarioDecimal("111LKDSAd"));// deberia ret false

            op1.Numero = "10";
            op2.Numero = "2";
            op3.Numero = "9l";
            op4.Numero = "0";

            Console.WriteLine(Calculadora.Operar(op1, op2, 's')); // 12
            Console.WriteLine(Calculadora.Operar(op1, op2, '.'));//12
            Console.WriteLine(Calculadora.Operar(op1, op2, '+'));//12
            Console.WriteLine(Calculadora.Operar(op1, op2, '-'));//8
            Console.WriteLine(Calculadora.Operar(op1, op2, '/'));//5
            Console.WriteLine(Calculadora.Operar(op1, op2, '*'));//20

            Console.WriteLine(Calculadora.Operar(op1, op3, '+'));//10
            Console.WriteLine(Calculadora.Operar(op1, op4, '/'));//double.Min

            Console.WriteLine(op.BinarioDecimal("010111010"));//186
            Console.WriteLine(op.BinarioDecimal("11.20101,101"));//valor invalido
            Console.WriteLine(op.DecimalBinario("48"));//110000
            Console.WriteLine(op1.DecimalBinario("1,25"));//1
            Console.WriteLine(op.DecimalBinario(48));//110000
            Console.WriteLine(op.DecimalBinario(1.25));//1
            Console.WriteLine(op.DecimalBinario("-25"));//valor invalido
            

               

        }

      
    }

   
}
