using EntityTest;

class Program
{
    public static Inventory inventory;
    public static readonly string[] Menu =
    {
        "List all items",
        "Sort by ID",
        "Sort by type",
        "Sort by name",
        "Add new item",
        "Remove an item",
        "Exit"
    };
    public static void Main(string[] args)
    {
        inventory = new Inventory(10);
        var ak47 = new RangeWeapon(0, 2, 1, 2, 1, "Ak-47");
        var apple = new Food(1, 2, "Apple");
        inventory.Add(ak47);
        inventory.Add(apple);
        while (MainMenu()) { }
    }
    private static bool MainMenu()
    {
        Console.Clear();
        for (int i = 0; i < Menu.Length; i++)
        {
            Console.WriteLine($"{i + 1}) {Menu[i]}");
        }
        Console.Write("\r\nSelect an option: ");

        
        switch (Console.ReadLine())
        {
            case "1":
                ListAllItem();
                return true;
            case "2":
                //SortById();
                return true;
            case "3":
                // SortByType();
                return true;
            case "4":
                // SortByName();
                return true;
            case "5":
                //  AddNewItem();
                return true;
            case "6":
                // RemoveItem();
                return true;
            case "7":
                return false;
            default:
                return true;
        }
    }
    public static void ListAllItem()
    {
        Console.Clear();
        for (int i = 0; i < inventory.Count; i++)
        {
            var info = (IInfoble)inventory.GetByIndex(i);
            if (info != null) Console.WriteLine(info.Get());
        }
        Console.Write("\r\nPress Enter to return to Main Menu");
        Console.ReadLine();
    }
}