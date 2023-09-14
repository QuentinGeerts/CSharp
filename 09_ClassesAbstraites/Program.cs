namespace _09_ClassesAbstraites
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Personne personne = new Personne();
            //personne.Nom = "PersonneName";
            //personne.Prenom = "PersonneFirstName";
            //personne.Parler();
            //personne.Ecouter();

            var homme = new Homme();
            homme.Nom = "HommeName";
            homme.Prenom = "HommeFirstName";
            homme.Parler();
            homme.SeRaser();
            homme.Ecouter();

            var femme = new Femme();
            femme.Nom = "femmeName";
            femme.Prenom = "femmeFirstName";
            femme.Parler();
            femme.Accoucher();
            femme.Ecouter();
        }
    }
}