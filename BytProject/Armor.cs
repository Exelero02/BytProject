namespace BytProject
{
    public class Armor : Item
    {
        public int Defense { get; private set; }
        public int Durability { get; private set; }
        public bool IsBroken { get; private set; }

        public Armor(string name, int value, int weight, bool isEquipped, int defense, int durability)
            : base(name, value, weight, isEquipped)
        {
            Defense = defense;
            Durability = durability;
            IsBroken = false;
        }

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
