

namespace BytProject
{
    public abstract class Character
    {
        public string Name { get; private set; }
        public int HP { get; private set; }
        public int Level { get; private set; }
        public bool Alive { get; private set; }
        public const int MaxLevel = 10; 

        public Character(string name, int hp, int level)
        {
            Name = name;
            HP = hp;
            Level = level;
            Alive = true;
        }

        public virtual void Attack(Enemy enemy)
        {
            Console.WriteLine($"{Name} attacks {enemy.Name}!");
        }

        public virtual void TakeDamage(int damage)
        {
            HP -= damage;
            if (HP <= 0)
            {
                Alive = false;
                HP = 0;
                Console.WriteLine($"{Name} has died.");
            }
            else
            {
                Console.WriteLine($"{Name} took {damage} damage. Remaining HP: {HP}");
            }
        }
    }


}
