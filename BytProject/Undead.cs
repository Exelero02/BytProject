namespace BytProject
{
    public class Undead : Enemy
    {
        public bool HasArmor { get; private set; }

        public Undead(string name, int hp, int level, int damage, int expReward, bool hasArmor)
            : base(name, hp, level, damage, expReward)
        {
            HasArmor = hasArmor;
        }
        public void ReduceDamage(ref int damage)
        {
            if (HasArmor)
            {
                damage /= 2;
                Console.WriteLine($"{Name} reduced incoming damage by half.");
            }
        }
    }

}
