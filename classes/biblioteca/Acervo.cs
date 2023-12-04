using trabalho_oop.classes.biblioteca.produtos;

namespace trabalho_oop.classes.biblioteca
{
    public class Acervo
    {
        private List<ItemBiblioteca> items;

        public Acervo ()
        {
            items = new List<ItemBiblioteca>();
            AddItemsExemplos();
        }

        public void AddItem(ItemBiblioteca item)
        {
            items.Add(item);
        }

        public int Count()
        {
            return items.Count;
        }

        public ItemBiblioteca GetItemPorIndice(int index)
        {
            ItemBiblioteca item = items[index];
            return item;
        }

        public ItemBiblioteca GetItemPorIdentificacao(int identificacao)
        {
            return items.FirstOrDefault(item => item.Identificacao == identificacao)!;
        }

        public bool RemoveItemPorIdentificacao(int identificacao)
        {
            if (items.Count > 0) {
                ItemBiblioteca item = items.FirstOrDefault(item => item.Identificacao == identificacao)!;

                if (item != null && item.Situacao == "Disponivel") {
                    items.Remove(item);
                    return true;
                }
            }

            return false;
        }

        public bool ItemDisponivel(int identificacao)
        {
            if (items.Count > 0) {
                ItemBiblioteca item = items.FirstOrDefault(item => item.Identificacao == identificacao)!;

                if (item != null && item.Situacao == "Disponivel") {
                    return true;
                }
            }

            return false;
        }

        public void AddItemsExemplos()
        {
            string[] linhas = File.ReadAllLines("exemplos/Acervo.txt");
            int lineIndex = 0;

            while (lineIndex < linhas.Length)
            {
                string tipoItem = linhas[lineIndex];
                ItemBiblioteca item = null!;

                lineIndex++; // Avança para os detalhes do item

                if (tipoItem == "DVD")
                {
                    int identificacao = int.Parse(linhas[lineIndex++]);
                    string titulo = linhas[lineIndex++];
                    string detalhes = linhas[lineIndex++];
                    int duracao = int.Parse(linhas[lineIndex++]);

                    item = new DVD(identificacao, titulo, detalhes, duracao);
                }
                else if (tipoItem == "Livro")
                {
                    int identificacao = int.Parse(linhas[lineIndex++]);
                    string titulo = linhas[lineIndex++];
                    string autor = linhas[lineIndex++];
                    string editora = linhas[lineIndex++];
                    int paginas = int.Parse(linhas[lineIndex++]);

                    item = new Livro(identificacao, titulo, autor, editora, paginas);
                }
                else if (tipoItem == "Periódico")
                {
                    int identificacao = int.Parse(linhas[lineIndex++]);
                    string titulo = linhas[lineIndex++];
                    string periodicidade = linhas[lineIndex++];
                    int numero = int.Parse(linhas[lineIndex++]);
                    int ano = int.Parse(linhas[lineIndex++]);

                    item = new Periodico(identificacao, titulo, periodicidade, numero, ano);
                }

                if (item != null)
                {
                    items.Add(item);
                }

                lineIndex++; // Avança para a próxima linha em branco (se houver)
            }
        }
    }
}