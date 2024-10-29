using BytProject;
using System.Text.Json;


namespace TestProject1
{
    [TestFixture]
    public class AttributeTests
    {
        [Test]
        public void PlayerAttributes_ShouldReturnCorrectValues()
        {
            var player = new Player("Hero", 100, 1, 0, 100, new City("Test City"));

            Assert.Multiple(() =>
            {
                Assert.That(player.Name, Is.EqualTo("Hero"));
                Assert.That(player.HP, Is.EqualTo(100));
                Assert.That(player.Level, Is.EqualTo(1));
                Assert.That(player.Exp, Is.EqualTo(0));
                Assert.That(player.Gold, Is.EqualTo(100));
                Assert.That(player.CurrentLocation.Name, Is.EqualTo("Test City"));
            });
        }
        [Test]
        public void WeaponAttributes_ShouldReturnCorrectValues()
        {
            var sword = new Weapon("Sword", 100, 5, false, 20);

            Assert.Multiple(() =>
            {
                Assert.That(sword.Name, Is.EqualTo("Sword"));
                Assert.That(sword.Value, Is.EqualTo(100));
                Assert.That(sword.Weight, Is.EqualTo(5));
                Assert.That(sword.IsEquipped, Is.EqualTo(false));
                Assert.That(sword.Damage, Is.EqualTo(20));


            });
        }

    }
    [TestFixture]
    public class ExceptionTest
    {
        [Test]
        public void Player_ShouldThrowException_WhenHpIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Player("Hero", -10, 1, 0, 100, new City("Test City")));
        }

        [Test]
        public void Weapon_ShouldThrowException_WhenDamageIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Weapon("Sword", 100, 5, false, -20));
        }
    }
    [TestFixture]
    public class ExtentTests
    {
        [Test]
        public void City_ShouldStoreAndRetrieveMarketItems()
        {
            var city = new City("Test City");
            var marketItem = new Market("Potion", 50);
            city.Markets.Add(marketItem);

            var retrievedItem = city.Markets[0];

            Assert.That(retrievedItem.ItemName, Is.EqualTo("Potion"));
            Assert.That(retrievedItem.ItemPrice, Is.EqualTo(50));
        }
    }

    [TestFixture]
    public class EncapsulationTests
    {
        [Test]
        public void Player_Encapsulation_ShouldProtectAttribute()
        {
            var player = new Player("Hero", 100, 1, 0, 100, new City("Test City"));

            var playerType = player.GetType();

            var hpField = playerType.GetProperty("HP", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.IsNull(hpField, "HP property should not be publicly accessible.");

            var expField = playerType.GetProperty("Exp", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.IsNull(expField, "Exp property should not be publicly accessible.");
        }
    }

    [TestFixture]
    public class PersistenceTests
    {
        private const string FilePath = "playerData.json";

        [Test]
        public void PlayerPersistence_ShouldSaveAndLoadCorrectly()
        {
            var player = new Player("Hero", 100, 1, 0, 100, new City("Test City"));

            var jsonData = JsonSerializer.Serialize(player);
            File.WriteAllText(FilePath, jsonData);

            var loadedData = File.ReadAllText(FilePath);
            var loadedPlayer = JsonSerializer.Deserialize<Player>(loadedData);

            Assert.Multiple(() =>
            {
                Assert.That(loadedPlayer.Name, Is.EqualTo(player.Name));
                Assert.That(loadedPlayer.HP, Is.EqualTo(player.HP));
                Assert.That(loadedPlayer.Level, Is.EqualTo(player.Level));
                Assert.That(loadedPlayer.Exp, Is.EqualTo(player.Exp));
                Assert.That(loadedPlayer.Gold, Is.EqualTo(player.Gold));
            });
        }
    }
}


