using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp {
    public class CentralDeExercicios {
        Dictionary<string, Action> Exercicios;

        public CentralDeExercicios(Dictionary<string, Action> exercicios) {
            Exercicios = exercicios;    
        }

        public void SelecionarEExecutar() {
            int i = 1;

            foreach (var exercicio in Exercicios) {
                Console.WriteLine("{0}) {1}", i, exercicio.Key);
                i++;
            }

            Console.Write("Digite o número (ou vazio para o último)? ");

            int.TryParse(Console.ReadLine(), out int num);
            bool numValido = num > 0 && num <= Exercicios.Count;
            num = numValido ? num - 1 : Exercicios.Count - 1;

            string nomeDoExercicio = Exercicios.ElementAt(num).Key;

            Console.Write("\nExecutando exercício ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(nomeDoExercicio);
            Console.ResetColor();

            Console.WriteLine(String.Concat(
                Enumerable.Repeat("=", nomeDoExercicio.Length + 21)) + "\n");

            Action executar = Exercicios.ElementAt(num).Value;
            try {
                executar();
            } catch(Exception e) {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                Console.ResetColor();

                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine("Digite 0 para voltar e 1 para sair.");
            var retorno = Console.ReadLine();

            if (!string.IsNullOrEmpty(retorno))
            {
                switch (retorno)
                {
                    case "1":
                        System.Environment.Exit(0);
                        break;
                    case "0":
                        SelecionarEExecutar();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}