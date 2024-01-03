namespace Game
{
    public class RocketLauncher : IWeapon, IShootable, IThrowable
    {
        public string Name { get; set; } = "RocketLauncher";
        public string AmmoType { get; set; } = "Rocket";
        public int AmmoCount { get; set; } = 1;
        public int MaxAmmo { get; set; } = 4;
        public int DamageValue { get; set; } = 100;

        public void Strike()
        {
            Console.WriteLine("Strike with RocketLauncher!");
        }

        public void Shoot(IProjectile projectile)
        {
            Console.WriteLine("Shoot with RocketLauncher!");
            projectile.Launch();
        }

        public void Reload()
        {
            Console.WriteLine("Reload RocketLauncher!");
        }

        public void Throw(IProjectile projectile)
        {
            Console.WriteLine("Throw the RocketLauncher!");
            projectile.Launch();
        }
    }
}