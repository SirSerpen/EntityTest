namespace EntityTest
{
    public class Inventory
    {
        private List<Item> items;
        public int Size { get; private set; }   
        public int Count => items.Count;

        public Inventory(int size)
        {
            items = new List<Item>();
            Size = size;
        }
        public void Add(Item item) 
        {
            if(items.Count >= Size) throw new Exception();
            items.Add(item);
        }
        public void Remove(Item item)
        {
            if (items.Count >= Size) throw new Exception();
            items.Remove(item);
        }
        public Item GetByIndex(int index)
        {
            return items[index];
        }
    }
}
