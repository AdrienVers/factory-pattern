namespace Game
{
    public class Rocket : IProjectile, IExplosable
    {
        public string Name { get; set; } = "Rocket";
        public int DamageValue { get; set; } = 100;

        public void Launch()
        {
            Console.WriteLine($"{GetType().Name} launched!");
        }

        public void Impact(IEntity target)
        {
            if (target is ICharacter characterTarget)
            {
                Console.WriteLine($"{GetType().Name} impact!");
                Explose();
                characterTarget.TakeDamage(DamageValue);
            }
            else
            {
                Console.WriteLine("The projectile did not hit a character.");
            }
        }

        public void Explose()
        {
            Console.WriteLine("Explose !");
        }
    }
}