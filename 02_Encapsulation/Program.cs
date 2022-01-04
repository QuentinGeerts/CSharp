using System;

namespace _02_Encapsulation
{
    // Encapsulation par défaut dans un namespace : internal
    // Encapsulation possible : public ou internal (private n'a pas d'intérêt)

    // Encapsulation par défaut dans une classe : private
    // Encapsulation par défaut possible dans une classe :
    // - public
    // - protected
    // - internet
    // - protected internal
    // - private
    // - private protected
    class Program
    {
        static void Main(string[] args)
        {
            Personne quentin = new Personne();
            quentin.nom = "Geerts";
            quentin.prenom = "Quentin";
            quentin.dateNaiss = new DateTime(1996, 04, 03);
            quentin.DireBonjour();
            quentin.Marcher();

            Console.WriteLine($"{quentin.nom} {quentin.prenom} {quentin.dateNaiss}");

            Personne raphael = new Personne();
            raphael.prenom = "Raphael";
            raphael.nom = "Kuban";

            raphael.DireBonjour();
            raphael.Marcher();

            Console.WriteLine($"{raphael.nom} {raphael.prenom}");
        }
    }
}
