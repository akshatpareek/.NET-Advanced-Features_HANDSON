using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        public void OrderDetails(string SellerName, string ProductName, int Quantity = 1, bool Returnable = true)
        {
            Console.WriteLine("Here is the order detail – {0} number of {1} by {2} is ordered. It’s returnable status is {3}\n", Quantity, ProductName, SellerName, Returnable);
        }

        static void Main(string[] args)
        {

            Program opt = new Program();
            opt.OrderDetails("Amazon", "Samsung S21");
            opt.OrderDetails("Amazon", "Samsung S21", 7, false);
            Console.ReadLine();

        }
    }
}

