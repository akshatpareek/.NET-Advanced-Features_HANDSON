using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Handson1
{
    [TestFixture]
    class Test
    {
        int result = 0;
        [Test]
        [TestCase(8, 8, 16)]
        [TestCase(7, 6, 13)]
        [TestCase(9, 11, 20)]
        public void Add(int a,int b, int c)
        {
            
            CalculateTests n = new CalculateTests();
            result = n.Add(a, b);
            Assert.AreEqual(result,c);

        }
    }
}
