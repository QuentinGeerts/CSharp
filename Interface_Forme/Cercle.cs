namespace Interface_Forme
{
    internal class Cercle : Forme, IDessinable
    {
        public int Rayon { get; set; }

        public void Dessiner()
        {
            Console.WriteLine("Dessiner un cercle");
        }
    }
}
