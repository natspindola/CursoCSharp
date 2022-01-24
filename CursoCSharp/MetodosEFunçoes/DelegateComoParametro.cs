using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFunçoes
{
    class DelegateComoParametro
    {
        public delegate int Operaçao(int x, int y);

        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static string Calculadora(Operaçao op, int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado: " + resultado;

        }

        public static void Executar ()
        {
            Operaçao subtraçao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtraçao, 3, 2));

            Console.WriteLine(Calculadora(Soma, 3, 2));
        }
    }
}
