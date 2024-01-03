namespace Game
{
public interface IThrowable : IWeapon
    {
        void Throw(IProjectile projectile);
    }
}
