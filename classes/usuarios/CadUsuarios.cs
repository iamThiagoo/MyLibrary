namespace trabalho_oop.classes.usuarios
{
    public class CadUsuarios
    {
        private List<Usuario> usuarios;

        public CadUsuarios ()
        {
            usuarios = new List<Usuario>();
            AddUsuariosExemplos();
        }

        public void AddUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void RemoveUsuario(Usuario usuario)
        {
            usuarios.Remove(usuario);
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

        public Usuario GetUsuariosPorMatricula(string matricula)
        {
            return usuarios.FirstOrDefault(usuario => usuario.Matricula == matricula)!;
        }

        public bool DeletaUsuarioPorMatricula(string matricula)
        {
            if (usuarios.Count > 0) {
                Usuario usuario = usuarios.FirstOrDefault(usuario => usuario.Matricula == matricula)!;

                if (usuario != null) {
                    usuarios.Remove(usuario);
                    return true;
                }
            }

            return false;
        }

        private void AddUsuariosExemplos()
        {
            string[] linhas = File.ReadAllLines("exemplos/Usuarios.txt");
            List<string> userData = new List<string>();

            foreach (string linha in linhas) {
                if (string.IsNullOrWhiteSpace(linha)){
                    if (userData.Count == 10) {
                        ProcessaUsuario(userData);
                        userData.Clear();
                    }
                    continue;
                }
                userData.Add(linha);
            }
            
            if (userData.Count == 10) {
                ProcessaUsuario(userData);
            }
        }

        private void ProcessaUsuario(List<string> userArray)
        {
            string nome = userArray[0];
            string rua = userArray[1];
            int numero = int.Parse(userArray[2]);
            string complemento = userArray[3];
            string bairro = userArray[4];
            string cidade = userArray[5];
            string uf = userArray[6];
            string cep = userArray[7];
            string matricula = userArray[8];
            string curso = userArray[9];

            Endereco endereco = new Endereco(rua, numero, complemento, bairro, cidade, uf, cep);

            Usuario usuario = new Usuario(nome, endereco, matricula, curso);
            usuarios.Add(usuario);
        }

    }
}