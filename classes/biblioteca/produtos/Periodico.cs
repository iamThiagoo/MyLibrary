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
            return 
                   $"Identificação:{Identificacao}, " + 
                   $"Título:{Titulo}, " + 
                   $"Periodicidade:{periodicidade}," + 
                   $"Número: {numero}," +
                   $"Ano: {ano}, " +
                   $"Status do Item: {Situacao}";
        }
    }
}