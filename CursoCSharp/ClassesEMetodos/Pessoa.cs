using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string nome;
        public int idade;

        public string Apresenta()
        {
            return string.Format($"Meu nome e {nome} e tenho {idade} anos de idade");
        }
    }
}
