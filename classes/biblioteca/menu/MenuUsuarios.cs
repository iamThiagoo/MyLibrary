using trabalho_oop.classes.usuarios;
using trabalho_oop.interfaces;

namespace trabalho_oop.classes.biblioteca.menu
{
    public class MenuUsuarios : Menu
    {
        private CadUsuarios cadUsuarios;

        public MenuUsuarios(CadUsuarios cadUsuarios)
        {   
            Console.Clear();
            MenuTitulo("Ações para Usuários");
            Opcoes();

            string resposta = Console.ReadLine()!;
            int opcao;

            if (resposta.Equals("V", StringComparison.OrdinalIgnoreCase)) {
                MenuOpcoes menu = new MenuOpcoes();
                return;
            }

            while(!int.TryParse(resposta, out opcao)) {
                if (opcao < 0 && opcao > 3) {
                    OpcaoInvalida();
                }
            }

            this.cadUsuarios = cadUsuarios;
            ExecutaOpcao(opcao);
        }

        public override void Opcoes()
        {
            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar todos os usuários cadastrados");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("V - Voltar para Menu Principal");
        }

        public override void ExecutaOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Usuario usuario = CadUsuario();
                    cadUsuarios.AddUser(usuario);
                    
                    Console.WriteLine("\n ✅ Usuário adicionado com sucesso!");
                    
                    Console.WriteLine("\nAperte qualquer tecla para Voltar ao Menu de Usuários");
                    Console.ReadKey();

                    Console.Clear();
                    Opcoes();

                    break;
                case 2:
                    ListaUsuarios();

                    Console.WriteLine("\nAperte qualquer tecla para Voltar ao Menu de Usuários");
                    Console.ReadKey();

                    Console.Clear();
                    Opcoes();

                    break;
                case 3:
                    MenuEmprestimos menuEmprestimos = new MenuEmprestimos();
                    break;
                default:
                    break;
            }
        }

        public override void OpcaoInvalida()
        {
            Console.WriteLine("\nOpção inválida. Tente novamente:");
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
            string numeroResidencia = Console.ReadLine()!;

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

            for(int i = 0; i < cadUsuarios.Count(); i++)
            {
                Usuario usuario = cadUsuarios.GetUserByIndex(i);
 
                Console.WriteLine($"\nMatrícula: {usuario.Matricula}");
                Console.WriteLine($"\nNome do Usuário: {usuario.Nome}");
                Console.WriteLine($"\nCurso: {usuario.Curso}");
                Console.WriteLine($"\nEndereço: {usuario.Endereco}");
            }
        }
    }
}