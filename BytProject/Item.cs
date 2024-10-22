namespace BytProject
{
    public abstract class Item
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public int Weight { get; private set; }
        public bool IsEquipped { get; private set; }

        public Item(string name, int value, int weight, bool isEquipped)
        {
            Name = name;
            Value = value;
            Weight = weight;
            IsEquipped = isEquipped;
        }

        public abstract void Use();
    }

}
