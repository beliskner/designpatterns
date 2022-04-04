using System;

namespace DPW4A1.Weapons
{
    public class KnifeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cutting with a knife");
        }
    }
}