using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMétodos;
using CursoCSharp.Coleçoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFunçoes;
using CursoCSharp.Exceçoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvançados;

namespace CursoCSharp 
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                //Fundamentos
                {"Primeiro programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentários.Executar},
                {"Variáveis e constantes - Fundamentos", VariáveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferência.Executar},
                {"Interpolação - Fundamentos", Interpolação.Executar},
                {"Notação ponto - Fundamentos", NotaçãoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando números - Fundamentos", FormatandoNúmeros.Executar},
                {"Conversões - Fundamentos", Conversões.Executar},
                {"Operadores aritméticos - Fundamentos", OperadoresAritméticos.Executar},
                {"Operadores relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores lógicos - Fundamentos", OperadoresLógicos.Executar},
                {"Operadores de atribuição - Fundamentos", OperadoresAtribuição.Executar},
                {"Operadores unários - Fundamentos", OperadoresUnários.Executar},
                {"Operadore ternário - Fundamentos", OperadorTernário.Executar},

                //Estruturas de controle
                {"Estrutura IF - Estruturas de controle", EstruturaIF.Executar},
                {"Estrutura IF / Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura IF / Else / If - Estruturas de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura FOR - Estruturas de controle", EstruturaFOR.Executar},
                {"Estrutura Foreach - Estruturas de controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de controle", UsandoContinue.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com retorno - Classes e Métodos", MétodosComRetorno.Executar},
                {"Métodos estáticos - Classes e Métodos", MétodosEstáticos.Executar},
                {"Atributos estáticos - Classes e Métodos", AtributosEstáticos.Executar},
                {"Desafio atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parâmetros variados - Classes e Métodos", ParâmetrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"ReadOnly - Classes e Métodos", ReadOnlycs.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct VS Classe - Classes e Métodos", StructVSClasse.Executar},
                {"Valor VS Referência - Classes e Métodos", ValorVSReferência.Executar},
                {"Parâmetros por referência - Classes e Métodos", ParâmetrosPorReferência.Executar},
                {"Parâmetro com valor padrão - Classes e Métodos", ParâmetroPadrão.Executar},

                //Coleções
                {"Array - Coleções", Coleçoes.Array.Executar},
                {"List - Coleções", ColeçoesList.Executar},
                {"Array List - Coleções", ColeçoesArrayList.Executar},
                {"Set - Coleções", ColeçoesSet.Executar},
                {"Queue - Coleções", ColeçoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColeçoesStack.Executar},
                {"Dictionary - Coleções", ColeçoesDictionary.Executar},

                //Orientação a objeto
                {"Herança - Orientação a Objetos", Herança.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstract - Orientação a Objetos", Abstract.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed - Orientação a Objetos", Sealed.Executar},

                //Métodos e Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambdas como Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegates com função anônima - Métodos e Funções", DelegateFunAnonima.Executar},
                {"Delegates como parâmetros - Métodos e Funções", DelegateComoParametro.Executar},
                {"Métodos de extenção - Métodos e Funções", MetodoDeExtençao.Executar},

                //Exceções
                {"Primeira Exceção - Exceções", PrimeiraExceçao.Executar},
                {"Exceções personalizadas - Exceções", ExceçoesPersonalizadas.Executar},

                //Explorando a API
                {"Primeiro arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo arquivos - Usando API", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Diretórios - Usando API", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Date Time - Usando API", ExemploDateTime.Executar},
                {"TimeSpan - Usando API", ExemploTimeSpan.Executar},

                //Tópicos avançados
                {"LINQ #01 - Tópicos avançados", LINQ1.Executar},
                {"LINQ #02 - Tópicos avançados", LINQ2.Executar},
                {"Nullables - Tópicos avançados", Nullables.Executar},
                {"Dynamics - Tópicos avançados", Dynamics.Executar},
                {"Generics - Tópicos avançados", Generics.Executar},

            }); ;

            central.SelecionarEExecutar();
        }
    }
}