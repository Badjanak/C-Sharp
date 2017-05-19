using Entities;
using Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class StartUp
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;
            uint count = 0;
            while (!isValidInput)
            {
                Console.WriteLine("How many missile would You like to launch: ");
                string input = Console.ReadLine();
                isValidInput = UInt32.TryParse(input, out count);
            }
            GenerateMissiles(count);

        }

        private static void GenerateMissiles(uint count)
        {
            var missileTypeCount = Enum.GetNames(typeof(MissileType)).Length;
            Random randomMissile = new Random();

            CustomID ID = new CustomID();
            DefenceSystem defenceSystem = new DefenceSystem();

            for (int i = 0; i < count; i++)
            {
                int rm = randomMissile.Next(0, missileTypeCount);
                Missile newRms = new Missile((MissileType)rm);
                defenceSystem.InterceptMissile(newRms);
                CommunicationCenter cc = new CommunicationCenter(defenceSystem.AntiAirGunType, newRms, null);

                Console.WriteLine($"{cc}\n{new string('-', 50)}");
                Thread.Sleep(300);
            }
        }
    }
}
