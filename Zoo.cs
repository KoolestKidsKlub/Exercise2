using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Zoo
    {
        public List<Zoowaerter> Zoowaerters { get; set; }

        public Zoo()
        {
            Zoowaerters = new List<Zoowaerter>();
        }
    }
}
