using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar ()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Qual é o seu salário? ");
            double salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome}, { idade}, R${ salário}");

            // Usar "douple.Parse" permite separar os decimais conforme o sistema operante (ponto ou vírgula)
            // o "CultureInfo" permite que o ponto (.) seja sempre usado para separar casas decimais
        }
    }
}
