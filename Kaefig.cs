using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Kaefig
    {
        public Tier TierInKaefig { get; set; }
        public List<Type> UmweltenDesKaefigs { get; }

        public Kaefig(List<Type> umweltenDesKaefigs)
        {

            this.UmweltenDesKaefigs = umweltenDesKaefigs;
        }
    }
}
