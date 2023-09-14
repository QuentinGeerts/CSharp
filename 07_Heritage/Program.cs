namespace _07_Heritage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var forme = new Forme();
            forme.Dessine();

            var rectangle = new Rectangle();
            rectangle.Dessine();

            var carre = new Carre();
            carre.Dessine();
        }
    }
}