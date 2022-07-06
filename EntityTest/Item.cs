namespace EntityTest
{
    public abstract class Item
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }

        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
