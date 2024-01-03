namespace Game
{
    public class WeaponFactory
    {
        public static IWeapon GetWeapon(string weaponName)
        {
            return weaponName switch
            {
                "Revolver" => new Revolver(),
                "Knife" => new Knife(),
                "RocketLauncher" => new RocketLauncher(),
                _ => new Hand(),
            };
        }
    }
}