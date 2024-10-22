namespace BytProject
{
    public class GameSave
    {
        public string SaveFileName { get; private set; }
        public Player PlayerState { get; private set; }
        public List<Enemy> EnemyStates { get; private set; }
        public City LastCurrentLocation { get; private set; }
        public List<Item> Inventory { get; private set; }
        public DateTime TimeStamp { get; private set; }

        public GameSave(string saveFileName, Player playerState, List<Enemy> enemyStates, City lastCurrentLocation, List<Item> inventory)
        {
            SaveFileName = saveFileName;
            PlayerState = playerState;
            EnemyStates = enemyStates;
            LastCurrentLocation = lastCurrentLocation;
            Inventory = inventory;
            TimeStamp = DateTime.Now;
        }

        public void CreateSaveFile()
        {
            Console.WriteLine($"Creating save file {SaveFileName} at {TimeStamp}.");
            // empty for now
        }

        public void LoadGame()
        {
            Console.WriteLine($"Loading game from save file {SaveFileName}.");
            // empty for now
        }

        public void DeleteSave()
        {
            Console.WriteLine($"Deleting save file {SaveFileName}.");
            // empty for now
        }

        public void ListSaveFiles()
        {
            Console.WriteLine("Listing all save files:");
            // empty for now
        }
    }

}
