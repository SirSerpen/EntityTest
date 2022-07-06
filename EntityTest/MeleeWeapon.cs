namespace EntityTest
{
    public class MeleeWeapon : Weapon
    {
        public MeleeWeapon(int id, int damage, int coolDown, string name) : base(id, damage, coolDown, name)
        {
            Console.WriteLine(Id);
        }

        public override void Fire()
        {
            throw new NotImplementedException();
        }
    }
}
