namespace Game
{
    public interface IShootable : IWeapon
    {
        string AmmoType { get; }
        int AmmoCount { get; set; }
        int MaxAmmo { get; set; }
        void Shoot(IProjectile projectile);
        void Reload();
    }
}
