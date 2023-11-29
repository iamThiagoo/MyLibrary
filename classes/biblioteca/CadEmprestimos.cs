using System;

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

        public Emprestimo GetEmprestimoByIndex(int index)
        {
            Emprestimo usuario = emprestimos[index];
            return usuario;
        }

        public void Atrasos() {
           // Implementar 
        }
    }
}