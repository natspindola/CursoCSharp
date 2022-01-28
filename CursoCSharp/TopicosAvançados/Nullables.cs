﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvançados
{
    class Nullables
    {
        public static void Executar ()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("Valor do num: {0}");
            } 
            
            else
            {
                Console.WriteLine("A variável não possui valor");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
