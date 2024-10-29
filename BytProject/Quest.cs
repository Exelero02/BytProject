namespace BytProject
{

    public class Quest(string name, int reward, City location, Quest? sideQuest = null)
    {
        public string Name { get; private set; } = name;
        public int Reward { get; private set; } = reward;
        public bool IsActive { get; private set; } = true;
        public Quest? SideQuest { get; private set; } = sideQuest;
        public bool IsCompleted { get; private set; } = false;
        public City Location { get; private set; } = location;

        public void CompleteQuest()
        {
            if (IsActive && !IsCompleted)
            {
                IsCompleted = true;
                Console.WriteLine($"Quest '{Name}' completed! Reward: {Reward} gold.");
            }
        }
    }

}
