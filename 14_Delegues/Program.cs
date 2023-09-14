using System;

namespace _14_Delegues
{
    internal delegate void DireBonjour(string s);

    internal class Program
    {
        private static void Main(string[] args)
        {
            DireBonjour direBonjour = null;

            direBonjour += EnFrancais;
            direBonjour += EnAnglais;
            direBonjour += EnNeerlandais;

            // Methode anonyme
            direBonjour += delegate(string prenom) { Console.WriteLine("Ohayo " + prenom); };

            // Plante si vous avez votre Delegate à null
            //direBonjour("Quentin");
            //direBonjour.Invoke("Quentin");

            // OK
            //if (direBonjour != null)
            //    direBonjour("Quentin");

            RaiseDireBonjour("Quentin", direBonjour);
        }

        private static void RaiseDireBonjour(string prenom, DireBonjour d)
        {
            Console.WriteLine("Callback");
            if (d != null)
                d(prenom);
        }

        private static void EnFrancais(string prenom)
        {
            Console.WriteLine("Bonjour " + prenom);
        }

        private static void EnAnglais(string prenom)
        {
            Console.WriteLine("Hi " + prenom);
        }

        private static void EnNeerlandais(string prenom)
        {
            Console.WriteLine("Goeidag " + prenom);
        }
    }
}