namespace Interface_Forme
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Créer un rectangle
            Rectangle rectangle = new Rectangle()
            {
                X = 10,
                Y = 20,
                Largeur = 30,
                Longueur = 40
            };

            // Appeler les méthodes définies dans les interfaces
            rectangle.Dessiner();
            rectangle.Deplacer();

            // Créer un cercle
            Cercle cercle = new Cercle()
            {
                X = 5,
                Y = 15,
                Rayon = 25
            };

            // Appeler les méthodes définies dans les interfaces
            cercle.Dessiner();

        }
    }
}