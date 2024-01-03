namespace Game
{
    public class ProjectileFactory
    {
        public static IProjectile GetProjectile(string projectileName)
        {
            return projectileName switch
            {
                "Rocket" => new Rocket(),
                "Bullet" => new Bullet(),
                "Arrow" => new Arrow(),
                "ThrowingKnife" => new ThrowingKnife(),
                "ThrowingRevolver" => new ThrowingRevolver(),
                "ThrowingRocketLauncher" => new ThrowingRocketLauncher(),
                _ => new EmptySlot(),
            };
        }
    }
}