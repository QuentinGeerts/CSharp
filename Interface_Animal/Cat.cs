namespace Interface_Animal
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} fait Miou !");
        }
    }
}
