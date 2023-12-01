// Classe que gerencia uma coleção de ItemBiblioteca
public class Biblioteca
{
    // Coleção de itens
    private List<ItemBiblioteca> itens;

    // Construtor
    public Biblioteca()
    {
        itens = new List<ItemBiblioteca>();
    }

    // Método para adicionar um item
    public void AdicionarItem(ItemBiblioteca item)
    {
        itens.Add(item);
        Console.WriteLine($"{item.Titulo} foi adicionado à biblioteca.");
    }

    // Método para remover um item
    public void RemoverItem(ItemBiblioteca item)
    {
        itens.Remove(item);
        Console.WriteLine($"{item.Titulo} foi removido da biblioteca.");
    }

    // Métodos com sobrecarga para buscar um item por título ou por ID
    public ItemBiblioteca BuscarItemPorTitulo(string titulo)
    {
        ItemBiblioteca itemEncontrado = itens.Find(item => item.Titulo == titulo);

        if (itemEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado por título: {itemEncontrado.Titulo}");
        }
        else
        {
            Console.WriteLine("Livro não encontrado por título.");
        }

        return itemEncontrado;
    }

    public ItemBiblioteca BuscarItemPorId(int id)
    {
        ItemBiblioteca itemEncontrado = itens.Find(item => item.Id == id);

        if (itemEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado por ID: {itemEncontrado.Titulo}");
        }
        else
        {
            Console.WriteLine("Livro não encontrado por ID.");
        }

        return itemEncontrado;
    }
}
