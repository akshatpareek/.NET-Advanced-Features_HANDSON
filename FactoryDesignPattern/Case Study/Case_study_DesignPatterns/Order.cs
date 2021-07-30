using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_DesignPatterns
{
    public abstract class Order
    {
        public abstract string Channel { get; set; }

        public abstract string productType { get; set; }

        public abstract void ProcessOrder();
    }
}
