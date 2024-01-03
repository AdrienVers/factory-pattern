namespace Game
{
      public abstract class PlayerFactory
    {
        public abstract IPlayer CreatePlayer(string type);
    }
}