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

            switch (opcao) {
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