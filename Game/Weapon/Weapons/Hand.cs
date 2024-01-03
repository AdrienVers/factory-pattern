
namespace Game
{
    public class Hand : IWeapon
    {
        public string Name { get; set; } = "Hand";
        public string AmmoType { get; set; } = "Melee";
        public int AmmoCount { get; set; } = 0;
        public int MaxAmmo { get; set; } = 0;
        public int DamageValue { get; set; } = 10;

        public void Strike()
        {
            Console.WriteLine("Strike with hand!");
        }
    }
}