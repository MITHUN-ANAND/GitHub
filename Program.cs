using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client casualObj = new Client(new CasualDressFactory());
            Console.WriteLine(casualObj.CurrentDressDescription());

            Client formalObj = new Client(new FormalDressFactory());
            Console.WriteLine(formalObj.CurrentDressDescription());
        }        
    }
}
