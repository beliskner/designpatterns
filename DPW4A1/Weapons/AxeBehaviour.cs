using System;

namespace DPW4A1.Weapons
{
    public class AxeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Chopping with an axe");
        }
    }
}