namespace Game
{
    public interface ICharacter : IEntity
    {
        string Name { get; set; }
        string OutfitColor { get; set; }
        int HealthValue { get; set; }
        IWeapon? EquippedWeapon { get; }
        void TakeDamage(int damage);
        void EquipWeapon(IWeapon weapon);
        void Shoot(IProjectile projectile);
        void Throw(IProjectile projectile);
        void Strike(IEntity target);
        void Reload();
    }
}


