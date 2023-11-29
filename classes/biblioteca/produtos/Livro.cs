using System;
using trabalho_oop.interfaces;

namespace trabalho_oop.classes.biblioteca.produtos
{
    public class Livro : ItemBiblioteca, IEmprestavel
    {
        private string autor;
        private string editora;
        private int paginas;

        public Livro(
            int identificacao, 
            string titulo, 
            string autor, 
            string editora, 
            int paginas
        ) : base(identificacao, titulo)
        {
            this.autor = autor;
            this.editora = editora;
            this.paginas = paginas;
        }

        public string Autor {
            get { return autor; }
            set { autor = value; }
        }

        public string Editora {
            get { return editora; }
            set { editora = value; }
        }

        public int Paginas {
            get { return paginas; }
            set { paginas = value; }
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
                   $"Autor={autor}, " +
                   $"Editora: {editora}, " +  
                   $"Páginas: {paginas}, " +
                   $"Status do Item: {Situacao}";
        }
    }
}