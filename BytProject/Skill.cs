namespace BytProject
{
    public class Skill
    {
        public string Name { get; private set; }
        public int Damage { get; private set; }
        public int UnlockLevel { get; private set; }
        public bool IsUnlocked { get; private set; }

        public Skill(string name, int damage, int unlockLevel)
        {
            Name = name;
            Damage = damage;
            UnlockLevel = unlockLevel;
            IsUnlocked = false;
        }

        public void Unlock()
        {
            IsUnlocked = true;
            Console.WriteLine($"{Name} skill is now unlocked!");
        }
    }

}
