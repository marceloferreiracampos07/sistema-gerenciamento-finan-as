using System;
using SistemaGerenciamentoFinancas.Model;
using SistemaGerenciamentoFinancas.Repository;
using Sistemagerenciamentofinanças.service;

namespace SistemaGerenciamentoFinancas
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new TransacaoRepository();
            var service = new TransacoesService(repo);
            bool sistemaRodando = true;

            while (sistemaRodando)
            {
                Console.Clear();
                Console.WriteLine("======= GERENCIADOR FINANCEIRO =======");
                decimal saldo = service.CalcularSaldo();
                Console.WriteLine($" SALDO ATUAL: {saldo:C2}");
                Console.WriteLine("======================================");
                Console.WriteLine(" 1 - Adicionar Transação");
                Console.WriteLine(" 2 - Ver Extrato");
                Console.WriteLine(" 3 - Ver Total de Receitas");
                Console.WriteLine(" 4 - Ver Total de Despesas");
                Console.WriteLine(" 5 - Atualizar Transação (ID)"); 
                Console.WriteLine(" 6 - Remover Transação (ID)"); 
                Console.WriteLine(" 0 - Sair");
                Console.WriteLine("--------------------------------------");

                Console.Write(" Escolha uma opção: ");
                string entradaOpcao = Console.ReadLine();

                switch (entradaOpcao)
                {
                    case "1":
                        Console.WriteLine("\n--- NOVA TRANSAÇÃO ---");
                        Console.Write(" Descrição: ");
                        string desc = Console.ReadLine();
                        Console.Write(" Valor: R$ ");
                        decimal.TryParse(Console.ReadLine(), out decimal valor);
                        Console.WriteLine(" Tipo: (1) Receita | (2) Despesa");
                        Console.Write(" Escolha o tipo: ");
                        int.TryParse(Console.ReadLine(), out int tipo);

                        service.CriarTransacoes(desc, valor, tipo);
                        break;

                    case "2":
                        service.Exibirextrato();
                        break;

                    case "3":
                        decimal receitas = service.CalcularSaldo(TipoTransacao.Receita);
                        Console.WriteLine($"\n Total de Entradas: {receitas:C2}");
                        break;

                    case "4":
                        decimal despesas = service.CalcularSaldo(TipoTransacao.Despesa);
                        Console.WriteLine($"\n Total de Saídas: {despesas:C2}");
                        break;

                    case "5":
                        Console.WriteLine("\n--- ATUALIZAR TRANSAÇÃO ---");
                        Console.Write(" Digite o ID da transação: ");
                        int.TryParse(Console.ReadLine(), out int idAtu);

                        Console.Write(" Nova Descrição: ");
                        string novaDesc = Console.ReadLine();

                        Console.Write(" Novo Valor: R$ ");
                        decimal.TryParse(Console.ReadLine(), out decimal nVal);

                        service.AtualizarTransacao(idAtu, novaDesc, nVal);
                        break;

                    case "6":
                        Console.WriteLine("\n--- REMOVER TRANSAÇÃO ---");
                        Console.Write(" Digite o ID da transação que deseja excluir: ");
                        int.TryParse(Console.ReadLine(), out int idRem);

                        service.RemoverTransacao(idRem);
                        break;

                    case "0":
                        Console.WriteLine(" Saindo...");
                        sistemaRodando = false;
                        break;

                    default:
                        Console.WriteLine(" Opção inválida!");
                        break;
                }

                if (sistemaRodando && entradaOpcao != "0") AguardarTecla();
            }
        }

        static void AguardarTecla()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}