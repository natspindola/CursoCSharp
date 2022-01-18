using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMétodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;
        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a)
        {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }

    }
    class MétodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(13, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(47, 2));
            Console.WriteLine(calculadoraComum.Dividir(33, 3));

            var calculadoraCadeia = new CalculadoraCadeia(); //uma sentença faz várias chamadas
                calculadoraCadeia.Somar(3).Multiplicar(3).Subtrair(1).Dividir(2).Imprimir().Limpar().Imprimir();
            //imprimir, limpar, imprimir = dá o resultado e depois dá o 0

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
