using System;

namespace SistemaGerenciamentoFinancas.Model
{
    public class Transacao
    {
        private static int _contadorId = 1;
        public int Id { get; private set; }
        private string? _descricao;
        private decimal _valor;
        private TipoTransacao _tipo;

        public string Descricao
        {
            get { return _descricao; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _descricao = value;
                }
                else
                {
                    Console.WriteLine("Error: Por favor preencha a descrição.");
                }
            }
        }

        public decimal Valor
        {
            get { return _valor; }
            set
            {
                if (value >= 0)
                {
                    _valor = value;
                }
                else
                {
                    Console.WriteLine("Error: Valor negativo detectado.");
                    _valor = 0;
                }
            }
        }

        public TipoTransacao Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public Transacao(string descricao, decimal valor, TipoTransacao tipo)
        {
            this.Id = _contadorId++;
            this.Descricao = descricao;
            this.Valor = valor;
            this.Tipo = tipo;
        }

       
        public override string ToString()
        {
            
            string infoTipo = Tipo == TipoTransacao.Receita ? "[Receita]" : "[Despesas]";
            return $"{infoTipo} ID: {Id:D3} | {Descricao.PadRight(15)} | {Valor:C2}";
        }
    }
}