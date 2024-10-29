using System;

namespace BytProject
{
    public class Weapon : Item
    {
        public int Damage { get; private set; }

        public Weapon(string name, int value, int weight, bool isEquipped, int damage)
            : base(name, value, weight, isEquipped)
        {
            if (damage <= 0)
                throw new ArgumentException("Damage must be greater than zero.", nameof(damage));

            Damage = damage;
        }

        public void ReduceHealth(Enemy enemy)
        {
            if (enemy == null)
                throw new ArgumentNullException(nameof(enemy), "Enemy cannot be null.");

            if (Damage <= 0)
                throw new InvalidOperationException("Weapon damage must be greater than zero to reduce health.");

            enemy.TakeDamage(Damage);
        }

        public override void Use()
        {
            if (Damage <= 0)
                throw new InvalidOperationException("Weapon damage must be greater than zero to use the weapon.");

            Console.WriteLine($"{Name} used as a weapon, dealing {Damage} damage.");
        }
    }
}
