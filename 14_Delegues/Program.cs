using System;

namespace _14_Delegues
{

    delegate void DireBonjour(string s);
    class Program
    {
        static void Main(string[] args)
        {
            DireBonjour direBonjour = null;

            direBonjour += EnFrancais;
            direBonjour += EnAnglais;
            direBonjour += EnNeerlandais;

            // Methode anonyme
            direBonjour += delegate (string prenom)
            {
                Console.WriteLine("Ohayo " + prenom);
            };

            // Plante si vous avez votre Delegate à null
            //direBonjour("Quentin");
            //direBonjour.Invoke("Quentin");

            // OK
            //if (direBonjour != null)
            //    direBonjour("Quentin");

            RaiseDireBonjour("Quentin", direBonjour);
        }

        static void RaiseDireBonjour(string prenom, DireBonjour d)
        {
            Console.WriteLine("Callback");
            if (d != null)
                d(prenom);
        }

        static void EnFrancais(string prenom)
        {
            Console.WriteLine("Bonjour " + prenom);
        }

        static void EnAnglais(string prenom)
        {
            Console.WriteLine("Hi " + prenom);
        }

        static void EnNeerlandais(string prenom)
        {
            Console.WriteLine("Goeidag " + prenom);
        }
    }
}
