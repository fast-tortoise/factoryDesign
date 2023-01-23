using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Varun
{
    internal class FactoryClothes : IClothesFactory
    {
        public (IClothes,IClothes) GetClothes(string typeOfcloth)
        {
            
            if (typeOfcloth == "plain")
            {
                var factoryPlain = new FactoryPlain();
                (var jeans, var shirt)= factoryPlain.selectClothes();
                return (jeans, shirt);

            }
            else
            {
                var factoryDesigner = new FactoryDesigner();
                (var jeans, var shirt) = factoryDesigner.selectClothes();
                return (jeans, shirt);
            }
            
            
        }
    }
}
