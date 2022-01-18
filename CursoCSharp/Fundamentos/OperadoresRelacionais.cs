using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar ()
        {
            // resultado verdadeiro ou falso
            // double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0); // maior
            Console.WriteLine("Nota inválida? {0}", nota < 0.0); // menor
            Console.WriteLine("Perfeito? {0}", nota == 10.0); // para igualdade usa ==, para atribuir usa =
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); // para diferença !=
            Console.WriteLine("Passou na média? {0}", nota >= notaDeCorte); // igual ou maior >=
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0); // menor ou igual <=
        }
    }
}