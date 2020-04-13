using System;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            // if se tal condicao for verdadeira executa, caso CONTRARIO executa sentenca/bloco de else
            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
