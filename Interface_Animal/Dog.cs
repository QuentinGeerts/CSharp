namespace Interface_Animal
{
    internal class Dog : IAnimal
    {
        public string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} fait Wouaf");
        }
    }
}
