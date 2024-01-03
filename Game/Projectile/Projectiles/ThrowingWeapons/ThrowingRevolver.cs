namespace Game
{
    public class ThrowingRevolver : IProjectile
    {
        public string Name { get; set; } = "ThrowingRevolver";
        public int DamageValue { get; set; } = 10;

        public void Launch()
        {
           Console.WriteLine($"{GetType().Name} launched!");
        }

        public void Impact(IEntity target)
        {
            Console.WriteLine($"{GetType().Name} impact!");
            if (target is ICharacter characterTarget)
            {
                characterTarget.TakeDamage(DamageValue);
            }
            else
            {
                Console.WriteLine("The projectile did not hit a character.");
            }
        }
    }
}