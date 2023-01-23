using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Varun
{
    internal class PlainShirt : AbstractShirt
    {
        public override void create()
        {
            Console.WriteLine("you got a plain shirt");
        }
    }
}
