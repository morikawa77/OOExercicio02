using System;
namespace OOExercicio02
{
    public class Cliente
    {
        public Cliente(Int32 codigo, string nome, string email, string cidade, string uf)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Email = email;
            this.Cidade = cidade;
            this.Uf = uf;
        }
        private Int32 codigo;
        private string nome, email, cidade, uf;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }


        /*
        public Int32 GetCodigo(){
            return Codigo;
        }

        public void SetCodigo (Int32 Codigo){
            this.Codigo = Codigo;
        }

        public string GetNome(){
            return Nome;
        }

		public void SetNome(string Nome)
		{
			this.Nome = Nome;
		}

        public string GetEmail(){
            return Email;
        }

		public void SetEmail(string Email)
		{
			this.Email = Email;
		}

        public string GetCidade(){
            return Cidade;
        }

		public void SetCidade(string Cidade)
		{
			this.Cidade = Cidade;
		}

        public string GetUF(){
            return UF;
        }

		public void SetUF(string UF)
		{
			this.UF = UF;
		}
		*/

    }
}
