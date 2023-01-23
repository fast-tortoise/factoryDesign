using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Varun
{
    internal interface IClothes
    {
        public string clothType { get; set; }

        public void create();
    }
}
