using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitties
{
    public class CommunicationCenter
    {
        public CommunicationCenter(AntiAirGunType antiAirGunType, Missile missile, DateTime? timeOfEvent, CustomID id = null)
        {
            this.AntiAirGunType = antiAirGunType;
            this.Missile = missile;
            this.TimeOfEvent = DateTime.Now;
            this.ID = string.IsNullOrEmpty(Convert.ToString(id))
                ? new CustomID()
                : id;
        }

        public CustomID ID { get; set; }
        public Missile Missile { get; set; }
        public AntiAirGunType AntiAirGunType { get; set; }
        public DateTime? TimeOfEvent { get; set; }

        public override string ToString()
        {
            return $"Anti Air Gun: {this.AntiAirGunType} neutralized\n" +
                $"Missile: {this.Missile.MissileType}\nMissile Serial No. :{this.Missile.ID}\n" +
                $"At {this.TimeOfEvent}";
        }
    }
}

