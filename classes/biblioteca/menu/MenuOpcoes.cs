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

            Opcoes();
        }

        public override void Opcoes()
        {
            Console.Clear();
            
            Logo();
            Titulo("Seja bem-vindo ao MyLibrary");

            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Listar ações para Usuários");
            Console.WriteLine("2 - Listar ações para Itens");
            Console.WriteLine("3 - Listar ações para Empréstimos");
            Console.WriteLine("0 - Logout/Sair");

            string resposta = Console.ReadLine()!;
            int opcao;

            while(!int.TryParse(resposta, out opcao) || (opcao < 0 || opcao > 3)) {
                OpcaoInvalida();
                return;
            }

            ExecutaOpcao(opcao);
        }

        public override void ExecutaOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    MenuUsuarios menuUsuarios = new MenuUsuarios(cadUsuarios, cadEmprestimos, this);
                    break;
                case 2:
                    MenuItems menuItems = new MenuItems(acervo, this);
                    break;
                case 3:
                    MenuEmprestimos menuEmprestimos = new MenuEmprestimos(cadEmprestimos, cadUsuarios, acervo, this);
                    break;
                default:
                    Logout();
                    break;
            }
        }

        public override void OpcaoInvalida()
        {
            Console.WriteLine("\nOpção inválida. Tente novamente!");
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