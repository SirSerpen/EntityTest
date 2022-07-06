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
    public static readonly string[] AddMenuItem =
    {
        "Weapon",
        "Food"
    };
    public static readonly string[] AddMenuWeapon =
    {
        "Melee",
        "Range"
    };
    public static void Main(string[] args)
    {
        inventory = new Inventory(10);
        var ak47 = new RangeWeapon(2, 1, 2, 1, "Ak-47");
        var apple = new Food(2, "Apple");
        inventory.Add(new Food(300, "Tea"));
        inventory.Add(apple);
        inventory.Add(ak47);
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
                inventory.SortById();
                return true;
            case "3":
                throw new NotImplementedException();
            case "4":
                inventory.SortByName();
                return true;
            case "5":
                AddNewItem();
                return true;
            case "6":
                inventory.Remove(Convert.ToInt32(Console.ReadLine()));
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
        Console.Read();
    }
    private static void AddNewItem()
    {
        Console.Clear();
        Console.WriteLine("Select item type:");
        for (int i = 0; i < AddMenuItem.Length; i++)
        {
            Console.WriteLine($"{i + 1}) {AddMenuItem[i]}");
        }
        switch (Console.ReadLine())
        {
            case "1":
                MenuWeapon();
                break;
            case "2":
                MenuFood();
                break;
            default: throw new NotImplementedException();
        }
    }
    private static void MenuWeapon()
    {
        Console.Clear();
        Console.WriteLine("Select weapon type:");
        for (int i = 0; i < AddMenuWeapon.Length; i++)
        {
            Console.WriteLine($"{i + 1}) {AddMenuWeapon[i]}");
        }
        switch (Console.ReadLine())
        {
            case "1":
                MenuWeaponMelee();
                break;
            case "2":
                MenuWeaponRange();
                break;
            default: throw new NotImplementedException();
        }
    }

    private static void MenuFood()
    {
        Console.Clear();
        Console.WriteLine("\r\nSelect an option: ");
        Console.Write($"Enter CalorieAmmount : ");
        var calorieAmmount = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter Name : ");
        var name = Console.ReadLine();
        var item = new Food(calorieAmmount, name);
        inventory.Add(item);
    }
    private static void MenuWeaponRange()
    {
        Console.Clear();
        Console.WriteLine("\r\nSelect an option: ");
        Console.Write($"Enter Damage : ");
        var damage = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter AmmoCount : ");
        var ammoCount = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter CoolDown : ");
        var coolDown = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter FireRange : ");
        var fireRange = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter Name : ");
        var name = Console.ReadLine();
        var item = new RangeWeapon(damage, ammoCount, coolDown, fireRange, name);
        inventory.Add(item); ;
    }

    private static void MenuWeaponMelee()
    {
        Console.Clear();
        Console.WriteLine("\r\nSelect an option: ");
        Console.Write($"Enter Damage : ");
        var damage = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter CoolDown : ");
        var coolDown = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter Name : ");
        var name = Console.ReadLine();
        var item = new MeleeWeapon(damage, coolDown, name);
        inventory.Add(item);
    }
}