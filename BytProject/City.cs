namespace BytProject
{
    public class City
    {
        public string Name { get; private set; }
        public List<Market> Markets { get; private set; }

        public City(string name)
        {
            Name = name;
            Markets = new List<Market>();
        }
        public void UpdatePlayerLocation(Player player)
        {
            player.UpdateLocation(this);
            Console.WriteLine($"Player location updated to {Name}.");
        }

        public void ListMarketItems()
        {
            Console.WriteLine($"Market items in {Name}:");
            foreach (var market in Markets)
            {
                Console.WriteLine($"{market.ItemName} for {market.ItemPrice} gold.");
            }
        }
    }

}
