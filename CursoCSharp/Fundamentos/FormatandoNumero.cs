using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            
            // Formatacoes numericas //


            Console.WriteLine(valor.ToString("F1"));

            // moeda local config PC 
            Console.WriteLine(valor.ToString("C"));

            // Porcentagem
            Console.WriteLine(valor.ToString("P"));

            // Mantem as casas
            Console.WriteLine(valor.ToString("#.##"));

            // variavel cultura do tipo CulturaInfo(class) recebe CulturaInfo dos EUA
            CultureInfo cultura = new CultureInfo("en-US");
            //C moeda + cultura = padra americano , 0 sem casa decimal.
            Console.WriteLine(valor.ToString("C0", cultura));
        }
    }
}
