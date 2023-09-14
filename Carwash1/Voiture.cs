namespace Carwash1
{
    internal class Voiture
    {
        public Voiture(string plaque)
        {
            Plaque = plaque;
        }

        // Se mettre sur la ligne de la propriétés => Alt + enter => Générer le constructeur
        public string Plaque { get; private set; }
    }
}