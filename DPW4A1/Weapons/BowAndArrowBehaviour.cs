﻿using System;

namespace DPW4A1.Weapons
{
    public class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow with a bow");
        }
    }
}