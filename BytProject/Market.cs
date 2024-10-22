namespace BytProject
{
    public class Market
    {
        public string ItemName { get; private set; }
        public int ItemPrice { get; private set; }

        public Market(string itemName, int itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }

        public void TakeMoney(int amount)
        {
            Console.WriteLine($"Taking {amount} gold for {ItemName}.");
        }

        public void GiveMoney(int amount)
        {
            Console.WriteLine($"Giving {amount} gold back.");
        }
    }

}
