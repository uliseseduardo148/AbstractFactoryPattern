using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class VeggieGarden:Garden
    {
        public VeggieGarden()
        {
            shade = new Plant("Brocoli");
            border = new Plant("Frijoles");
            center = new Plant("Maíz");
        }
    }
}
