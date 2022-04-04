using DPW4A1.Weapons;

namespace DPW4A1.Characters
{
    public abstract class Character
    {
        public IWeaponBehaviour Weapon { get; set; }
        
        protected Character()
        {
            Weapon = new KnifeBehaviour();
        }

        public void Fight()
        {
            Weapon.UseWeapon();
        }
        
    }
}