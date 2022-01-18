using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferência
    {
        public static void Executar ()
        {
            var nome = "Natália";
            // nome = 123;
            Console.WriteLine(nome);

            var idade = "25";
            /*int idade;
            idade = 25;*/
            Console.WriteLine(idade);

            int a;
                a = 3;
            int b = 2;
            Console.WriteLine(a + b);

            // A Inferência de tipo permite que você deixe o compilador decidir qual o tipo de uma variável local.
            // Se iniciar com "var" é obrigado iniciar a variável na mesma linha.
        }
    }
}
