using System;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int tentativasRestantes = 5;
            int tentativas = 0;
            bool numeroEncontrado = false; ;
            Random random = new Random();
            int numeroSorteado = random.Next(1, 11);
            Console.WriteLine("Numero sorteado de 1 a 10");

            while(tentativasRestantes > 0 && !numeroEncontrado)
            {
                tentativasRestantes--;
                tentativas++;
                Console.Write("Chute um numero: ");
                int.TryParse(Console.ReadLine(), out int chute);

                if(chute == numeroSorteado)
                {
                    numeroEncontrado = true;
                    Console.WriteLine($"Parabens voce acertou na tentativa {tentativas}");
                } else if(chute < numeroSorteado)
                {
                    Console.WriteLine("Numero sorteado e maior");
                } else if(chute > numeroSorteado)
                {
                    Console.WriteLine("Numero sorteado e menor");
                }

            }
        }
    }
}
