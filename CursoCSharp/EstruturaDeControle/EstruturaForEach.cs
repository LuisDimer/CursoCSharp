using System;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            string palavra = "Ola";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[]{"Ana", "Maria", "Tiago"};

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            
        }
    }
}