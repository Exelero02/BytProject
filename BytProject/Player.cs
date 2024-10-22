namespace BytProject
{
    public class Player : Character
    {
        public string Name { get; private set; }
        public int Exp { get; set; }
        public int Gold { get; private set; }
        public int Level { get; private set; }
        public int HP { get; private set; }
        public List<Item> Inventory { get; private set; }
        public City CurrentLocation { get; private set; }

        public Player(string name, int hp, int level, int exp, int gold, City currentLocation)
            : base(name, hp, level)
        {
            Exp = exp;
            Gold = gold;
            Inventory = new List<Item>();
            CurrentLocation = currentLocation;
        }

        public void Talk()
        {
            Console.WriteLine($"{Name} we'll update this dialogue option :D");
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
            HP += healthPoints;
            Console.WriteLine($"{Name} healed by {healthPoints}. Current HP: {HP}");
        }
    }
}
