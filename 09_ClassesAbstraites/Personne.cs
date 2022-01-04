using System;

namespace _09_ClassesAbstraites
{
    abstract class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual void Parler()
        {
            Console.WriteLine($"{this.GetType().Name} parle");
        }

        // Prototype : public abstract void Ecouter();
        // Signature : void Ecouter();
        public abstract void Ecouter();
    }
}
