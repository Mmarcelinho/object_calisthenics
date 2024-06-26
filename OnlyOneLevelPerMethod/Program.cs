﻿namespace OnlyOneLevelPerMethod;

/*
Refatorando para otimizar a legibilidade e reduzir a profundidade de indentação ao criar um método de busca.
Ao agrupar operações relacionadas, melhoramos a organização e a compreensão do código.
*/
public class Program
{
    public void VerificarItem(List<ListaItem> listaItems)
    {
        foreach (var listaItems in listaItems)
        {

            //Código...

            foreach (var item in listaItems._items)
            {
                //Código...
                VerificarItemEmListaItem(item);
            }
        }
    }

    private void VerificarItemEmListaItem(ListaItem listaItem)
    {
        foreach (var item in listaItem)
        {
            //Código...
        }
    }

    /*
    public void VerificarItem(List<ListaItem> listaItems)
    {
        foreach (var listaItems in listaItems)
        {

            //Código...

            foreach (var item in listaItems._items)
            {
                //Código...
            }
        }
    }
    */
}

public class ListaItem
{
    public List<ListaItem> _items { get; set; }

    public Item Item { get; set; }
}

public class Item
{
    public Guid Id { get; set; }
    public string Titulo { get; set; }
}


