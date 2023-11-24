using System;

namespace trabalho_oop.classes.biblioteca
{
    public class Acervo
    {
        private List<ItemBiblioteca> items;

        public Acervo ()
        {
            items = new List<ItemBiblioteca>();;
        }

        public string addItem(ItemBiblioteca item)
        {
            items.Add(item);
        }

        public ItemBiblioteca getItemByIndex(int index)
        {
            ItemBiblioteca item = items[index];
            return item;
        }

        public int count()
        {
            return items.Count();
        }

        public bool deleteByIdentificacao(int identificacao)
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