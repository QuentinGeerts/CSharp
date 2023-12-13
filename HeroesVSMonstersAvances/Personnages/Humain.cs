namespace HeroesVSMonsters.Personnages
{
    class Humain : Hero
    {
        public override int Endurance { get => base.Endurance + 1; }
        public override int Force { get => base.Force + 1; }
    }
}
