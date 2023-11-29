using System;
using trabalho_oop.classes.biblioteca.produtos;
using trabalho_oop.classes.usuarios;

namespace trabalho_oop.classes.biblioteca
{
    public class Emprestimo 
    {
        private int identificacao;
        private Usuario usuario;
        private ItemBiblioteca itemBiblioteca;
        private DateTime dataEmprestimo;
        private DateTime dataDevolucao;

        public Emprestimo(
            int identificacao, 
            Usuario usuario,
            ItemBiblioteca itemBiblioteca,
            DateTime dataEmprestimo,
            DateTime dataDevolucao
        ) {
            this.identificacao = identificacao;
            this.usuario = usuario;
            this.itemBiblioteca = itemBiblioteca;
            this.dataEmprestimo = dataEmprestimo;
            this.dataDevolucao = dataDevolucao;
        }

        public int Identificacao { 
            get { return identificacao; }
            set { identificacao = value; }
        }

        public Usuario Usuario { 
            get { return usuario; }
            set { usuario = value; } 
        }

        public ItemBiblioteca ItemBiblioteca { 
            get { return itemBiblioteca; }
            set { itemBiblioteca = value; }
        }

        public DateTime DataEmprestimo { 
            get { return dataEmprestimo; } 
            set { dataEmprestimo = value; }
        }

        public DateTime DataDevolucao { 
            get { return dataDevolucao; }
            set { dataDevolucao = value; } 
        }

        public void Emprestar(Usuario usuario, ItemBiblioteca item, int prazo) 
        {

        }

        public void Retornar() 
        {

        }

        public override string ToString()
        {
            string dataEmprestimoFormat = dataEmprestimo.ToString("d/M/Y");
            string dataDevolucaoFormat = dataEmprestimo.ToString("d/M/y"); 

            return $"Identificação: {identificacao}, " +
                   $"Usuário: {usuario.Nome}, " +
                   $"Matrícula do Usuário: {usuario.Matricula}, " +
                   $"Item: {itemBiblioteca.Titulo}, " +
                   $"Data de Empréstimo: {dataEmprestimoFormat}, " +
                   $"Data de Devolução: {dataDevolucaoFormat}," +
                   $"Status do Item: {itemBiblioteca.Situacao}";
        }
    }
}