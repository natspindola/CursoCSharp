using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMétodos
{
    public class Produto
    {
        public string Nome;
        public double Preço;
        public static double Desconto = 0.1;

        public Produto(string nome, double preço, double desconto)
        {
            Nome = nome;
            Preço = preço;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preço - Preço * Desconto;
        }
    }
    class AtributosEstáticos
    {
        public static void Executar ()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto
            {
                Nome = "borracha",
                Preço = 5.3,
            };

            Produto.Desconto = 0.5; //o mesmo valor para todos, porque é estático
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02; //o mesmo valor para todos, porque é estático
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}
