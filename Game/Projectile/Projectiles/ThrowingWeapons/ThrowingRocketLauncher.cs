namespace Game
{
    public class ThrowingRocketLauncher : IProjectile
    {
        public string Name { get; set; } = "ThrowingRocketLauncher";
        public int DamageValue { get; set; } = 15;

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