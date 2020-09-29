using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo testZoo = new Zoo();

            Zoowaerter schlumpfWaerter = new Zoowaerter();

            List<Type> grasWasser = new List<Type>();
            grasWasser.Add(new Grasland().GetType());
            grasWasser.Add(new Wasser().GetType());

            List<Type> wasser = new List<Type>();
            wasser.Add(new Wasser().GetType());

            List<Type> wuesteWasser = new List<Type>();
            wuesteWasser.Add(new Wueste().GetType());
            wuesteWasser.Add(new Wasser().GetType());

            Kaefig grasWasserKaefig1 = new Kaefig(grasWasser);
            Kaefig grasWasserKaefig2 = new Kaefig(grasWasser);
            Kaefig wasserKaefig1 = new Kaefig(wasser);
            Kaefig wasserKaefig2 = new Kaefig(wasser);
            Kaefig wuesteWasserKaefig1 = new Kaefig(wuesteWasser);
            Kaefig wuesteWasserKaefig2 = new Kaefig(wuesteWasser);

            Tier loewe1 = new Loewe();
            Tier loewe2 = new Loewe();
            Tier schlange1 = new Schlange();
            Tier schlange2 = new Schlange();
            Tier fisch1 = new Fisch();
            Tier fisch2 = new Fisch();

            testZoo.Zoowaerters.Add(schlumpfWaerter);
            
            schlumpfWaerter.Kaefige.Add(grasWasserKaefig1);
            schlumpfWaerter.Kaefige.Add(grasWasserKaefig2);
            schlumpfWaerter.Kaefige.Add(wasserKaefig1);
            schlumpfWaerter.Kaefige.Add(wasserKaefig2);
            schlumpfWaerter.Kaefige.Add(wuesteWasserKaefig1);
            schlumpfWaerter.Kaefige.Add(wuesteWasserKaefig2);

            schlumpfWaerter.SetzeInFreienKaefig(fisch1);
            schlumpfWaerter.SetzeInFreienKaefig(loewe2);
            schlumpfWaerter.SetzeInFreienKaefig(schlange1);
            schlumpfWaerter.SetzeInFreienKaefig(schlange2);
            schlumpfWaerter.SetzeInFreienKaefig(loewe1);
            schlumpfWaerter.SetzeInFreienKaefig(fisch2);

            schlumpfWaerter = null;
            grasWasser = null;
            wasser = null;
            wuesteWasser = null;
            grasWasserKaefig1 = null;
            grasWasserKaefig2 = null;
            wasserKaefig1 = null;
            wasserKaefig2 = null;
            wuesteWasserKaefig1 = null;
            wuesteWasserKaefig2 = null;
            loewe1 = null;
            loewe2 = null;
            schlange1 = null;
            schlange2 = null;
            fisch1 = null;
            fisch2 = null;



            Console.ReadLine();

        }
    }
}
