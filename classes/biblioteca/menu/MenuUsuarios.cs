using trabalho_oop.classes.usuarios;
using trabalho_oop.interfaces;

namespace trabalho_oop.classes.biblioteca.menu
{
    public class MenuUsuarios : Menu
    {
        private CadUsuarios cadUsuarios;

        public MenuUsuarios(CadUsuarios cadUsuarios)
        {   
            this.cadUsuarios = cadUsuarios;
            
            Console.Clear();
            MenuTitulo("Ações para Usuários");
            Opcoes();
        }

        public override void Opcoes()
        {
            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar todos os usuários cadastrados");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("V - Voltar para Menu Principal");

            string resposta = Console.ReadLine()!;
            int opcao;

            if (resposta.Equals("V", StringComparison.OrdinalIgnoreCase)) {
                MenuOpcoes menu = new MenuOpcoes();
                return;
            }

            if (!int.TryParse(resposta, out opcao) || (opcao < 1 || opcao > 3)) {
                OpcaoInvalida();
                return;
            }

            ExecutaOpcao(opcao);
        }


        public override void ExecutaOpcao(int opcao)
        {
            switch (opcao){
                case 1:
                    Usuario usuario = CadUsuario();
                    cadUsuarios.AddUser(usuario);
                    
                    Console.WriteLine("\n ✅ Usuário adicionado com sucesso!");
                    break;
                case 2:
                    ListaUsuarios();
                    break;
                case 3:
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nAperte qualquer tecla para Voltar ao Menu de Usuários");
            Console.ReadKey();

            Console.Clear();
            Opcoes();
        }

        public override void OpcaoInvalida()
        {
            Console.WriteLine("\nOpção inválida. Tente novamente!");
            Thread.Sleep(2000);
            Console.Clear();
            Opcoes();
        }

        public Usuario CadUsuario() 
        {
            Console.Clear();
            MenuTitulo("Cadastro de Usuário");

            Console.WriteLine("\nInsira o nome do Usuário:");
            string nome = Console.ReadLine()!;

            Console.WriteLine("\nInformações de Endereço do Usuário");

            Console.WriteLine("\nInsira a rua do usuário:");
            string ruaResidencia = Console.ReadLine()!;

            Console.WriteLine("\nInsira o número da residência do usuário:");
            int numeroResidencia = EntradaDados.RetorneInteiro()!;

            Console.WriteLine("\nInsira o complemento da residência do usuário:");
            string complementoResidencia = Console.ReadLine()!;

            Console.WriteLine("\nInsira o bairro da residência do usuário:");
            string bairroResidencia = Console.ReadLine()!;

            Console.WriteLine("\nInsira a cidade da residência do usuário:");
            string cidadeResidencia = Console.ReadLine()!;

            Console.WriteLine("\nInsira a UF da residência do usuário:");
            string ufResidencia = Console.ReadLine()!;

            Console.WriteLine("\nInsira o CEP da residência do usuário:");
            string cepResidencia = Console.ReadLine()!;

            Console.WriteLine("\nDefina os campos de matrícula e Curso");

            Console.WriteLine("\nInsira a matrícula do usuário:");
            string matricula = Console.ReadLine()!;

            Console.WriteLine("\nInsira o curso do usuário:");
            string curso = Console.ReadLine()!;

            Endereco endereco = new Endereco(ruaResidencia, 
                                             numeroResidencia, 
                                             complementoResidencia, 
                                             bairroResidencia, 
                                             cidadeResidencia, 
                                             ufResidencia, 
                                             cepResidencia);

            Usuario usuario = new Usuario(nome, endereco, matricula, curso);

            return usuario;
        }


        public void ListaUsuarios()
        {
            Console.Clear();
            MenuTitulo("Todos os Usuários");

            if (cadUsuarios.Count() > 0) {
                for(int i = 0; i < cadUsuarios.Count(); i++)
                {
                    Usuario usuario = cadUsuarios.GetUserByIndex(i);
    
                    Console.WriteLine($"\nNome: {usuario.Nome}");
                    Console.WriteLine($"Matrícula: {usuario.Matricula}");
                    Console.WriteLine($"Curso: {usuario.Curso}");
                    Console.WriteLine($"Endereço: {usuario.Endereco}");
                }
            } else {
                Console.WriteLine("\nNenhum usuário cadastrado!");
            }
        }
    }
}