using System;

namespace DPW4A3.Models
{
    public class Tank : IAttacker
    {
        public string Driver { get; set; }
        
        public void AssignDriver(string driverName)
        {
            Driver = driverName;
            Console.WriteLine($"{Driver} is steering the tank");
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves forward");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage with weapon");
        }
    }
}