namespace BytProject
{

    public class Quest
    {
        public string Name { get; private set; }
        public int Reward { get; private set; }
        public bool IsActive { get; private set; }
        public Quest SideQuest { get; private set; }
        public bool IsCompleted { get; private set; }
        public City Location { get; private set; }

        public Quest(string name, int reward, City location, Quest sideQuest = null)
        {
            Name = name;
            Reward = reward;
            Location = location;
            SideQuest = sideQuest;
            IsActive = true;
            IsCompleted = false;
        }

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
