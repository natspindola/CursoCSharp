using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnários
    {
        public static void Executar ()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // inverte os sinais + e -
            Console.WriteLine(!booleano); // inverte positivo e negativo

            numero1++; // acrescenta 1 (operador pós-fixado) 
            Console.WriteLine(numero1);

            --numero1; // diminui 1 (operador pré-fixado)
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
