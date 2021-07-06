using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        public void GetCohortDetails(string cohort_name, int genc_count, string mode, string track, string current_module)
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}\n", cohort_name, genc_count, track, mode, current_module);
        }

        static void Main(string[] args)
        {
            
            Program na = new Program();
        
            na.GetCohortDetails("INTADM21DF008", 27, "OBL", ".Net", "C# handson");
            na.GetCohortDetails(".Net", 27, "OBL", "INTADM21DF008", "C# handson");
            na.GetCohortDetails(track: ".Net", mode: "OBL", cohort_name: "INTADM21DF008", current_module: "C# handson", genc_count: 27);
            Console.ReadLine();
        }
    }
}
