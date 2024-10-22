namespace BytProject
{
    public class Weapon : Item
    {
        public int Damage { get; private set; }

        public Weapon(string name, int value, int weight, bool isEquipped, int damage)
            : base(name, value, weight, isEquipped)
        {
            Damage = damage;
        }

        public void ReduceHealth(Enemy enemy)
        {
            enemy.TakeDamage(Damage);
        }

        public override void Use()
        {
            Console.WriteLine($"{Name} used as a weapon, dealing {Damage} damage.");
        }
    }

}
