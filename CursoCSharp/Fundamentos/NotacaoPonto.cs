using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            // ToUpper() tem parenteses porque e uma funcao
            var saudacoes = "Ola".ToUpper().Insert(3, "World!").Replace("World!", "Mundo");
            Console.WriteLine(saudacoes);

            // Nesse caso Lenght nao tem parenteses porque e um valor
            Console.WriteLine("Teste".Length);

            string valorImportante = null;

            // valorImportante.Lenght nesse caso daria um erro nao tem como saber o Lenght de uma variavel null portanto e colocado ? que significa que so ira executar o .Lenght caso seja possivel senao ele e ignorado
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
