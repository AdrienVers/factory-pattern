namespace Game
{
    public class Arrow : IProjectile
    {
        public string Name { get; set; } = "Arrow";
        public int DamageValue { get; set; } = 20;

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