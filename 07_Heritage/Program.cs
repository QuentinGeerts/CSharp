namespace _07_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Forme forme = new Forme();
            forme.Dessine();

            Rectangle rectangle = new Rectangle();
            rectangle.Dessine();

            Carre carre = new Carre();
            carre.Dessine();
        }
    }
}
