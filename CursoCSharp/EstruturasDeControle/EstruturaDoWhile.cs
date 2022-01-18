using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar ()
        {
            string entrada;

            do // sempre executa pelo menos uma vez
            {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem vindo {0}!", entrada);
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();
            }

            while (entrada.ToLower() == "s"); // quantidade indeterminada de repetições

        }
    }
}
