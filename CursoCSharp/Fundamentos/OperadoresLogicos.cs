using System;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            // Operador binario dois valores executouTrabalho1 && executouTrabalho2, assim como var executouTrabalho2 = false
            // && = e, and
            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            // || = ou, or
            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            // ^ = xor exceto se for um ou outro
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            // ! = negacao
            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
