namespace Game
{
    public class EnemyBehaviour : IEnemyBehaviour
    {
        public void Track()
        {
            Console.WriteLine("Tracking the player");
        }

        public void Rest()
        {
            Console.WriteLine("Resting");
        }
    }
}