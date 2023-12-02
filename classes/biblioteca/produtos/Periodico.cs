using System;
using trabalho_oop.interfaces;

namespace trabalho_oop.classes.biblioteca.produtos
{
    public class Periodico : ItemBiblioteca, IEmprestavel
    {
        private string periodicidade;
        private int numero;
        private int ano;

        public Periodico(
            int identificacao, 
            string titulo, 
            string periodicidade, 
            int numero, 
            int ano
        ) : base (identificacao, titulo)
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
                   $"\nPeriodicidade: {periodicidade}" + 
                   $"\nNúmero: {numero}" +
                   $"\nAno: {ano}" +
                   $"\nStatus do Item: {Situacao}";
        }
    }
}