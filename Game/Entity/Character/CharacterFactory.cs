namespace Game
{
    public abstract class CharacterFactory
       {
        public abstract IPlayer CreatePlayer(string type);
        public abstract IEnemy CreateEnemy(string type);
        
    }
}