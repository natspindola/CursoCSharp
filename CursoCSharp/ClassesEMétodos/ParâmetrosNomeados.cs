using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMétodos
{
    class ParâmetrosNomeados
    {
        public static void Formatar (int dia, int mês, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mês, ano);
        }
        public static void Executar ()
        {
            Formatar(mês: 1, dia: 6, ano: 1996);
        }
    }
}
