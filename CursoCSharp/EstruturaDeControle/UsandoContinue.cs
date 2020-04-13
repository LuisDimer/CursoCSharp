using System;

namespace CursoCSharp.EstruturaDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue; // Nesse caso com o 'continue' ele volta a execucao do for e faz o processo novamente
                }

                Console.Write(i + " ");
            }
        }
    }
}