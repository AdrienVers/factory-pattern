namespace Game
{
    public class ConcreteEnemyFactory : EnemyFactory
    {
        public override IEnemy CreateEnemy(string type)
        {
            return type switch
            {
                "Zombie" => new Zombie(),
                "Warrior" => new Warrior(), 
                "Wizard" => new Wizard(), 
                _ => new Citizen(),
            };
        }
    }
}