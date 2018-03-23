namespace StarShooter.GameManagement.Data
{
    public class GameInfo
    {
        public GameInfo(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }

        public string Name { get; }

    }
}
