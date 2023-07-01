using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atrubuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de  controle
                {"Estrutura If - Estruturas de controles", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de controles", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de controles", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controles", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controles", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de controles", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controles", EstruturaFor.Executar},






            });

            central.SelecionarEExecutar();
        }
    }
}