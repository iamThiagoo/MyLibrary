using System;

namespace trabalho_oop.interfaces
{
    public interface IEmprestavel 
    {
        bool Disponivel();
        bool Emprestado();
        bool Bloqueado();
        bool Atrasado();
        string ToString();
    }
}