using System;

namespace DPW4A1.Weapons
{
    public class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Swinging a sword");
        }
    }
}