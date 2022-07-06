namespace EntityTest
{
    public abstract class Item
    {
        public uint Id { get; protected set; }
        public string Name { get; protected set; }

        public Item(string name)
        {
            Id = Guid.GetId;
            Name = name;
        }
    }
}
