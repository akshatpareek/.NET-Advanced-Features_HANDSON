using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit2
{
    [TestFixture]
    class Test
    {
        int res = 0;
        [Test]
        [TestCase(9, 7, 2)]
        [TestCase(9, 8, 1)]
        [TestCase(8, 7, 1)]
        public void Sub(int a, int b, int c)
        {

            CalculateTests n = new CalculateTests();
            res = n.Subtraction(a, b);
            Assert.AreEqual(res, c);

        }

        [Test]
        [TestCase(8, 8, 64)]
        [TestCase(7, 6, 42)]
        [TestCase(9, 1, 9)]
        public void Mul(int a, int b, int c)
        {

            CalculateTests n = new CalculateTests();
            res = n.Multiply(a, b);
            Assert.AreEqual(res, c);

        }


        [Test]
        [TestCase(8, 8, 1)]
        [TestCase(7, 6, 1)]
        [TestCase(9, 1, 9)]
        public void Div(int a, int b, int c)
        {

            CalculateTests n = new CalculateTests();
            res= n.Division(a, b);
            Assert.AreEqual(res, c);
            

        }

    }
}
