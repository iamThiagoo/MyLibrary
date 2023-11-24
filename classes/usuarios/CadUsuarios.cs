using System;

namespace trabalho_oop.classes.usuarios
{
    public class CadUsuarios
    {
        private List<Usuario> usuarios;

        public CadUsuarios ()
        {
            usuarios = new List<Usuario>();
        }

        public void addUser(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public int count()
        {
            return usuarios.Count();
        }

        public Usuario getUserByIndex(int index)
        {
            Usuario usuario = usuarios[index];
            return usuario;
        }

        public bool deleteUserByMatricula(string matricula)
        {
            Usuario usuario = usuarios.FirstOrDefault(usuario => usuario.Matricula == matricula);

            if (usuario != null) {
                usuarios.Remove(usuario);
                return true;
            }

            return false;
        }
    }
}