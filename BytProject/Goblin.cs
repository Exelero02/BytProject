namespace BytProject
{
    public class Goblin(string name, int hp, int level, int damage, int expReward, bool isAmbush) : Enemy(name, hp, level, damage, expReward)
    {
        public bool IsAmbush { get; private set; } = isAmbush;

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
