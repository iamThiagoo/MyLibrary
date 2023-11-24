using System;

namespace trabalho_oop.interfaces
{
    public interface IEmprestavel 
    {
        public bool Disponivel();
        public bool Emprestado();
        public bool Bloqueado();
        public bool Atrasado();
        public string ToString();
    }
}