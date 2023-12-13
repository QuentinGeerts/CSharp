namespace Interface_Animal
{
    public interface IAnimal
    {
        // Propriété pour obtenir le nom de l'animal
        string Name { get; }

        // Méthode pour émettre un son propre à l'animal
        void MakeSound();
    }
}
