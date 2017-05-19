using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Entities
{
    public sealed class Missile : IMissile
    {
        public Missile(MissileType missileType, CustomID id = null)
        {
            this.MissileType = missileType;
            this.ID = string.IsNullOrEmpty(Convert.ToString(id))
                ? new CustomID()
                : id;
        }

        public CustomID ID { get; set; }
        public MissileType MissileType { get; set; }
        public override string ToString()
        {
            return $"Missile ID: {this.ID }\nMissile Type: {this.MissileType}";
        }
    }
}
