namespace Game
{
   public interface IProjectile
    {
        string Name { get; set; }
        int DamageValue { get; set; }
        void Launch();
        void Impact(IEntity target);
    }
}