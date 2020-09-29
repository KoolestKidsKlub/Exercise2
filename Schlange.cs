using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Schlange : Tier
    {

        public override List<Type> BenoetigteUmwelten { get; }

        public Schlange()
        {
            BenoetigteUmwelten = new List<Type>();
            BenoetigteUmwelten.Add(new Wasser().GetType());
            BenoetigteUmwelten.Add(new Wueste().GetType());
        }
    }
}
