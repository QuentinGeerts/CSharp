namespace HeroesVSMonsters.Personnages
{
    internal class Humain : Hero
    {
        public override int Endurance => base.Endurance + 1;
        public override int Force => base.Force + 1;
    }
}