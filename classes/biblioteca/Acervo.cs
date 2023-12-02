using System;
using System.IO;
using trabalho_oop.classes.biblioteca.produtos;

namespace trabalho_oop.classes.biblioteca
{
    public class Acervo
    {
        private const ItemBiblioteca value = null!;
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
                ItemBiblioteca item = items.FirstOrDefault(item => item.Identificacao == identificacao)!;

                if (item != null) {
                    items.Remove(item);
                    return true;
                }
            }

            return false;
        }

        public void AddItems()
        {
            string[] linhas = File.ReadAllLines("examples/Acervo.txt");

            for (int i = 0; i < linhas.Length; i += 5){
                string tipoItem = linhas[i];
                ItemBiblioteca item = null!;

                if (tipoItem == "DVD") {
                    int identificacao = int.Parse(linhas[i + 1]);
                    string titulo = linhas[i + 2];
                    string detalhes = linhas[i + 3];
                    int duracao = int.Parse(linhas[i + 4]);

                    item = new DVD(identificacao, titulo, detalhes, duracao);
                }
                else if (tipoItem == "Livro") {
                    int identificacao = int.Parse(linhas[i + 1]);
                    string titulo = linhas[i + 2];
                    string autor = linhas[i + 3];
                    string editora = linhas[i + 4];
                    int paginas = int.Parse(linhas[i + 5]);

                    item = new Livro(identificacao, titulo, autor, editora, paginas);
                    i++; // Pula uma linha extra para o formato do Livro
                } else if (tipoItem == "Periódico") {
                    int identificacao = int.Parse(linhas[i + 1]);
                    string titulo = linhas[i + 2];
                    string periodicidade = linhas[i + 3];
                    int numero = int.Parse(linhas[i + 4]);
                    int ano = int.Parse(linhas[i + 5]);

                    item = new Periodico(identificacao, titulo, periodicidade, numero, ano);
                    i++; // Pula uma linha extra para o formato do Periódico
                }

                if (item != null) {
                    items.Add(item);
                }
            }
        }
    }
}