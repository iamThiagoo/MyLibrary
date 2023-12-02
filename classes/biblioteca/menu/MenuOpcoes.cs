using trabalho_oop.classes.usuarios;

namespace trabalho_oop.classes.biblioteca.menu
{
    public class MenuOpcoes : Menu
    {
        private Acervo acervo;
        private CadUsuarios cadUsuarios;
        private CadEmprestimos cadEmprestimos;

        public MenuOpcoes()
        {
            acervo = new Acervo();
            cadUsuarios = new CadUsuarios();
            cadEmprestimos = new CadEmprestimos();

            Console.Clear();

            Logo();
            MenuTitulo("Seja bem-vindo ao MyLibrary");
            Opcoes();

            while (true) {
                string resposta = Console.ReadLine()!;

                if (int.TryParse(resposta, out int opcao)) {
                    if (opcao >= 0 && opcao <= 3) {
                        ExecutaOpcao(opcao);
                        break;
                    }
                    else {
                        OpcaoInvalida();
                    }
                }
                else {
                    OpcaoInvalida();
                }
            }
        }

        public override void Opcoes()
        {
            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Listar ações para usuários");
            Console.WriteLine("2 - Listar ações para itens");
            Console.WriteLine("3 - Listar ações para Empréstimos");
            Console.WriteLine("0 - Logout/Sair");
        }

        public override void ExecutaOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    MenuUsuarios menuUsuarios = new MenuUsuarios(cadUsuarios);
                    break;
                case 2:
                    MenuItems menuItems = new MenuItems(acervo);
                    break;
                case 3:
                    MenuEmprestimos menuEmprestimos = new MenuEmprestimos(cadEmprestimos);
                    break;
                default:
                    Logout();
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

        public void Logout()
        {
            Console.Clear();
            Console.WriteLine("Até a próxima! :) \n");
            return;
        }
    }
}