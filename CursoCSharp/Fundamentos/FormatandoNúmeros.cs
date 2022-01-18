using System;
using System.Globalization; // usado para simbolos internacionais

namespace CursoCSharp.Fundamentos
{
    class FormatandoNúmeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // coloca uma casa após o ponto
            Console.WriteLine(valor.ToString("F2")); // coloca duas casas após o ponto
            Console.WriteLine(valor.ToString("F3")); // coloca três casas após o ponto
            Console.WriteLine(valor.ToString("C")); // coloca o valor monetário
            Console.WriteLine(valor.ToString("P")); // coloca o valor percentual
            Console.WriteLine(valor.ToString("#.##")); // coloca o valor com duas casas após o ponto (F2)

            CultureInfo cultura = new CultureInfo("en-US"); // configurado em outro idioma diferente da máquina
            Console.WriteLine(valor.ToString("C0", cultura)); // não coloca nenhuma casa após o ponto

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // coloca 0 a esquerda, completa até chegar no número do D (sete 0 + inteiro)
        }
    }
}
