namespace Game
{
    public class Knife : IWeapon, IThrowable
    {
        public string Name { get; set; } = "Knife";
        public string AmmoType { get; set; } = "Melee";
        public int AmmoCount { get; set; } = 0;
        public int MaxAmmo { get; set; } = 0;
        public int DamageValue { get; set; } = 30;

        public void Strike()
        {
            Console.WriteLine("Strike with knife!");
        }

        public void Throw(IProjectile projectile)
        {
            Console.WriteLine("Throw the Knife!");
            projectile.Launch();
        }
    }
}