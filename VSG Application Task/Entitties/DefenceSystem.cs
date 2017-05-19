using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entitties;
using System.IO;

namespace Entities
{
    public sealed class DefenceSystem : IDefenceSystem
    {

        public DefenceSystem()
        {
            this.ID = new CustomID();
        }
        public CustomID ID { get; set; }
        public AntiAirGunType AntiAirGunType { get; set; }

        public void InterceptMissile(Missile missile)
        {
            switch (missile.MissileType)
            {
                case MissileType.FacetBomb:
                    this.AntiAirGunType = AntiAirGunType.AntiFacetGun;
                    Neutralize(missile);
                    break;
                case MissileType.Thermonuclear:
                    this.AntiAirGunType = AntiAirGunType.AntiThermoGun;
                    Neutralize(missile);
                    break;
                case MissileType.TNTBomb:
                    this.AntiAirGunType = AntiAirGunType.AntiTNTGun;
                    Neutralize(missile);
                    break;
            }
        }

        public void Neutralize(Missile missile)
        {
            CommunicationCenter cc = new CommunicationCenter(this.AntiAirGunType, missile, null);
            if (missile.MissileType == MissileType.Thermonuclear)
            {
                string fileName = "NukeAttack.txt";
                string textToAdd = cc.ToString();

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(textToAdd);
                }
            }
        }

        public override string ToString()
        {
            return $"Defense Gun ID: {this.ID }\nDefense Type: {this.AntiAirGunType}";
        }
    }
}
