using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIF
    {
        public static void Executar ()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();

            if (entrada.ToLower () == "s") //qualquer entrada vai ser com letra minúscula
            bomComportamento = true;

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
            //Console.WriteLine(nota >= 9.0 && bomComportamento ? "Quadro de honra!" : ""); (Otimização linha 24-27)
        }
    }
}
