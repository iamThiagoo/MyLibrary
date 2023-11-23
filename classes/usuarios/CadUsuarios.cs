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
            Usuario usuario = usuarios.Get(index);
            return usuario;
        }

        public bool deleteUserByMatricula(string matricula)
        {
            int index = usuarios.Where('matricula' => matricula).FirstOrDefault();

            if (index) {
                usuarios.RemoveAt(index);
                return true;
            }

            return false;
        }
    }
}