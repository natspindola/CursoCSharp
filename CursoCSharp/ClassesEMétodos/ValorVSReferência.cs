using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMétodos
{
    public struct Dependente //Struct ou class, muda apenas o resultado, mas o código funciona
    {
        public string Nome;
        public int Idade;

    }
    class ValorVSReferência
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} e {copiaNumero}"); //número e cópia são iguais
            numero++;
            Console.WriteLine($"{numero} e {copiaNumero}"); //número e cópia são diferentes

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20,
            };

            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} e {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} e {copiaDep.Idade}");

            copiaDep.Nome = "Renato"; //struct mantém a informação original quando usa "copia",
            dep.Idade = 24;           //class repete a última informação inserida quando usa "copia".

            Console.WriteLine($"{dep.Nome} e {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} e {copiaDep.Idade}");

        }
    }
}
