namespace PersonManagerGeneric.Models;

public class PersonManager<T> where T : Person
{
    private readonly List<T> _peopleList = new(); // Type Inference depuis C# 9.0

    // Méthode pour ajouter une personne à la liste
    public void AddPerson(T person)
    {
        _peopleList.Add(person);
    }

    // Méthode pour afficher les informations de toutes les personnes dans la liste
    public void DisplayInformation()
    {
        foreach (var person in _peopleList)
            // Utilisation de la méthode ToString() de la classe Personne
            Console.WriteLine(person.ToString());
    }
}