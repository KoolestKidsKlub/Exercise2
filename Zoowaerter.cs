using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Zoowaerter
    {
        public List<Kaefig> Kaefige { get; set; }

        public Zoowaerter()
        {
            Kaefige = new List<Kaefig>();
        }
        public bool SetzeInFreienKaefig(Tier tier)
        {
            foreach (Kaefig tempKaefig in Kaefige)
            {
                if (tempKaefig.TierInKaefig == null)
                {
                    foreach (Type tempTierUmwelt in tier.BenoetigteUmwelten)
                    {
                        bool umweltErfuellt = false;
                        foreach (Type tempKaefigUmwelt in tempKaefig.UmweltenDesKaefigs)
                        {
                            if (tempKaefigUmwelt.Equals(tempTierUmwelt))
                            {
                                umweltErfuellt = true;
                            }
                        }
                        if (umweltErfuellt == false) goto UmweltenNichtErfuellt;
                    }

                    tempKaefig.TierInKaefig = tier;
                    return true;

                }
                UmweltenNichtErfuellt:;
            }
            return false;
        }
    }
}
