using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFunçoes
{
    class DelegateFunAnonima
    {
        delegate string StringOperaçao(string s);

        public static void Executar ()
        {
            StringOperaçao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# é show!!!"));
        }
    }
}
