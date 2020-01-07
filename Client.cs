using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Client
    {
        private readonly Shirt _shirt;
        private readonly Trouser _trouser;

        public Client(DressFactory dressFactory)
        {
            _shirt = dressFactory.GetShirt();
            _trouser = dressFactory.GetTrouser();
        }

        public string CurrentDressDescription()
        {
            return _shirt.GetType().Name + " " + _trouser.GetType().Name;
        }
    }
}
