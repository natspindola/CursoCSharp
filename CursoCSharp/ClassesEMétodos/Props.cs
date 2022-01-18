using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMétodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return ("Opcional: " + nome);
            }

            set
            {
                nome = value;
            }
        }

        //propriedade autoimplementada
        public double Preço { get; set; }

        //somente leitura
        public double PreçoComDesconto
        {
            //get => Preço - (desconto * Preço); //lambda
            get
            {
                return Preço - (desconto * Preço);
            }
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preço)
        {
            Nome = nome;
            Preço = preço;
        }
    }

    class Props
    {
        public static void Executar ()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PreçoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção eletrica";
            op2.Preço = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preço);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preço);
            Console.WriteLine(op2.PreçoComDesconto);
        }
    }
}
