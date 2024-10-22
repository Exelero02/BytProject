namespace BytProject
{
    public class Npc
    {
        public string Name { get; private set; }
        public string Dialogue { get; private set; }
        public Quest Quest { get; private set; }
        public City Location { get; private set; }
        public bool HaveMeetBefore { get; private set; }

        public Npc(string name, string dialogue, Quest quest, City location)
        {
            Name = name;
            Dialogue = dialogue;
            Quest = quest;
            Location = location;
            HaveMeetBefore = false;
        }

        public void GiveQuest(Player player)
        {
            Console.WriteLine($"{Name} has given a quest to {player.Name}.");
        }

        public void RecognizePlayer(Player player)
        {
            if (HaveMeetBefore)
            {
                Console.WriteLine($"{Name} recognizes {player.Name}.");
            }
            else
            {
                HaveMeetBefore = true;
                Console.WriteLine($"{Name} meets {player.Name} for the first time.");
            }
        }
    }

}
