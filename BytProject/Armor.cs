namespace BytProject
{
    public class Armor(string name, int value, int weight, bool isEquipped, int defense, int durability) : Item(name, value, weight, isEquipped)
    {
        public int Defense { get; private set; } = defense;
        public int Durability { get; private set; } = durability;
        public bool IsBroken { get; private set; } = false;

        public void ReduceDamage(ref int damage)
        {
            if (!IsBroken && Durability > 0)
            {
                damage -= Defense;
                Durability--;
                if (Durability == 0)
                {
                    IsBroken = true;
                }
            }
        }

        public override void Use()
        {
            Console.WriteLine($"{Name} used, providing {Defense} defense.");
        }
    }

}
