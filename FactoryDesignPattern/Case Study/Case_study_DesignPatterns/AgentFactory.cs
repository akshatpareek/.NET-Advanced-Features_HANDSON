using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_DesignPatterns
{
    static class AgentFactory
    {
        public static Order GetOrder(string productType)
        {
            if (productType == "Toy")
            {
                ToysOrder toysOrder = new ToysOrder { productType = "Toy", Channel = "Agent" };
                return toysOrder;
            }
            else if (productType == "Furniture")
            {
                FurnitureOrder furniture = new FurnitureOrder { Channel = "Agent", productType = "Furniture" };
                return furniture;
            }
            else
            {
                ElectronicOrder electronicOrder = new ElectronicOrder { productType = "Electronic", Channel = "Agent" };
                return electronicOrder;
            }
        }
    }
}
