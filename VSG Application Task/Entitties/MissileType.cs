using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum MissileType
    {
        [Description("Thermo Nuclear")]
        Thermonuclear,
        [Description("Facet Bomb")]
        FacetBomb,
        [Description("TNT Bomb")]
        TNTBomb
    }
}
