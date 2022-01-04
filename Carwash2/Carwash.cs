namespace Carwash2
{
    internal class Carwash
    {
        CarwashDelegate cd = null;

        public Carwash()
        {
            // Méthode anonyme
            cd += delegate (Voiture v) 
            {
                System.Console.WriteLine($"Je prépare la voiture : {v.Plaque}");
            };

            cd += delegate (Voiture v)
            {
                System.Console.WriteLine($"Je lave la voiture : {v.Plaque}");
            };

            // Instruction Lambda
            cd += (Voiture v) => System.Console.WriteLine($"Je sèche la voiture : {v.Plaque}");

            cd += (Voiture v) => 
            {
                System.Console.WriteLine($"Je finalise la voiture : {v.Plaque}");
            };
        }

        public void Traiter(Voiture v)
        {
            if(cd != null) cd(v);
            System.Console.WriteLine();
        }

    }
}