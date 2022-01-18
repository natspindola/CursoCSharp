using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLógicos
    {
        public static void Executar ()
        {
            Console.WriteLine("Fez o trabalho 1? 1 para sim e 0 para não");
            var executouTrabalho1 = int.Parse(Console.ReadLine()) == 1 ? true : false;

            Console.WriteLine("Fez o trabalho 2? 1 para sim e 0 para não");
            var executouTrabalho2 = int.Parse(Console.ReadLine()) == 1 ? true : false;


            var comprouTv50 = executouTrabalho1 && executouTrabalho2; //precisa acontecer os dois (e)
            Console.WriteLine("Comprou a TV de 50 polegadas? {0}", comprouTv50);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; //tem que acontecer 1 ou 2 (não)
            Console.WriteLine("Comprou a TV de 32 polegadas? {0}", comprouTv32);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; //se acontecer 1 ou os 2 (ou)
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);
            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);

            // operador binário precisa de dois operandos, operador unário precisa de um operando
        }
    }
}
