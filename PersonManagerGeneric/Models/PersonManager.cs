namespace PersonManagerGeneric.Models;

public class PersonManager<T> where T : Person
{
    private readonly List<T> peopleList = new();

    // Méthode pour ajouter une personne à la liste
    public void AddPerson(T person)
    {
        peopleList.Add(person);
    }

    // Méthode pour afficher les informations de toutes les personnes dans la liste
    public void DisplayInformation()
    {
        foreach (T person in peopleList)
            // Utilisation de la méthode ToString() de la classe Personne
            Console.WriteLine(person.ToString());
    }
}