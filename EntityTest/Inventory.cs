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
            if (items.Count >= Size) throw new Exception();
            items.Add(item);
        }
        public void Remove(int id)
        {
            if (items.Count >= Size) throw new Exception();
            items = items.Where(a => a.Id != id).ToList();
        }
        public Item GetByIndex(int index)
        {
            return items[index];
        }

        public void SortById()
        {
            var selectedItem = from i in items
                               orderby i.Id
                               select i;
            items = selectedItem.ToList();
        }
        public void SortByName()
        {
            var selectedItem = from i in items
                               orderby i.Name
                               select i;
            items = selectedItem.ToList();
        }
    }
}
