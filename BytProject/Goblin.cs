namespace BytProject
{
    public class Goblin : Enemy
    {
        public bool IsAmbush { get; private set; }

        public Goblin(string name, int hp, int level, int damage, int expReward, bool isAmbush)
            : base(name, hp, level, damage, expReward)
        {
            IsAmbush = isAmbush;
        }
        public void AddStealthBonus(Player player)
        {
            if (IsAmbush)
            {
                player.TakeDamage(Damage * 2);
                Console.WriteLine($"{Name} ambushed {player.Name}, dealing double damage!");
            }
        }
    }

}
