using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;

            // Const sao fixas, ou seja, nao podem ser alteradas
            const double PI = 3.14;

            // Como pode ser observado, valor da variavel raio foi alterado no decorrer do codigo
            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("A arede e " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("bool esta chovendo " + estaChovendo);

            byte idade = byte.MaxValue; ;
            Console.WriteLine("byte " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("MinValue sbyte " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("MaxValue short " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("uint " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço Computador float " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais!
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
