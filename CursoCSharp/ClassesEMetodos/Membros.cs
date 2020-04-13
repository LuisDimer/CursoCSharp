using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa cicrano = new Pessoa();
            cicrano.idade = 20;
            cicrano.nome = "Cicrano";

            Console.WriteLine($"Meu nome e {cicrano.nome} e tenho {cicrano.idade} anos de idade");
        }
    }
}
