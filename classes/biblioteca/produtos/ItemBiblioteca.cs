using System;

namespace trabalho_oop.classes.biblioteca.produtos
{
    public abstract class ItemBiblioteca 
    {
        private int identificacao;
        private string titulo;
        private string situacao;

        public ItemBiblioteca (int identificacao, string titulo)
        {
            this.identificacao = identificacao;
            this.titulo = titulo;
            this.situacao = "Disponivel";
        }

        public ItemBiblioteca (int identificacao, string titulo, string situacao)
        {
            this.identificacao = identificacao;
            this.titulo = titulo;
            this.situacao = situacao;
        }

        public int Identificacao { 
            get { return identificacao; } 
            set { identificacao = value; } 
        }

        public string Titulo { 
            get { return titulo; } 
            set { titulo = value; }
        }

        public string Situacao { 
            get { return situacao; } 
            set {
                string[] situacoes = { 
                    "Emprestado", 
                    "Disponivel", 
                    "Bloqueado", 
                    "Atrasado" 
                };

                if (situacoes.Contains(value)) {
                    situacao = value;
                } else {
                    throw new Exception("Situação não encontrada");
                }
            }
        }

        public override string ToString()
        {
            return $"Identificação: {identificacao}, Título: {titulo}, Situação: {situacao}";
        }
    }
}