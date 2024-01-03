namespace Game
{
    public class ConcretePlayerFactory : PlayerFactory
    {

        public override IPlayer CreatePlayer(string type)
        {
            return type switch
            {
                "Warrior" => new Warrior(),
                "Wizard" => new Wizard(),
                _ => new Citizen(),
            };
        }
    }
}