using trabalho_oop.classes.biblioteca.produtos;
using trabalho_oop.interfaces;

namespace trabalho_oop.classes.biblioteca.menu
{
    public class MenuItems : Menu
    {
        private Acervo acervo;

        public MenuItems(Acervo acervo)
        {
            Console.Clear();
            MenuTitulo("Ações para Items");
            Opcoes();

            string resposta = Console.ReadLine()!;
            int opcao;

            if (resposta.Equals("V", StringComparison.OrdinalIgnoreCase)) {
                MenuOpcoes menu = new MenuOpcoes();
                return;
            }

            while (!int.TryParse(resposta, out opcao)) {
                if (opcao < 0 && opcao > 3) {
                    OpcaoInvalida();
                }
            }

            this.acervo = acervo;
            ExecutaOpcao(opcao);
        }

        public override void Opcoes()
        {
            Console.WriteLine("\nSelecione entre as opções disponíveis:\n");

            Console.WriteLine("1 - Cadastrar novo Item");
            Console.WriteLine("2 - Listar todos os Livros (com status de: Disponível, Emprestado, Atrasado e Bloqueado)");
            Console.WriteLine("3 - Listar todos os Períodicos (com status de: Disponível, Emprestado, Atrasado e Bloqueado)");
            Console.WriteLine("4 - Listar todos os DVD's (com status de: Disponível, Emprestado, Atrasado e Bloqueado)");
            Console.WriteLine("5 - Excluir um item");
            Console.WriteLine("V - Voltar para Menu Principal");
        }

        public override void ExecutaOpcao(int opcao)
        {
            switch (opcao) {
                case 1:
                    ItemBiblioteca item = CadItem();
                    acervo.AddItem(item);
                    Console.WriteLine("\n ✅ Item adicionado ao Acervo com sucesso!");
                    break;
                case 2:
                    ListaItems("Livros");
                    break;
                case 3:
                    ListaItems("Periódicos");
                    break;
                case 4:
                    ListaItems("DVD");
                    break;
                case 5:
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nAperte qualquer tecla para Voltar ao Menu de Items");
            Console.ReadKey();

            Console.Clear();
            Opcoes();
        }

        public override void OpcaoInvalida()
        {
            Console.WriteLine("\nOpção inválida. Tente novamente:");
            Thread.Sleep(2000);
            Console.Clear();
            Opcoes();
        }

        public ItemBiblioteca CadItem()
        {
            Console.Clear();
            MenuTitulo("Cadastro de Item");
            string itemTipo;

            while(true) {
                Console.WriteLine("\nQual o tipo do item: (Livro, Periódico ou DVD)");
                string[] tipos = {"Livro", "Periódico", "DVD"};

                itemTipo = Console.ReadLine()!;
                if (tipos.Contains(itemTipo)) {
                    break;
                } else {
                    Console.WriteLine("\nOpção inválida. Tente novamente:");
                }
            }

            ItemBiblioteca item;

            if (itemTipo == "Livro") {
                item = CadItemLivro();

            } else if (itemTipo == "DVD") {
                item = CadItemDVD();
                
            } else {
                item = CadItemPeriodico();
            }

            return item;
        }

        public Livro CadItemLivro() 
        {
            Console.Clear();
            MenuTitulo("Cadastro de Item - Livro");

            Console.WriteLine("\nInsira uma identificação ao item:");
            int identificacao =EntradaDados.RetorneInteiro();

            Console.WriteLine("\nInsira o título do item:");
            string titulo = Console.ReadLine()!;

            Console.WriteLine("\nInsira o autor do item:");
            string autor = Console.ReadLine()!;

            Console.WriteLine("\nInsira a editora do item:");
            string editora = Console.ReadLine()!;

            Console.WriteLine("\nInsira o número de páginas:");
            int numeroPaginas = EntradaDados.RetorneInteiro();

            Livro livro = new Livro(identificacao, titulo, autor, editora, numeroPaginas);

            return livro;
        }

        public DVD CadItemDVD() 
        {
            Console.Clear();
            MenuTitulo("Cadastro de Item - DVD");

            Console.WriteLine("\nInsira uma identificação ao item:");
            int identificacao = EntradaDados.RetorneInteiro()!;

            Console.WriteLine("\nInsira o título do item:");
            string titulo = Console.ReadLine()!;

            Console.WriteLine("\nInsira o assunto do item:");
            string assunto = Console.ReadLine()!;

            Console.WriteLine("\nInsira a duração do item:");
            int duracao = EntradaDados.RetorneInteiro();

            DVD dvd = new DVD(identificacao, titulo, assunto, duracao);

            return dvd;
        }

        public Periodico CadItemPeriodico() 
        {
            Console.Clear();
            MenuTitulo("Cadastro de Item - Revista/Periódico");

            Console.WriteLine("\nInsira uma identificação ao item:");
            int identificacao = EntradaDados.RetorneInteiro();

            Console.WriteLine("\nInsira o título do item:");
            string titulo = Console.ReadLine()!;

            Console.WriteLine("\nInsira a periodicidade do item: ()");
            string periodicidade = Console.ReadLine()!;

            Console.WriteLine("\nInsira o número do item:");
            int numero = EntradaDados.RetorneInteiro();

            Console.WriteLine("\nInsira o ano do item:");
            int ano = EntradaDados.RetorneInteiro();

            Periodico periodico = new Periodico(identificacao, titulo, periodicidade, numero, ano);

            return periodico;
        }

        public void ListaItems(string tipoItem)
        {
            if (acervo.Count() > 0) {
                
                for(int i = 0; i < acervo.Count(); i++) {
                    ItemBiblioteca item = acervo.GetItemByIndex(i);
                
                    if (
                        (tipoItem == "DVD" && item.GetType() == typeof(DVD)) ||
                        (tipoItem == "Livro" && item.GetType() == typeof(Livro)) ||
                        (tipoItem == "Periodico" && item.GetType() == typeof(Periodico))
                    ){
                        Console.WriteLine(item.ToString());
                    }
                }

            } else {
                Console.WriteLine("\nNenhum item adicionado!");
            }
        }
    }
}