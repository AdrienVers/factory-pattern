namespace Game
{
    public interface IWeapon
    {
        string Name { get; set; }
        int DamageValue { get; set; }
        void Strike();
    }
}