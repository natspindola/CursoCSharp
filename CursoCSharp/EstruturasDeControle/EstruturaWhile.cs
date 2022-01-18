using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar ()
        {
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int palpite;
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor; //muda a cor da marcação de texto
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("Número encontrado em {0} tentativas.", tentativas);
                    Console.BackgroundColor = corAnterior; //volta a cor original da marcação
                }

                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente.");
                    Console.WriteLine("Tentativas restantetes: {0}.", tentativasRestantes);
                }

                else
                {
                    Console.WriteLine("Maior... Tente novamente.");
                    Console.WriteLine("Tentativas restantetes: {0}.", tentativasRestantes);
                }
            }
        }
    }
}
