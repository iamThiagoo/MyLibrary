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
            return Situacao == "disponivel" ? true : false;
        }

        public bool Emprestado()
        {
            return Situacao == "emprestado" ? true : false;
        }

        public bool Bloqueado()
        {
            return Situacao == "bloqueado" ? true : false;
        }

        public bool Atrasado()
        {
            return Situacao == "atrasado" ? true : false;
        }

        public override string ToString()
        {
            return $"Identificação:{Identificacao}, " +
                   $"Título:{Titulo}, " +
                   $"Assunto: {assunto}, " +
                   $"Duração: {duracao}, " +
                   $"Status do Item: {Situacao}";
        }
    }
}