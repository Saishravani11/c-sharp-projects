using CustomMathOperations;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnitTesting
{
    [TestFixture]
    public class MathNUnitTest
    {

        BasicMath bm = new BasicMath();

        [Test]
        public void Test_Add()
        {
            int result = bm.Add(4, 5);
            int expected = 9;
            Assert.That(result.Equals(expected));

        }
    }
}
