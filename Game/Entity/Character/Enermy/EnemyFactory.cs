namespace Game
{
      public abstract class EnemyFactory
    {
        public abstract IEnemy CreateEnemy(string type);
    }
}