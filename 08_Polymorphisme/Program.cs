using System;

namespace _08_Polymorphisme
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var vehicule = new Vehicule();
            vehicule.SeDeplacer();
            Console.WriteLine();

            var voiture = new Voiture();
            voiture.SeDeplacer();
            Console.WriteLine();

            var voitureCourse = new VoitureCourse();
            voitureCourse.SeDeplacer();
            Console.WriteLine();

            var bateau = new Bateau();
            bateau.SeDeplacer();
            Console.WriteLine();

            // Polymorphisme

            Console.WriteLine("-- Polymorphisme --");

            Vehicule v1 = new Voiture(); // Casting implicite
            v1.SeDeplacer();
            Console.WriteLine();

            var voiture1 = (Voiture)v1; // Casting explicite
            voiture1.SeDeplacer();
            Console.WriteLine();

            object v2 = new Bateau(); // Casting implicite
            //v2.SeDeplacer(); // SeDeplacer n'est pas disponible dans la classe object => pas accès
            ((Bateau)v2).SeDeplacer();
            Console.WriteLine();

            var bateau1 = (Bateau)v2; // Casting explicite
            bateau1.SeDeplacer();
            Console.WriteLine();
        }
    }
}