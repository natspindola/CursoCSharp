﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFunçoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }

        public static int Subtraçao(this int num, int outroNumero)
        {
            return num + outroNumero;
        }
    }

    class MetodoDeExtençao
    {
        public static void Executar ()
        {
            int numero = 5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Subtraçao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.Subtraçao(4));
        }
    }
}
