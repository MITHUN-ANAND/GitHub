using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FormalDressFactory : DressFactory
    {
        public override Shirt GetShirt()
        {
            return new FormalShirt();
        }

        public override Trouser GetTrouser()
        {
            return new Chinos();
        }
    }
}
