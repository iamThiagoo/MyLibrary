using System;
using System.IO;
using trabalho_oop.classes.biblioteca.produtos;

namespace trabalho_oop.classes.biblioteca
{
    public class Acervo
    {
        private List<ItemBiblioteca> items;

        public Acervo ()
        {
            items = new List<ItemBiblioteca>();
            AddItems();
        }

        public void AddItem(ItemBiblioteca item)
        {
            items.Add(item);
        }

        public ItemBiblioteca GetItemByIndex(int index)
        {
            ItemBiblioteca item = items[index];
            return item;
        }

        public int Count()
        {
            return items.Count;
        }

        public bool DeleteByIdentificacao(int identificacao)
        {
            if (items.Count > 0) {
                ItemBiblioteca item = items.FirstOrDefault(item => item.Identificacao == identificacao);

                if (item != null) {
                    items.Remove(item);
                    return true;
                }
            }

            return false;
        }

        public void AddItems()
        {
            string[] linhas = File.ReadAllLines("/examples/Acervo.txt");

            for (int i = 0; i < linhas.Length; i += 5)
            {
                string tipoItem = linhas[i];
                int identificacao = int.Parse(linhas[i + 1]);
                string titulo = linhas[i + 2];
                string detalhes = linhas[i + 3];
                int duracao = int.Parse(linhas[i + 4]);

                ItemBiblioteca item;

                if (tipoItem == "DVD") {
                    item = new DVD(identificacao, titulo, detalhes, duracao);
                    
                } else if (tipoItem == "Livro") {
                    string[] detalhesLivro = detalhes.Split(", ");
                    string autor = detalhesLivro[0];
                    string editora = detalhesLivro[1];
                    int paginas = int.Parse(detalhesLivro[2]);

                    item = new Livro(identificacao, titulo, autor, editora, paginas);

                } else {
                    string[] detalhesPeriodico = detalhes.Split(", ");
                    string periodicidade = detalhesPeriodico[0];
                    int numero = int.Parse(detalhesPeriodico[1]);
                    int ano = int.Parse(detalhesPeriodico[2]);

                    item = new Periodico(identificacao, titulo, periodicidade, numero, ano);
                }

                items.Add(item);
            }
        }
    }
}