namespace Game
{
    public class EmptySlot : IProjectile
    {
        public string Name { get; set; } = "Empty Slot";
        public int DamageValue { get; set; } = 0;

        public void Launch()
        {
            Console.WriteLine("No projectile!");
        }

        public void Impact(IEntity target)
        {
            Console.WriteLine("No projectile!");
        }
    }
}