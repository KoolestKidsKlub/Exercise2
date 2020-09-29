using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Fisch : Tier
    {
        public override List<Type> BenoetigteUmwelten { get; }

        public Fisch()
        {
            BenoetigteUmwelten = new List<Type>();
            BenoetigteUmwelten.Add(new Wasser().GetType());
        }
    }
}
