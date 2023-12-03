namespace trabalho_oop.classes.biblioteca.menu
{
    public class MenuEmprestimos : Menu
    {
        private CadEmprestimos cadEmprestimos;
        private MenuOpcoes menuOpcoes;

        public MenuEmprestimos(CadEmprestimos cadEmprestimos, MenuOpcoes menuOpcoes)
        {
            this.cadEmprestimos = cadEmprestimos;
            this.menuOpcoes = menuOpcoes;

            Opcoes();
        }

        public override void Opcoes()
        {
            Console.Clear();
            MenuTitulo("Ações para Empréstimos");

            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Cadastrar novo Empréstimo");
            Console.WriteLine("2 - Listar todos os Empréstimos (ordenado por Data de Devolução)");
            Console.WriteLine("3 - Registrar devolução de Empréstimo");
            Console.WriteLine("V - Voltar para Menu Principal");

            string resposta = Console.ReadLine()!;
            int opcao;

            if (resposta.Equals("V", StringComparison.OrdinalIgnoreCase)) {
                menuOpcoes.Opcoes();
                return;
            }

            while(!int.TryParse(resposta, out opcao) || (opcao < 0 && opcao > 3)) {
                OpcaoInvalida();
                return;
            }    

            ExecutaOpcao(opcao);
        }

        public override void ExecutaOpcao(int opcao)
        {
            Console.WriteLine("oi");
        }

        public override void OpcaoInvalida()
        {
            Console.WriteLine("\nOpção inválida. Tente novamente!");
            Thread.Sleep(2000);
            Opcoes();
        }

        //public Emprestimo CadEmprestimo()
        //{
        //    Console.Clear();
        //    MenuTitulo("Cadastro de Empréstimo");

        //    Console.WriteLine("\nInforme a identificação do item a ser emprestado:");
        //    string identificacao = Console.ReadLine()!;
        //}
    }
}