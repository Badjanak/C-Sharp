using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface IMissile
    {
        CustomID ID
        { get; set; }

        MissileType MissileType
        { get; set; }
    }
}
