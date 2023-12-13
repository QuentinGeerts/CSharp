using System;

namespace HeroesVSMonsters.Tools
{
    class De
    {
        // Attributes
        private int _Minimum;
        private int _Maximum;
        private Random _Random;

        // Properties
        public int Minimum
        {
            get { return 1; }
        }

        public int Maximum
        {
            get { return _Maximum; }
            private set { _Maximum = value; }
        }

        // Constructor
        public De(int Maximum)
        {
            this.Maximum = Maximum;
            _Random = new Random(GetSeed());
        }

        // Methods
        private int GetSeed()
        {
            Guid id = Guid.NewGuid();
            int Seed = 0;

            foreach (byte b in id.ToByteArray())
            {
                Seed += b;
            }

            return Seed;
        }

        public int Lance()
        {
            return _Random.Next(Maximum) + 1;
        }

        public static int GetNouvelleCaracteristique()
        {
            const int nbDes = 4;
            int[] Des = new int[nbDes];
            De d = new De(6);

            for (int i = 0; i < nbDes; i++)
            {
                Des[i] = d.Lance();
            }

            for (int i = 0; i < nbDes - 1; i++)
            {
                for (int j = i + 1; j < nbDes; j++)
                {
                    if (Des[i] < Des[j])
                    {
                        int temp = Des[i];
                        Des[i] = Des[j];
                        Des[j] = temp;
                    }
                }
            }

            return Des[0] + Des[1] + Des[2];
        }
    }
}
