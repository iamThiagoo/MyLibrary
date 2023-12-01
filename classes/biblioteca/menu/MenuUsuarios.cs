using trabalho_oop.interfaces;

namespace trabalho_oop.classes.biblioteca.menu
{
    public class MenuUsuarios : Menu
    {
        public MenuUsuarios()
        {
            Console.Clear();
            MenuOpcoes.MenuTitulo("Ações para Usuários");
            Opcoes();

            string resposta = Console.ReadLine()!;

            if (resposta.Equals("V", StringComparison.OrdinalIgnoreCase)) {
                MenuOpcoes menu = new MenuOpcoes();
                return;
            }

            while(!int.TryParse(resposta, out int opcao)) {
                if (opcao < 0 && opcao > 3) {
                    OpcaoInvalida();
                }
            }        
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
                    MenuUsuarios menuUsuarios = new MenuUsuarios();
                    break;
                case 2:
                    MenuItems menuItems = new MenuItems();
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
    }
}