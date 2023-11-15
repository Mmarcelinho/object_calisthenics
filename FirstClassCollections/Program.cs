namespace FirstClassCollections;

/*
Implementando uma lista personalizada para armazenar instâncias de ListaItemCategoria.
*/
public class Program
{
   public void Main(string[] args)
   {
     var ListaItemCategoria = new ListaItemCategoria();

        var listaItem = new ListaItem();
        listaDeRegistros.Add(ListaItemCategoria);

        var listaItem2 = new ListaItem2();
        listaItem2.Add(ListaItemCategoria);
   }
}

public class ListaItem : IList<ListaItemCategoria>
{
    private List<ListaItemCategoria> _items;

    public ListaItemCategoria this[int index] { get => _items[index]; set => _items[index] = value; }

    public int Count => _items.Count;

    public bool IsReadOnly => false;

    public void Add(ListaItemCategoria item)
    {
        // Possíveis implementações e regras

        _items.Add(item);
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(ListaItemCategoria item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(ListaItemCategoria[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<ListaItemCategoria> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public int IndexOf(ListaItemCategoria item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, ListaItemCategoria item)
    {
        throw new NotImplementedException();
    }

    public bool Remove(ListaItemCategoria item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public class ListaItem2
{
      public List<ListaItemCategoria> _items { get; private set; }
    public int Count => _items.Count;

    public void Add(ListaItem item)
    {
        // Código...

        _items.Add(item);
    }

    public void Clear()
    {
        _items.Clear();
    }

    public bool Contains(ListaItem item)
    {
        return _items.Contains(item);
    }
}

public class ListaItemCategoria
{
    public int Categoria { get; set; }

    public List<ListaItemCategoria> Item { get; private set; }

    public Item Item { get; set; }


}

public class Item
{
    public Guid Id { get; set; }

    public string Titulo { get; set; }

    public DateTime DataCriacao { get; private set; }

    public Item() => DataCriacao = DateTime.Now;
}

