using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_DesignPatterns
{
    public class MainFactory
    {
        public Order getOrder(string channel, string productType)
        {
            if (channel == "Agent")
            {
                return AgentFactory.GetOrder(productType);
            }
            else
            {
                return ECommerceFactory.GetOrder(productType);
            }
        }
    }
}
