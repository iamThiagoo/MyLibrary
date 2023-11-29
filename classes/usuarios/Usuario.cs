using System;

namespace trabalho_oop.classes.usuarios
{
    public class Usuario : Pessoa
    {
        private string matricula;
        private string curso;

        public Usuario (
            string nome,
            Endereco endereco,
            string matricula,
            string curso
        ) : base(nome, endereco)
        {
            this.matricula = matricula;
            this.curso = curso;
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public override string ToString()
        {
            return $"Matrícula: {matricula}, Curso: {curso}, " + base.ToString();
        }
    }
}