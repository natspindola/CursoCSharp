using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMétodos
{
    public class CalculadoraEstática
    {
        public static int Multiplicar(int a, int b) //método estático
        {
            return a * b;
        }
        public int Somar(int a, int b) //sem o static, método de instância
        {
            return a + b;
        }
    }
    
    class MétodosEstáticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstática.Multiplicar(2, 2); //método estático
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstática calc = new CalculadoraEstática(); //sem o static, método de instância
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
