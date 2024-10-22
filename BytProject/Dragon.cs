namespace BytProject
{
    public class Dragon : Enemy
    {
        public string StereoType { get; private set; }

        public Dragon(string name, int hp, int level, int damage, int expReward, string stereoType)
            : base(name, hp, level, damage, expReward)
        {
            StereoType = stereoType;
        }
    }

}
