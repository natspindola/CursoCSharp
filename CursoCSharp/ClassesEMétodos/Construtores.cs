using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMétodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) //construtor criado para o carro2
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() //permite o carro1 usar o construtor padrão
        {

        }
    }

    class Construtores
    {
        public static void Executar ()
        {
            var carro1 = new Carro(); //construtor padrão
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2010); //construtor criado na clase Carro
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro() //outra forma para usar o construtor padrão
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
