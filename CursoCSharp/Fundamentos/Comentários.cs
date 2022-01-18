using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Comentários
    {
        /// <summary>
        /// XML Comments, pode usar TAGs. CTRL+SPACE para abrir comandos pré-salvos.
        /// </summary>
        public static void Executar()
        {
            //cuidado com os comentários desnecessários.
            //quanto menos comentários, mais limpo o código fica.
            Console.WriteLine("Código claro é sempre melhor!");

            /*Esse é um
             * comentário de 
             * multiplas linhas.
             */
            Console.WriteLine("o C# tem o XML Comments");
        }
    }
}
