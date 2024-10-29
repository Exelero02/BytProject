namespace BytProject
{
    public class Player : Character
    {
        public int Exp { get; private set; } // Changed back to private set
        public int Gold { get; private set; }
        public List<Item> Inventory { get; private set; } = new List<Item>();
        public City CurrentLocation { get; private set; }

        public Player(string name, int hp, int level, int exp, int gold, City currentLocation)
            : base(name, hp, level)
        {

            if (hp <= 0)
                throw new ArgumentException("HP must be greater than zero.", nameof(hp));
            if (level <= 0)
                throw new ArgumentException("Level must be greater than zero.", nameof(level));
            if (exp < 0)
                throw new ArgumentException("Experience points cannot be negative.", nameof(exp));
            if (gold < 0)
                throw new ArgumentException("Gold cannot be negative.", nameof(gold));
            if (currentLocation == null)
                throw new ArgumentNullException(nameof(currentLocation), "Current location cannot be null.");

            Exp = exp;
            Gold = gold;
            CurrentLocation = currentLocation;
        }

        public void AddExperience(int amount)
        {

            if (amount < 0)
                throw new ArgumentException("Experience points to add must be positive.", nameof(amount));


            Exp += amount;
        }

        public void Talk()
        {
            Console.WriteLine($"{Name}, we'll update this dialogue option :D");
        }

        public void LevelUp()
        {
            if (Level < MaxLevel)
            {
                Level++;
                Console.WriteLine($"{Name} has leveled up! Current level: {Level}");
            }
        }

        public void UpdateLocation(City newLocation)
        {
            CurrentLocation = newLocation;
            Console.WriteLine($"{Name} moved to {newLocation.Name}.");
        }

        public void UseItem(Item item)
        {
            item.Use();
        }

        public void Heal(int healthPoints)
        {
            if (healthPoints <= 0)
                throw new ArgumentException("Healing points must be greater than zero.", nameof(healthPoints));

            HP += healthPoints;
            Console.WriteLine($"{Name} healed by {healthPoints}. Current HP: {HP}");
        }
    }
}
