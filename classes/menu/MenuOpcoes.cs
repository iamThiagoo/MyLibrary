using System;

namespace trabalho_oop.classes.menu
{
    class MenuOpcoes 
    {
        public MenuOpcoes() 
        {
            Logo();
            MenuTitulo("Seja bem-vindo ao MyLibrary");
            ListaOpcoes();
        }

        static void ListaOpcoes() 
        {
            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Listar livros");
            Console.WriteLine("2 - Listar livros");
            Console.WriteLine("3 - Listar livros");
            Console.WriteLine("4 - Listar livros");
            Console.WriteLine("5 - Listar livros");
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