using trabalho_oop.classes.usuarios;

namespace trabalho_oop.classes.biblioteca
{
    public class CadEmprestimos 
    {
        private List<Emprestimo> emprestimos;

        public CadEmprestimos ()
        {
            emprestimos = new List<Emprestimo>();
        }

        public void AddEmprestimo(Emprestimo emprestimo)
        {
            emprestimos.Add(emprestimo);
        }

        public void DeleteEmprestimo(Emprestimo emprestimo)
        {
            emprestimos.Remove(emprestimo);
        }

        public int Count()
        {
            return emprestimos.Count;
        }

        public List<Emprestimo> GetEmprestimosOrdenados()
        {
            return emprestimos.OrderBy(emprestimo => emprestimo.DataDevolucao).ToList();
        }

        public Emprestimo GetEmprestimoByIndex(int index)
        {
            Emprestimo usuario = emprestimos[index];
            return usuario;
        }

        public Emprestimo GetEmprestimoByIdentificacao(int identificacao)
        {
            return emprestimos.FirstOrDefault(emprestimo => emprestimo.Identificacao == identificacao)!;
        }

        public Emprestimo GetEmprestimoByUsuario(Usuario usuario)
        {
            return emprestimos.FirstOrDefault(emprestimo => emprestimo.Usuario == usuario)!;
        }

        public void Atrasos() {
            foreach(Emprestimo emprestimo in emprestimos) {
                if (emprestimo.DataDevolucao < DateTime.Now) {
                    emprestimo.Item.Situacao = "Atrasado";
                }
            }
        }
    }
}