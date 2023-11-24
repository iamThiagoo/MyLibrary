using System;

namespace trabalho_oop.classes.biblioteca.produtos
{
    public class DVD : ItemBiblioteca, IEmprestavel
    {
        private string assunto;
        private int duracao;

        public DVD(string assunto, int duracao)
        {
            this.assunto = assunto;
            this.duracao = duracao;
        }

        public string Assunto {
            get { return assunto; }
            set { assunto = value; }
        }

        public int Duracao {
            get { return duracao; }
            set { duracao = value; }
        }

        public bool Disponivel()
        {
            return this.Situacao == 'disponivel' ?? false;
        }

        public bool Emprestado()
        {
            return this.Situacao == 'emprestado' ?? false;
        }

        public bool Bloqueado()
        {
            return this.Situacao == 'bloqueado' ?? false;
        }

        public bool Atrasado()
        {
            return this.Situacao == 'atrasado' ?? false;
        }

        public override string ToString()
        {
            return $"assunto={assunto};duracao={duracao}";
        }
    }
}