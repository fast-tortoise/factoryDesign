using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Varun
{
    internal class FactoryDesigner : FactoryClothes
    {
        public (IClothes,IClothes) selectClothes()
        {
                
                var jeans= new DesignedJeans();
            
                var shirt= new DesignedShirt();
                
                return (jeans,shirt);
        }
    }
}
