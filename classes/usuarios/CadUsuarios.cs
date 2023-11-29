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

        public void AddUser(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public int Count()
        {
            return usuarios.Count;
        }

        public Usuario GetUserByIndex(int index)
        {
            Usuario usuario = usuarios[index];
            return usuario;
        }

        public bool DeleteUserByMatricula(string matricula)
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