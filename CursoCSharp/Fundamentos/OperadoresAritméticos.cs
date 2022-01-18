using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritméticos
    {
        public static void Executar ()
        {
            // preço com desconto
            var preço = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preço + imposto; // soma
            var totalComDesconto = total - (total * desconto); // subtração e multiplicação
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            // IMC
            double peso = 57.2;
            double altura = 1.57;
            double IMC = peso / Math.Pow(altura, 2); // potência
            Console.WriteLine("O seu imc é {0}", IMC);

            // número par/impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par %2); // operador módulo
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
