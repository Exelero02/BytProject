namespace BytProject
{
    public class Consumable(string name, int value, int weight, bool isEquipped, int healthPoint) : Item(name, value, weight, isEquipped)
    {
        public int HealthPoint { get; private set; } = healthPoint;

        public void AddHealth(Player player)
        {
            player.Heal(HealthPoint);
        }

        public override void Use()
        {
            Console.WriteLine($"{Name} consumed, restoring {HealthPoint} health.");
        }
    }

}
