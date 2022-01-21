using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    interface OperaçaoBinaria
    {
        int Operaçao(int a, int b);
    }

    class Soma : OperaçaoBinaria
    {
        public int Operaçao(int a, int b)
        {
            return a + b;
        }
    }

    class Subtraçao : OperaçaoBinaria
    {
        public int Operaçao(int a, int b)
        {
            return a - b;
        }
    }
    class Multiplicaçao : OperaçaoBinaria
    {
        public int Operaçao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperaçaoBinaria> operaçoes = new List<OperaçaoBinaria>
        {
            new Soma(),
            new Subtraçao(),
            new Multiplicaçao(),
        };

        public string ExecutarOperaçoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operaçoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operaçao(a, b)}\n";
            }
            return resultado;
        }
    }

    class Interface
    {
        public static void Executar ()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperaçoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
