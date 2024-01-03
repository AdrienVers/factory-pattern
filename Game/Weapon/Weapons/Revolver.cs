
namespace Game
{
    public class Revolver : IWeapon, IShootable, IThrowable
    {
        public string Name { get; set; } = "Revoler";
        public string AmmoType { get; set; } = "Bullet";
        public int AmmoCount { get; set; } = 5;
        public int MaxAmmo { get; set; } = 10;
        public int DamageValue { get; set; } = 40;

        public void Strike()
        {
            Console.WriteLine("Strike with revolver!");
        }

        public void Shoot(IProjectile projectile)
        {
            Console.WriteLine("Shoot with revolver!");
            projectile.Launch();
        }

        public void Reload()
        {
            Console.WriteLine("Reload revolver!");
        }

        public void Throw(IProjectile projectile)
        {
            Console.WriteLine("Throw the revolver!");
            projectile.Launch();
        }
    }
}