using System;
using trabalho_oop.classes.biblioteca.produtos;
using trabalho_oop.classes.usuarios;

namespace trabalho_oop.classes.biblioteca
{
    public class Emprestimo 
    {
        private int identificacao;
        private Usuario usuario;
        private ItemBiblioteca item;
        private DateTime dataEmprestimo;
        private DateTime dataDevolucao;
        private CadEmprestimos cadEmprestimos;

        public Emprestimo(
            int identificacao,
            CadEmprestimos cadEmprestimos
        ) {
            this.identificacao = identificacao;
            this.usuario = null!;
            this.item = null!;
            this.dataEmprestimo = DateTime.Now;
            this.cadEmprestimos = cadEmprestimos;
        }

        public int Identificacao { 
            get { return identificacao; }
            set { identificacao = value; }
        }

        public Usuario Usuario { 
            get { return usuario; }
            set { usuario = value; } 
        }

        public ItemBiblioteca Item { 
            get { return item; }
            set { item = value; }
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
            this.usuario = usuario;
            this.item = item;
            dataDevolucao = dataEmprestimo.AddDays(prazo);
            item.Situacao = "Emprestado";
            cadEmprestimos.AddEmprestimo(this);
        }

        public void Retornar() 
        {
            item.Situacao = "Disponível";
            cadEmprestimos.RemoveEmprestimo(this);
        }

        public override string ToString()
        {
            string dataEmprestimoFormat = dataEmprestimo.ToString("d/M/Y");
            string dataDevolucaoFormat = dataEmprestimo.ToString("d/M/y"); 

            return $"\nIdentificação: {identificacao}" +
                   $"\nItem: {item.Titulo}" +
                   $"\nUsuário: {usuario.Nome} " +
                   $"\nMatrícula do Usuário: {usuario.Matricula} " +
                   $"\nData de Empréstimo: {dataEmprestimoFormat}, " +
                   $"\nData de Devolução: {dataDevolucaoFormat}," +
                   $"\nStatus do Item: {item.Situacao}";
        }
    }
}