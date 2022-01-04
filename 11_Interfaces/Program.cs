using System;

namespace _11_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point() { X = 5, Y = 5 };
            //p1.Display();
            //p1.Draw();

            //IPoint p2 = new Point() { X = 5, Y = 3 };
            //p2.Display();
            ////p2.Draw();

            Voiture voiture = new Voiture();
            voiture.Rouler();
            voiture.Tourner();

            Bateau bateau = new Bateau();
            bateau.Naviguer();
            bateau.Tourner();

            VehiculeAmphibie vehiculeAmphibie = new VehiculeAmphibie();
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
