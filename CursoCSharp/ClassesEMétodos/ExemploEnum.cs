using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMétodos
{
    public enum Genero {Acao, Animacao, Aventura, Comedia, Terror}; // 0, 1, 2, 3, 4

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;

    }


    class ExemploEnum
    {
        public static void Executar ()
        {
            int id = (int)Genero.Animacao; //0, 1
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;
            Console.WriteLine("{0} é {1}.", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}
