using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_DesignPatterns
{
    static class ECommerceFactory
    {
        public static Order GetOrder(string productType)
        {
            if (productType == "Toy")
            {
                ToysOrder toysOrder = new ToysOrder { productType = "Toy", Channel = "ECommerce" };
                return toysOrder;
            }
            else if (productType == "Furniture")
            {
                FurnitureOrder furniture = new FurnitureOrder { Channel = "ECommerce", productType = "Furniture" };
                return furniture;
            }
            else
            {
                ElectronicOrder electronicOrder = new ElectronicOrder { productType = "Electronic", Channel = "ECommerce" };
                return electronicOrder;
            }
        }
    }
}
