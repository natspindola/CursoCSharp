using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMétodos
{
    class ParâmetrosPorReferência
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut (out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }

        public static void Executar ()
        {
            int a = 3; //soma com o valor original = recebe o dado e gera saída
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b = 2; essa linha se torna inútil, quando usa o OUT ele apenas replica o valor original,
            AlterarOut(out int b, out int c); //não passa dados, apenas gera saída.
            Console.WriteLine($"{b} e {c}.");
        }
    }
}
