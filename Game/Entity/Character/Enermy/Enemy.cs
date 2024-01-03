namespace Game
{
    public abstract class Enemy 
    {
        public abstract Enemy CreateEnemy(string type);

        public virtual void Track()
        {
            Console.WriteLine("Tracking");
        }
        public virtual void Rest()
        {
            Console.WriteLine("Resting");
        }
    }
}