using System;

namespace trabalho_oop.classes.biblioteca.produtos
{
    public class Periodico : ItemBiblioteca, IEmprestavel
    {
        private string periodicidade;
        private int numero;
        private int ano;

        public DVD(string periodicidade, int numero, int ano)
        {
            this.periodicidade = periodicidade;
            this.numero = numero;
            this.ano = ano;
        }

        public string Periodicidade {
            get { return periodicidade; }
            set { periodicidade = value; }
        }

        public int Numero {
            get { return numero; }
            set { numero = value; }
        }

        public int Ano {
            get { return ano; }
            set { ano = value; }
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
            return $"periodicidade={periodicidade};numero={numero};ano={ano}";
        }
    }
}