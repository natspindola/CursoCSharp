using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Coleçoes
{
    class ColeçoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Pôster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho)
            {
                Console.WriteLine($" {item.Nome} {item.Preço}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
        }
    }
}
