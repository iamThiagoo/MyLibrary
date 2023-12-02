namespace trabalho_oop.classes.biblioteca.menu
{
    public class EntradaDados
    {
        public static int RetorneInteiro(string mensagem)
        {
            string aux;
            int n = 0;
            bool ok;

            do {
                ok = true;
                Console.WriteLine(mensagem);
                aux = Console.ReadLine()!;
                
                if (!int.TryParse(aux, out n)) {
                    ok = false;
                }
                if (ok == false) {
                    Console.WriteLine("Entrada inválida! Digite Novamente!");
                }

            } while (ok == false);

            return n;
        }

        public static int RetorneIntei(string mensagem, int min, int max)
        {
            string aux;
            int n = 0;
            bool ok;

            do {
                ok = true;
                Console.WriteLine(mensagem);
                aux = Console.ReadLine()!;

                if (!int.TryParse(aux, out n)) {
                    ok = false;
                }

                if ((n < min) || (n > max)) {
                    ok = false;
                }

                if (ok == false) {
                    Console.WriteLine("Entrada inválida! Digite Novamente!");
                }
            } while (ok == false);

            return n;
        }

        public static double RetorneDouble(string mensagem)
        {
            string aux;
            double n = 0;
            bool ok;

            do {
                ok = true;
                Console.WriteLine(mensagem);
                aux = Console.ReadLine()!;
                if (!double.TryParse(aux, out n))
                {
                    ok = false;
                }
                if (ok == false) {
                    Console.WriteLine("Entrada inválida! Digite Novamente!");
                }
            } while (ok == false);

            return n;
        }

        public static char RetorneChar(string mensagem)
        {
            string aux;
            char c = ' ';
            bool ok;
            
            do {
                ok = true;
                Console.WriteLine(mensagem);
                aux = Console.ReadLine()!;

                if (!char.TryParse(aux, out c)) {
                    ok = false;
                }
                if (ok == false) {
                    Console.WriteLine("Entrada inválida! Digite Novamente!");
                }
            } while (ok == false);

            return c;
        }

        public static string RetorneString(string mensagem)
        {
            string aux;
            Console.WriteLine(mensagem);
            aux = Console.ReadLine()!;
            return aux;
        }
    }
}