namespace BytProject
{
    public class Consumable : Item
    {
        public int HealthPoint { get; private set; }

        public Consumable(string name, int value, int weight, bool isEquipped, int healthPoint)
            : base(name, value, weight, isEquipped)
        {
            HealthPoint = healthPoint;
        }

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
