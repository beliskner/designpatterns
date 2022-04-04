
using System;
using System.Collections.Generic;
using DPW4A3.Models;

namespace DPW4A3
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            var tank = new Tank();
            tank.AssignDriver("Frank");

            var robot = new RobotAdapter();
            robot.AssignDriver("Mark");
            
            // create attackers list, and add tank and robot
            var attackers = new List<IAttacker>{tank, robot};

            foreach (var attacker in attackers)
            {
                Console.WriteLine($"Driver of attacker: {attacker.Driver}");
                attacker.DriveForward();
                attacker.UseWeapon();
            }
        }
    }
}