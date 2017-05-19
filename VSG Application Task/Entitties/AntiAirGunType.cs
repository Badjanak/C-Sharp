using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum AntiAirGunType
    {
        [Description("Anti Thermo Gun")]
        AntiThermoGun,
        [Description("Anti Facet Gun")]
        AntiFacetGun,
        [Description("Anti TNT Gun")]
        AntiTNTGun
    }
}
