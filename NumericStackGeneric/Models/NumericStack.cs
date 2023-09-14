namespace NumericStackGeneric.Models;

// Définition d'une classe générique NumericStack avec une contrainte sur T
public class NumericStack<T> where T : struct
{
    private List<T> elements = new List<T>();

    // Méthode Push pour ajouter un élément à la pile
    public void Push(T item)
    {
        elements.Add(item);
    }
    
    // Méthode Pop pour supprimer et renvoyer un élément de la pile
    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("La pile est vide.");
        }

        T poppedElement = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return poppedElement;
    }

    // Méthode Count pour obtenir le nombre d'éléments dans la pile
    public int Count()
    {
        return elements.Count;
    }
}