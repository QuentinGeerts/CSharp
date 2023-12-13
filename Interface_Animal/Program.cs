namespace Interface_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création des instances d'animaux
            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.Name = "Noirau";
            dog.Name = "Snoopy";


            Console.WriteLine($"${cat.Name} fait un bruit : ");
            cat.MakeSound();

            Console.WriteLine($"${dog.Name} fait un bruit : ");
            dog.MakeSound();

        }
    }
}