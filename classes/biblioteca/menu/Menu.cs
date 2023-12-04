namespace trabalho_oop.classes.biblioteca.menu
{
    abstract public class Menu 
    {
        public abstract void Opcoes();
        public abstract void ExecutaOpcao(int opcao);
        public abstract void OpcaoInvalida();

        public static void Titulo(string titulo)
        {
            Console.WriteLine(new string('-', 72));
            Console.WriteLine(
                new string('-', (72 - titulo.Length) / 2) +
                " " + titulo + " " +
                new string('-', 72 - (72 - titulo.Length) / 2 - titulo.Length - 2)
            );
            Console.WriteLine(new string('-', 72));
        }

        public static void Logo()
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