using System;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            // Nessa estrutura de Repeticao pelo menos uma vez esse codigo sera executado
            do
            {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja continuar?(S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
