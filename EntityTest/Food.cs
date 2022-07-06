namespace EntityTest
{
    public class Food : Item, IInfoble
    {
        public int CalorieAmmont { get; private set; }
        public Food(int calorieAmmount, string name) : base(name)
        {
            CalorieAmmont = calorieAmmount;
        }

        string IInfoble.Get()
        {
            return $"{Id} : {Name}";
        }
    }
}
