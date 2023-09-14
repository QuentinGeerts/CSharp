namespace _11_Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Point p1 = new Point() { X = 5, Y = 5 };
            //p1.Display();
            //p1.Draw();

            //IPoint p2 = new Point() { X = 5, Y = 3 };
            //p2.Display();
            ////p2.Draw();

            var voiture = new Voiture();
            voiture.Rouler();
            voiture.Tourner();

            var bateau = new Bateau();
            bateau.Naviguer();
            bateau.Tourner();

            var vehiculeAmphibie = new VehiculeAmphibie();
            vehiculeAmphibie.Naviguer();
            vehiculeAmphibie.Tourner();
            vehiculeAmphibie.Rouler();

            IBateau bateau1 = new VehiculeAmphibie();
            bateau1.Naviguer(); // Le vehiculeAmphibie
            bateau1.Tourner(); // Le vehiculeAmphibie

            IVoiture va2 = new VehiculeAmphibie();
            va2.Tourner(); // Le vehiculeAmphibie
            va2.Rouler(); // Le vehiculeAmphibie
        }
    }
}