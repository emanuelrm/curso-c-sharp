using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // uma casa decimal
            Console.WriteLine(valor.ToString("C"));  // valor monetário
            Console.WriteLine(valor.ToString("P"));  // valor percentual
            Console.WriteLine(valor.ToString("#.##")); // tipo de formatação mais específico 

            CultureInfo cultura = new CultureInfo("pt-br");
            Console.WriteLine(valor.ToString("C0"), cultura); // tipo de formatação para uma cultura específica

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // completar 0 a esquerda de um número
        }
    }
}
