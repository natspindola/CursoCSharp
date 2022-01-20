using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        public string InfoPublica = "Tenho um instagram!";

        protected string CorDoOlho = "Verde";

        internal ulong NumeroCelular = +5561981377000;

        protected internal string JeitoDeFalar = "Uso muitas gírias.";

        private protected string SegredoDeFamilia = "Bla bla bla";

        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
