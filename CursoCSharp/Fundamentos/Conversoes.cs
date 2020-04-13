using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            // Nesse caso seria possivel atribuir um valor int em um double sem perda de info e sem precisar deixar explicita, double e maior que int
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            // Nesse caso tera perda de info valores nas casas decimais, portanto e preciso fazer a conversao de forma explicita nesse caso  o cache
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInt = int.Parse(idadeString);

            Console.WriteLine($"Idade inserida: {idadeInt}");

            // Outra forma de converter string para int
            int idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            // Caso o usuario coloque palavras em vez de numero vai resultar em um erro, dessa forma caso isso acontecer o int vai ser 0
            Console.WriteLine("Digite a sua idade: ");
            string palavra = Console.ReadLine();
            int numero;
            // Nesse caso ele vai tentar converter e colocar o qe tem em palavra para numero se estiver uma letra ele vai deixar como 0.
            int.TryParse(palavra, out numero);

            // Outra forma mais simplificada 
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
