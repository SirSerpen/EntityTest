namespace EntityTest
{
    public class Food : Item, IInfoble
    {
        public int CalorieAmmont { get; private set; }
        public Food(int id, int calorieAmmount, string name) : base(id, name)
        {
            CalorieAmmont = calorieAmmount;
        }

        string IInfoble.Get()
        {
            return $"{Id} : {Name} : {CalorieAmmont}";
        }
    }
}
