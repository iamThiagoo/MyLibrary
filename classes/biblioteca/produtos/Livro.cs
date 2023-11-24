using System;
using trabalho_oop.interfaces;

namespace trabalho_oop.classes.biblioteca.produtos
{
    public class Livro : ItemBiblioteca, IEmprestavel
    {
        private string autor;
        private string editora;
        private int paginas;
        
        public Livro (string autor, string editora, int paginas)
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
    }

}