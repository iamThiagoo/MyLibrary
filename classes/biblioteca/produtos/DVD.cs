using System;
using trabalho_oop.interfaces;

namespace trabalho_oop.classes.biblioteca.produtos
{
    public class DVD : ItemBiblioteca, IEmprestavel
    {
        private string assunto;
        private int duracao;

        public DVD(
            int identificacao,
            string titulo,
            string assunto,
            int duracao
        ) : base (identificacao, titulo)
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
            return Situacao == "Disponivel" ? true : false;
        }

        public bool Emprestado()
        {
            return Situacao == "Emprestado" ? true : false;
        }

        public bool Bloqueado()
        {
            return Situacao == "Bloqueado" ? true : false;
        }

        public bool Atrasado()
        {
            return Situacao == "Atrasado" ? true : false;
        }

        public override string ToString()
        {
            return $"Identificação: {Identificacao}" +
                   $"\nTítulo: {Titulo}" +
                   $"\nAssunto: {assunto}" +
                   $"\nDuração: {duracao}" +
                   $"\nStatus do Item: {Situacao}";
        }
    }
}