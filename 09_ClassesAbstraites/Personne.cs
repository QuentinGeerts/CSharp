using System;

namespace _09_ClassesAbstraites
{
    // Le mot-clef "abstract" permet de rendre la classe non-instanciable
    // <!> Une classe abstract ne rend pas ses membres abstract
    // <!> Un membre abstract rend sa classe abstract
    internal abstract class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual void Parler()
        {
            Console.WriteLine($"{GetType().Name} parle");
        }

        // Prototype : public abstract void Ecouter();
        // Signature : void Ecouter();
        // Une méthode non terminée ne pourra pas être appelée
        // => La classe devient abstract
        public abstract void Ecouter();
    }
}