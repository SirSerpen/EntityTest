namespace EntityTest
{
    public abstract class Weapon : Item
    {
        public int Damage { get; protected set; }
        public int CoolDown { get; protected set; }
        public Weapon(int damage, int coolDown, string name) : base(name)
        {
            Damage = damage;
            CoolDown = coolDown;
        }

        public abstract void Fire();
    }
}
