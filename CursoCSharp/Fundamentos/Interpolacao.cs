using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook";
            string marca = "DELL";
            double preco = 5800.00;

            // Nao e a forma mais eficiente 
            Console.WriteLine("O " + nome + " da marca " + marca + " custa R$" + preco);

            Console.WriteLine("O {0} da marca {1} custa R${2}", nome, marca, preco);

            // Forma mais eficiente de concatenar strings
            Console.WriteLine($"O {nome} da marca {marca} custa R${preco}.");

            Console.WriteLine($"1 + 1 = {1 + 1}");
        }
    }
}

