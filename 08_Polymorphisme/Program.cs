using System;

namespace _08_Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule vehicule = new Vehicule();
            vehicule.SeDeplacer();
            Console.WriteLine();

            Voiture voiture = new Voiture();
            voiture.SeDeplacer();
            Console.WriteLine();

            VoitureCourse voitureCourse = new VoitureCourse();
            voitureCourse.SeDeplacer();
            Console.WriteLine();

            Bateau bateau = new Bateau();
            bateau.SeDeplacer();
            Console.WriteLine();

            // Polymorphisme

            Console.WriteLine("-- Polymorphisme --");

            Vehicule v1 = new Voiture(); // Casting implicite
            v1.SeDeplacer();
            Console.WriteLine();

            Voiture voiture1 = (Voiture) v1; // Casting explicite
            voiture1.SeDeplacer();
            Console.WriteLine();

            object v2 = new Bateau(); // Casting implicite
            //v2.SeDeplacer(); // SeDeplacer n'est pas disponible dans la classe object => pas accès
            ( (Bateau) v2 ).SeDeplacer();
            Console.WriteLine();

            Bateau bateau1 = (Bateau) v2; // Casting explicite
            bateau1.SeDeplacer();
            Console.WriteLine();
        }
    }
}
