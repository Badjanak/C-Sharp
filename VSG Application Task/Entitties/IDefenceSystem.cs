using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IDefenceSystem
    {
        CustomID ID
        { get; set; }

        AntiAirGunType AntiAirGunType
        { get; set; }

        void InterceptMissile(Missile missile);
        void Neutralize(Missile missile);
    }
}
