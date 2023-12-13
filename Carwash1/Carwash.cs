namespace Carwash1
{
    internal class Carwash
    {
        CarwashDelegate cd = null;

        public Carwash()
        {
            cd += Preparer;
            cd += Laver;
            cd += Secher;
            cd += Finaliser;
        }

        private void Preparer(Voiture v)
        {
            System.Console.WriteLine($"Je prépare la voiture : {v.Plaque}");
        }
        private void Laver(Voiture v)
        {
            System.Console.WriteLine($"Je lave la voiture : {v.Plaque}");
        }
        private void Secher(Voiture v)
        {
            System.Console.WriteLine($"Je sèche la voiture : {v.Plaque}");
        }
        private void Finaliser(Voiture v)
        {
            System.Console.WriteLine($"Je finalise la voiture : {v.Plaque}");
        }
        public void Traiter(Voiture v)
        {
            if (cd != null) cd(v);
            System.Console.WriteLine();
        }

    }
}