﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMétodos;

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
            });

            central.SelecionarEExecutar();
        }
    }
}