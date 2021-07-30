using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_DesignPatterns
{
    class ToysOrder : Order
    {
        public override string Channel { get; set ; }
        public override string productType { get ; set ; }

        public override void ProcessOrder()
        {
            Console.WriteLine("{0} Order Placed by {1} !!",productType,Channel);
        }
    }
}
