using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFunçoes
{
    delegate double Operaçao(double x, double y);

    class LambdasDelegate
    {
        public static void Executar ()
        {
            Operaçao sum = (x, y) => x + y;
            Operaçao sub = (x, y) => x - y;
            Operaçao mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(12, 8));
        }
    }
}
