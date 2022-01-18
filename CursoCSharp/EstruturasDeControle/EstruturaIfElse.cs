using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar ()
        {
            string entrada;
            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            //  double nota = 7.0; (se quiser mudar a nota no código)

            if (nota >= 7.0) //se a nota for igual ou maior que 7, executa esse
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Você não fez mais que a sua obrigação...");
            }

            else //se a nota for menor que 7, executa esse
            {
                Console.WriteLine("Recuperação");
                Console.WriteLine("Você precisa estudar mais...");
            }
        }
    }
}
