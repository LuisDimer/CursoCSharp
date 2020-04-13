using System;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            int tamanhoTurma = 0;
            double somatorio = 0;

            Console.Write("Informe a quantidade de alunos da turma: ");
            int.TryParse(Console.ReadLine(), out tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.Write("Informe a nota do aluno: ");
                double.TryParse(Console.ReadLine(), out double notaAluno);
                somatorio += notaAluno;
                Console.WriteLine(somatorio);
            }

            double media = somatorio == 0 ? media = 0 : somatorio / tamanhoTurma;
            Console.WriteLine($"A media da turma e {media}");
        }
    }
}