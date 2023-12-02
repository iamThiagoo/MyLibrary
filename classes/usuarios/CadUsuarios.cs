using System;
using System.IO;

namespace trabalho_oop.classes.usuarios
{
    public class CadUsuarios
    {
        private List<Usuario> usuarios;

        public CadUsuarios ()
        {
            usuarios = new List<Usuario>();
            AddUsuarios();
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
            if (usuarios.Count > 0) {
                Usuario usuario = usuarios.FirstOrDefault(usuario => usuario.Matricula == matricula);

                if (usuario != null) {
                    usuarios.Remove(usuario);
                    return true;
                }
            }

            return false;
        }

        private void AddUsuarios()
        {
            string[] linhas = File.ReadAllLines("/examples/Usuarios.txt");

            for (int i = 0; i < linhas.Length; i += 4)
            {
                string[] dadosUsuario = linhas[i].Split(", ");
                string[] dadosEndereco = linhas[i + 1].Split(", ");

                string nome = dadosUsuario[0];
                string matricula = dadosUsuario[1];
                string curso = dadosUsuario[2];

                string rua = dadosEndereco[0];
                int numero = int.Parse(dadosEndereco[1]);
                string complemento = dadosEndereco[2];
                string bairro = dadosEndereco[3];
                string cidade = dadosEndereco[4];
                string uf = dadosEndereco[5];
                string cep = dadosEndereco[6];

                Endereco endereco = new Endereco(rua, numero, complemento, bairro, cidade, uf, cep);

                Usuario usuario = new Usuario(nome, endereco, matricula, curso);
                usuarios.Add(usuario);
            }
        }
    }
}