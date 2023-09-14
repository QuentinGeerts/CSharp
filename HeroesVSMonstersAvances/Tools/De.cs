using System;

namespace HeroesVSMonsters.Tools
{
    internal class De
    {
        private readonly Random _Random;

        // Attributes
        private int _Minimum;

        // Constructor
        public De(int Maximum)
        {
            this.Maximum = Maximum;
            _Random = new Random(GetSeed());
        }

        // Properties
        public int Minimum => 1;

        public int Maximum { get; }

        // Methods
        private int GetSeed()
        {
            var id = Guid.NewGuid();
            var Seed = 0;

            foreach (var b in id.ToByteArray()) Seed += b;

            return Seed;
        }

        public int Lance()
        {
            return _Random.Next(Maximum) + 1;
        }

        public static int GetNouvelleCaracteristique()
        {
            const int nbDes = 4;
            var Des = new int[nbDes];
            var d = new De(6);

            for (var i = 0; i < nbDes; i++) Des[i] = d.Lance();

            for (var i = 0; i < nbDes - 1; i++)
            for (var j = i + 1; j < nbDes; j++)
                if (Des[i] < Des[j])
                {
                    var temp = Des[i];
                    Des[i] = Des[j];
                    Des[j] = temp;
                }

            return Des[0] + Des[1] + Des[2];
        }
    }
}