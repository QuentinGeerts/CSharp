namespace _09_ClassesAbstraites
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personne personne = new Personne();
            //personne.Nom = "PersonneName";
            //personne.Prenom = "PersonneFirstName";
            //personne.Parler();
            //personne.Ecouter();

            Homme homme = new Homme();
            homme.Nom = "HommeName";
            homme.Prenom = "HommeFirstName";
            homme.Parler();
            homme.SeRaser();
            homme.Ecouter();

            Femme femme = new Femme();
            femme.Nom = "femmeName";
            femme.Prenom = "femmeFirstName";
            femme.Parler();
            femme.Accoucher();
            femme.Ecouter();
        }
    }
}
