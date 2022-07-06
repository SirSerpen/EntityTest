namespace EntityTest
{
    public class RangeWeapon : Weapon, IInfoble
    {
        public int AmmoCount { get; protected set; }
        public int FireRange { get; protected set; }
        public RangeWeapon(int id, int damage, int ammoCount, int coolDown, int fireRange, string name) : base(id, damage, coolDown, name)
        {
            AmmoCount = ammoCount;
            FireRange = fireRange;
        }

        public override void Fire()
        {
            throw new NotImplementedException();
        }

        string IInfoble.Get()
        {
            return $"{Id} : {Name} : {AmmoCount} : {Damage} ";
        }
    }
}
