using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Varun
{
    internal class FactoryPlain : FactoryClothes
    {
        public (IClothes, IClothes) selectClothes()
        {

            var jeans = new PlainJeans();

            var shirt = new PlainShirt();

            return (jeans, shirt);
        }
    }
}
