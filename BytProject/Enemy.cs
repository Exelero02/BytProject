namespace BytProject
{
    public abstract class Enemy : Character
    {
        public int Damage { get; private set; }
        public int ExpReward { get; private set; }
        public bool IsAttackMissed { get; private set; }
        public Enemy(string name, int hp, int level, int damage, int expReward)
            : base(name, hp, level)
        {
            Damage = damage;
            ExpReward = expReward;
        }

        public void GiveExp(Player player)
        {
            player.AddExperience(ExpReward);
            Console.WriteLine($"{Name} was defeated! {player.Name} gained {ExpReward} experience.");
        }

        public void Attack(Player player)
        {
            if (!IsAttackMissed)
            {
                player.TakeDamage(Damage);
                Console.WriteLine($"{Name} attacks {player.Name}, dealing {Damage} damage.");
            }
            else
            {
                Console.WriteLine($"{Name}'s attack missed!");
            }
        }
    }
}
