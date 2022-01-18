using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversões
    {
        public static void Executar ()
        {
            int inteiro = 10;
            double quebrado = inteiro; // converte implicitamente de int para double
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota; // converte explicitamente de double para int, mas perde a informação dos decimais
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString); // converte string para valor inteiro
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0} ", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); // tenta transformar uma palavra em número, não apresenta erro, apenas coloca 0
            Console.WriteLine("Resultado: {0}", numero1);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); // versão otimizada para transformar palavra em número
            Console.WriteLine("Resultado: {0}", numero2);
        }
    }
}
