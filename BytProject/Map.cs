namespace BytProject
{
    public class Map
    {
        public List<City> Cities { get; private set; }

        public Map()
        {
            Cities = new List<City>();
        }
        public void ShowMap()
        {
            Console.WriteLine("Displaying map:");
            foreach (var city in Cities)
            {
                Console.WriteLine($"City: {city.Name}");
            }
        }
    }

}
