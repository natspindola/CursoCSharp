using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolação
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preço = 5600.00;
            Console.WriteLine("Vendo um " + nome + " da marca " + marca + " no valor de " + preço + " reais.");
            Console.WriteLine("Vendo um {0} da marca {1} no valor de {2} reais.", nome, marca, preço);
            Console.WriteLine($"Vendo um {nome} da marca {marca} no valor de {preço} reais.");
            Console.WriteLine($"1+1 = {1+1}");

            // Formas mais simples e mais limpas para fazer a concatenação.
            // o texto dentro das chaves é substituido para gerar o resultado.
        }
    }
}