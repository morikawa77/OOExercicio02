using System;
namespace OOExercicio02
{
    public class Pedido
    {
        public Pedido(Int32 codigo, Int32 clienteCodigo, DateTime dataHora, string observacoes, Decimal valor)
        {
            this.Codigo = codigo;
            this.ClienteCodigo = clienteCodigo;
            this.DataHora = dataHora;
            this.Observacoes = observacoes;
            this.Valor = valor;
        }
        private Int32 codigo, clienteCodigo;
        private DateTime dataHora;
        private string observacoes;
        private Decimal valor;

        public int Codigo { get => codigo; set => codigo = value; }
        public int ClienteCodigo { get => clienteCodigo; set => clienteCodigo = value; }
        public DateTime DataHora { get => dataHora; set => dataHora = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }
        public decimal Valor { get => valor; set => valor = value; }




        /*
		public Int32 GetCodigo()
		{
			return Codigo;
		}

		public void SetCodigo(Int32 Codigo)
		{
			this.Codigo = Codigo;
		}

		public Int32 GetClienteCodigo()
		{
			return ClienteCodigo;
		}

		public void SetClienteCodigo(Int32 ClienteCodigo)
		{
			this.ClienteCodigo = ClienteCodigo;
		}

		public DateTime GetDataHora()
		{
			return DataHora;
		}

		public void SetDataHora(DateTime DataHora)
		{
			this.DataHora = DataHora;
		}

		public string GetObservacoes()
		{
			return Observacoes;
		}

		public void SetObservacoes(string Observacoes)
		{
			this.Observacoes = Observacoes;
		}

		public Decimal GetValor()
		{
			return Valor;
		}

		public void SetValor(decimal Valor)
		{
			this.Valor = Valor;
		}
        
        */
    }
}
