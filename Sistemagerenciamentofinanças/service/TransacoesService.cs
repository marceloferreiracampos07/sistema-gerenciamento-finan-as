using SistemaGerenciamentoFinancas.Model;
using SistemaGerenciamentoFinancas.Repository;

namespace Sistemagerenciamentofinanças.service
{
    internal class TransacoesService
    {
        private readonly TransacaoRepository _Repository;

        public TransacoesService(TransacaoRepository repository)
        {
            _Repository = repository;
        }

        public void CriarTransacoes(string descricao, decimal valor, int tipoescolhido)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Erro: O valor deve ser maior que zero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(descricao))
            {
                Console.WriteLine("Erro: A descrição não pode ser vazia.");
                return;
            }

            TipoTransacao tipo = (tipoescolhido == 1) ? TipoTransacao.Receita : TipoTransacao.Despesa;

            var novaTransacao = new Transacao(descricao, valor, tipo);
            _Repository.Adicionartransacao(novaTransacao);
            Console.WriteLine("Sucesso: Transação registrada com sucesso!");
        }

        public void Exibirextrato()
        {
            var lista = _Repository.Obtertodas();
            if (lista.Count == 0)
            {
                Console.WriteLine("A lista está vazia, não contém transações.");
                return;
            }

            Console.WriteLine("\n====== EXTRATO DE TRANSAÇÕES =======");
            foreach (var tran in lista)
            {
                Console.WriteLine(tran);
            }
            Console.WriteLine("=====================================");
        }

        

        public void RemoverTransacao(int id)
        {
           
            _Repository.RemoverTransacoesById(id);
        }

        public void AtualizarTransacao(int id, string novaDesc, decimal novoVal)
        {
            
            _Repository.AtualizatransacaoById(id, novaDesc, novoVal);
        }

        

        public decimal CalcularSaldo(TipoTransacao tipo)
        {
            var lista = _Repository.Obtertodas();
            decimal total = 0;
            foreach (var item in lista)
            {
                if (item.Tipo == tipo)
                {
                    total += item.Valor;
                }
            }
            return total;
        }

        public decimal CalcularSaldo()
        {
            decimal receita = CalcularSaldo(TipoTransacao.Receita);
            decimal despesas = CalcularSaldo(TipoTransacao.Despesa);

           
            return receita - despesas;
        }
    }
}