using System;
using trabalho_oop.interfaces;

namespace trabalho_oop.classes.biblioteca.produtos
{
    public class Livro : ItemBiblioteca, IEmprestavel
    {
        private string autor;
        private string editora;
        private int paginas;

        public Livro(string autor, string editora, int paginas)
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
            return $"autor={autor};editora={editora};paginas={paginas}";
        }
    }
}