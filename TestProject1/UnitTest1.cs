using BytProject;

namespace TestProject1
{
    public class Tests
    {
        private Player player;
        private Enemy goblin;
        private Weapon sword;
        private Consumable potion;
        private Armor shield;

        [SetUp]
        public void Setup()
        {
            player = new Player("Hero", 100, 1, 0, 100, new City("Test City"));
            goblin = new Goblin("Goblin", 50, 1, 10, 10, false);
            sword = new Weapon("Sword", 100, 5, false, 20);
            potion = new Consumable("Health Potion", 10, 1, false, 30);
            shield = new Armor("Shield", 50, 10, false, 10, 2);
        }

        [Test]
        public void TestWeaponReduceHealth()
        {
            sword.ReduceHealth(goblin);

            Assert.That(goblin.HP, Is.EqualTo(30));
        }

        [Test]
        public void TestConsumableAddHealth()
        {
            potion.AddHealth(player);

            Assert.That(player.HP, Is.EqualTo(130));
        }

        [Test]
        public void TestArmorReduceDamage()
        {
            int damage = 30;

            shield.ReduceDamage(ref damage);

            Assert.That(damage, Is.EqualTo(20));
        }

        [Test]
        public void TestArmorDurabilityReduction()
        {
            int damage = 30;

            shield.ReduceDamage(ref damage); 
            shield.ReduceDamage(ref damage);

            Assert.That(shield.IsBroken, Is.True);
        }
    }
}