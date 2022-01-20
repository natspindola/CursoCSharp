using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoPróximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoPróximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
}
