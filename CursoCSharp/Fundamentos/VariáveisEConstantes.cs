using System;

namespace CursoCSharp.Fundamentos
{
    class VariáveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //o valor da constante não pode mudar, portanto PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("area é " + area);

            //tipos internos do C#
            bool EstáChovendo = true; //verdadeiro ou falso
            Console.WriteLine("Está chovendo " + EstáChovendo);

            byte idade = 25; //varia de 0 a 255
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // -128 a 127, aceita o uso do sinal positivo e negativo
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salário = short.MaxValue; //-32.768 a 32.767, aceita o uso de sinal (ushort não aceita sinal, vai de 0 a 65.535)
            Console.WriteLine("O salário é " + salário);

            int menorValorInt = int.MinValue; //inteiro com sinal mais usado, vai de -2.147.483.648 a 2.147.483.647.
            Console.WriteLine("Menor valor do inteiro é " + menorValorInt);

            uint populaçãoBrasileira = 207_600_000; //inteiro sem sinal, vai de 0 a 4.294.967.295.
            Console.WriteLine("A população brasileira é de " + populaçãoBrasileira + " habitantes");

            long menorValorLong = long.MinValue; //vai de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            Console.WriteLine("Menor valor long é " + menorValorLong);

            ulong populaçãoMundial = 7_600_000_000; //inteiro sem sinal, vai de 0 a 18.446.744.073.709.551.615.
            Console.WriteLine("A população mundial é de " + populaçãoMundial.ToString("N2") + " habitantes");

            float preçoComputador = 1299.99f; //serve para valores pequenos, não é tão preciso
            Console.WriteLine("O preço do computador é " + preçoComputador + " reais");

            double valordeMercadoApple = 1_000_000_000.00; //mais usado, mais precisão que o float
            Console.WriteLine("A empresa Apple está avaliada em " + valordeMercadoApple + " doláres");

            decimal distânciaEntreEstrelas = decimal.MaxValue; //usado para valores grandes ou dinheiro, mais preciso que o double
            Console.WriteLine("A distância média entre as estrelas é " + distânciaEntreEstrelas + " km");

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);
        }

    }
}
