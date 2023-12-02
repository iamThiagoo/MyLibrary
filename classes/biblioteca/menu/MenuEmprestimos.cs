using trabalho_oop.interfaces;

namespace trabalho_oop.classes.biblioteca.menu
{
    public class MenuEmprestimos : Menu
    {
        private CadEmprestimos cadEmprestimos;

        public MenuEmprestimos(CadEmprestimos cadEmprestimos)
        {
            Console.Clear();
            MenuTitulo("Ações para Empréstimos");
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

            this.cadEmprestimos = cadEmprestimos;
            ExecutaOpcao(opcao);
        }

        public override void Opcoes()
        {
            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Cadastrar novo Empréstimo");
            Console.WriteLine("2 - Listar todos os Empréstimos (ordenado por Data de Devolução)");
            Console.WriteLine("3 - Registrar devolução de Empréstimo");
            Console.WriteLine("V - Voltar para Menu Principal");
        }

        public override void ExecutaOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Emprestimo emprestimo = CadEmprestimo();
                    cadEmprestimos.AddEmprestimo(emprestimo);

                    Console.WriteLine("\n ✅ Empréstimo realizado com sucesso!");
                    
                    Console.WriteLine("\nAperte qualquer tecla para Voltar ao Menu de Usuários");
                    Console.ReadKey();

                    Console.Clear();
                    Opcoes();

                    break;
                case 2:
                    break;
                case 3:
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

        public Emprestimo CadEmprestimo()
        {
            Console.Clear();
            MenuTitulo("Cadastro de Empréstimo");

            Console.WriteLine("\nInforme a identificação do item a ser emprestado:");
            string identificacao = Console.ReadLine()!;
        }
    }
}