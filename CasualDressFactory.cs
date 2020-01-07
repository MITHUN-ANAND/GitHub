using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CasualDressFactory : DressFactory
    {
        public override Shirt GetShirt()
        {
            return new CasualShirt();
        }

        public override Trouser GetTrouser()
        {
            return new Jeans();
        }
    }
}
