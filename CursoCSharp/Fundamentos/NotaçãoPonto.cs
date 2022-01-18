using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotaçãoPonto
    {
        public static void Executar ()
        {
            var saudação = "olá".ToUpper().Insert(3, " world").Replace(" world", " mundo!");
            Console.WriteLine(saudação);

            // O ponto (.) permite acessar funcionalidades do sistema.

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            // O simbolo (?) só permite a leitura caso tenha um valor definido, se for nulo, não aparece e não gera erro.
        }
    }
}
