using System;

namespace trabalho_oop.classes.biblioteca.menu
{
    class MenuOpcoes
    {
        public MenuOpcoes()
        {
            Logo();
            MenuTitulo("Seja bem-vindo ao MyLibrary");
            MenuPrincipal();

            string resposta = Console.ReadLine()!;
            int opcao;

            while(!int.TryParse(resposta, out opcao)) {
                if (opcao < 0 && opcao > 3) {
                    OpcaoMenuInvalido("Menu Principal");
                }
            }

            Console.Clear();

            switch (opcao) {
                case 1:
                    MenuTitulo("Ações para Usuários");
                    MenuUsuarios();
                    break;
                case 2:
                    MenuTitulo("Ações para Items");
                    MenuItems();
                    break;
                case 3:
                    MenuTitulo("Ações para Empréstimos");
                    MenuEmprestimos();
                    break;
                default:
                    Logout();
                    break;
            }
        }

        static void MenuPrincipal()
        {
            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Listar ações para usuários");
            Console.WriteLine("2 - Listar ações para itens");
            Console.WriteLine("3 - Listar ações para Empréstimos");
            Console.WriteLine("0 - Logout/Sair");
        }

        static void MenuUsuarios()
        {
            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar todos os usuários cadastrados");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("V - Voltar para Menu Principal");
        }

        static void MenuItems()
        {
            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Cadastrar novo Item");
            Console.WriteLine("2 - Listar todos os Livros (com status de: Disponível, Emprestado, Atrasado e Bloqueado)");
            Console.WriteLine("3 - Listar todos os Períodicos (com status de: Disponível, Emprestado, Atrasado e Bloqueado)");
            Console.WriteLine("4 - Listar todos os DVD's (com status de: Disponível, Emprestado, Atrasado e Bloqueado)");
            Console.WriteLine("4 - Excluir um item");
            Console.WriteLine("V - Voltar para Menu Principal");
        }

        static void MenuEmprestimos()
        {
            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Cadastrar novo Empréstimo");
            Console.WriteLine("2 - Listar todos os Empréstimos (ordenado por Data de Devolução)");
            Console.WriteLine("3 - Registrar devolução de Empréstimo");
            Console.WriteLine("V - Voltar para Menu Principal");
        }

        public void MenuTitulo(string titulo)
        {
            Console.WriteLine(new string('-', 72));
            Console.WriteLine(
                new string('-', (72 - titulo.Length) / 2) +
                " " + titulo + " " +
                new string('-', 72 - (72 - titulo.Length) / 2 - titulo.Length - 2)
            );
            Console.WriteLine(new string('-', 72));
        }

        static void Logout()
        {
            Console.WriteLine("\n\nAté a próxima! :)");
            return;
        }

        static void OpcaoMenuInvalido(string mostraMenu)
        {
            Console.WriteLine("\nOpção inválida. Tente novamente!");
            Thread.Sleep(4000);
            Console.Clear();

            if (mostraMenu == "Menu Principal") {
                MenuPrincipal();
            }
        }


        static void Logo()
        {
            Console.WriteLine(@"
███╗░░░███╗██╗░░░██╗██╗░░░░░██╗██████╗░██████╗░░█████╗░██████╗░██╗░░░██╗
████╗░████║╚██╗░██╔╝██║░░░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗░██╔╝
██╔████╔██║░╚████╔╝░██║░░░░░██║██████╦╝██████╔╝███████║██████╔╝░╚████╔╝░
██║╚██╔╝██║░░╚██╔╝░░██║░░░░░██║██╔══██╗██╔══██╗██╔══██║██╔══██╗░░╚██╔╝░░
██║░╚═╝░██║░░░██║░░░███████╗██║██████╦╝██║░░██║██║░░██║██║░░██║░░░██║░░░
╚═╝░░░░░╚═╝░░░╚═╝░░░╚══════╝╚═╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░
            ");
        }
    }
}