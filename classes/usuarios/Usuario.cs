using System;

namespace trabalho_oop.classes.usuarios
{
    public class Usuario : Pessoa
    {
        private string matricula;
        private Endereco curso;

        public Usuario (
            string nome,
            Endereco endereco,
            string matricula,
            string curso
        ) : base(string nome, Endereco endereco)
        {
            this.matricula = matricula;
            this.curso = curso;
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public Endereco Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"matricula={matricula}; curso={curso};";
        }
    }
}