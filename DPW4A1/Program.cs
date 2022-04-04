using System;
using System.Collections.Generic;
using DPW4A1.Characters;
using DPW4A1.Weapons;

namespace DPW4A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            var characters = new List<Character>
            {
                new Queen(),
                new Troll(),
                new King(),
                new Knight()
            };
            foreach (var character in characters)
                character.Fight();
            Console.WriteLine();
            // change weapon of knight to axe
            characters[3].Weapon = new AxeBehaviour();
            foreach (var character in characters)
                character.Fight();
        }
    }
}