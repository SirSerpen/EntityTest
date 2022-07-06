namespace EntityTest
{
    public class MeleeWeapon : Weapon, IInfoble
    {
        public MeleeWeapon(int damage, int coolDown, string name) : base(damage, coolDown, name)
        {
            Console.WriteLine(Id);
        }

        public override void Fire()
        {
            throw new NotImplementedException();
        }

        string IInfoble.Get()
        {
            return $"{Id} : {Name}";
        }
    }
}
