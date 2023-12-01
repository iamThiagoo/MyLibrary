using System;
using trabalho_oop.classes.biblioteca.produtos;

namespace trabalho_oop.classes.biblioteca
{
    public class Acervo
    {
        private List<ItemBiblioteca> items;

        public Acervo ()
        {
            items = new List<ItemBiblioteca>();;
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
            return items.Count();
        }

        public bool DeleteByIdentificacao(int identificacao)
        {
            ItemBiblioteca item = items.FirstOrDefault(item => item.Identificacao == identificacao);

            if (item != null) {
                items.Remove(item);
                return true;
            }

            return false;
        }
    }
}