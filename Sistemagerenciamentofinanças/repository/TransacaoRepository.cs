using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SistemaGerenciamentoFinancas.Model;

namespace SistemaGerenciamentoFinancas.Repository
{
    public class TransacaoRepository
    {

        private List<Transacao> _transacoes;

        public TransacaoRepository()
        {

            _transacoes = new List<Transacao>();
        }

        public void Adicionartransacao(Transacao transacao)
        {
            _transacoes.Add(transacao);
        }
        public List<Transacao> Obtertodas()
        {
            return _transacoes;
        }
        public void RemoverTransacoesById(int id)
        {
            for (int i = 0; i < _transacoes.Count; i++)
            {
                if (_transacoes[i].Id == id)
                {
                    _transacoes.RemoveAt(i);
                    Console.WriteLine("transação removida com sucesso ");
                    return;
                }
            }
        }
        public void AtualizatransacaoById(int idBuscado, string novaDescricao, decimal novoValor)
        {
            foreach (var Transacoes in _transacoes)
            {
                if (Transacoes.Id == idBuscado)
                {
                    Transacoes.Descricao = novaDescricao;
                    Transacoes.Valor = novoValor;
                    Console.WriteLine("transação atualizada com sucesso ");
                    return;
                }

            }
        }

    }
}