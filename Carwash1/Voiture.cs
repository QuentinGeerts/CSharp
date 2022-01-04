namespace Carwash1
{
    class Voiture
    {
        // Se mettre sur la ligne de la propriétés => Alt + enter => Générer le constructeur
        public string Plaque { get; private set; }

        public Voiture(string plaque)
        {
            Plaque = plaque;
        }
    }
}