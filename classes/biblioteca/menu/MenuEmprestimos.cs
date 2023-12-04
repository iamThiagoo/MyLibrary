using trabalho_oop.classes.biblioteca.produtos;
using trabalho_oop.classes.usuarios;

namespace trabalho_oop.classes.biblioteca.menu
{
    public class MenuEmprestimos : Menu
    {
        private CadEmprestimos cadEmprestimos;
        private CadUsuarios cadUsuarios;
        private MenuOpcoes menuOpcoes;
        private Acervo acervo;

        public MenuEmprestimos(
            CadEmprestimos cadEmprestimos, 
            CadUsuarios cadUsuarios, 
            Acervo acervo, 
            MenuOpcoes menuOpcoes
        ){
            this.cadEmprestimos = cadEmprestimos;
            this.cadUsuarios = cadUsuarios;
            this.menuOpcoes = menuOpcoes;
            this.acervo = acervo;

            Opcoes();
        }

        public override void Opcoes()
        {
            Console.Clear();
            Titulo("Ações para Empréstimos");

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
            switch (opcao)
            {
                case 1:
                    Emprestimo? emprestimo = CadEmprestimo();
                    if (emprestimo != null) {
                        Console.WriteLine("\n ✅ Empréstimo realizado com sucesso!");
                    }
                    break;
                case 2:
                    cadEmprestimos.Atrasos(); // Atualiza possíveis atrasos
                    ListaEmprestimos();
                    break;
                case 3:
                    if(DevolucaoEmprestimo()) {
                        Console.WriteLine("\n ✅ Devolução realizada com sucesso!");
                    } else {
                        Console.WriteLine("\n ❌ Empréstimo não encontrado!");
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nAperte qualquer tecla para Voltar ao Menu de Items");
            Console.ReadKey();

            Opcoes();
        }

        public override void OpcaoInvalida()
        {
            Console.WriteLine("\nOpção inválida. Tente novamente!");
            Thread.Sleep(2000);
            Opcoes();
        }

        public Emprestimo? CadEmprestimo()
        {
            Console.Clear();
            Titulo("Cadastro de Empréstimo");

            Console.WriteLine("\nInforme a identificação do item:");
            int itemIdentificacao = EntradaDados.RetorneInteiro();
            ItemBiblioteca item = acervo.GetItemPorIdentificacao(itemIdentificacao);

            if (item == null || !acervo.ItemDisponivel(itemIdentificacao)) {
                Console.WriteLine("\n ❌ O item não existe ou não está disponível para empréstimo!");
                return null;
            }

            Console.WriteLine("\nInforme a matrícula do usuário:");
            string usuarioMatricula = Console.ReadLine()!;

            Usuario usuario = cadUsuarios.GetUsuariosPorMatricula(usuarioMatricula);
            if (usuario == null) {
                Console.WriteLine("\n ❌ O usuário não existe!");
                return null;
            }

            Console.WriteLine("\nInforme uma identificação para o empréstimo:");
            int identificacaoEmprestimo = EntradaDados.RetorneInteiro();

            Emprestimo emprestimo = new Emprestimo(identificacaoEmprestimo, cadEmprestimos);
            emprestimo.Emprestar(usuario, item, item.getPrazoEntrega());

            return emprestimo;
        }

        public void ListaEmprestimos()
        {
            Console.Clear();
            Titulo("Lista de Empréstimos");

            if (cadEmprestimos.Count() > 0) {
                foreach (Emprestimo emprestimo in cadEmprestimos.EmprestimosOrdenadosPorDataDevolucao()) {
                    Console.WriteLine(emprestimo.ToString());
                }
            } else {
                Console.WriteLine("\nNenhum empréstimo realizado!");
            }
        }

        public bool DevolucaoEmprestimo()
        {
            Console.Clear();
            Titulo("Devolução de Empréstimo");

            Console.WriteLine("\nInforme a identificação do item:");
            int emprestimoIdentificacao = EntradaDados.RetorneInteiro();
            Emprestimo emprestimo = cadEmprestimos.GetEmprestimoPorIdentificacao(emprestimoIdentificacao);

            if (emprestimo != null) {
                emprestimo.Retornar();
                return true;
            }

            return false;
        }
    }
}