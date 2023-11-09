namespace OneDotPerLine;

public class Program
{
    static void Main(string[] args)
    {
        var _listaItems = new ListaItem();

        _listaItems.AdicionarListaItemComCategoria(new ListaItem());
        var _listaComCategoria = _listaItems.ListaIemComCategoria();
        _listaComCategoria.AdicionarItemALista(new Item());

        /*
        _listaItems._items.Add(new ListaItem());
        _listaItems._items.Where(x => Categoria.Id == 1).FirstOrDefault()._items.Add(new Item());
        */
    }
}

public class ListaItem
{
    public int Categoria { get; set; }

    public List<ListaItem> _items { get; private set; }

    public Item Item { get; set; }

    public void AdicionarListaItemComCategoria(ListaItem listaItem) => _items.Add(listaItem);


    public ListaItem ListaIemComCategoria(int id) => _items.Where(x => Categoria.Id == id).FirstOrDefault();

    public void AdicionarItemALista (Item item) => _items.Add(item);
    

}

/*
public class ListaItem
{
    public int Categoria { get; set; }

    public List<ListaItem> _items { get; set; }

    public Item Item { get; set; }

}
*/
public class Item
{
    public Guid Id { get; set; }

    public string Titulo { get; set; }

    public DateTime DataCriacao { get; private set; }

    public Item() => DataCriacao = DateTime.Now;
}