namespace Interface_Forme
{
    internal class Rectangle : Forme, IDessinable, IDeplacable
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public void Deplacer()
        {
            Console.WriteLine("Déplacer un rectangle");
        }

        public void Dessiner()
        {
            Console.WriteLine("Dessiner un rectangle");
        }
    }
}
