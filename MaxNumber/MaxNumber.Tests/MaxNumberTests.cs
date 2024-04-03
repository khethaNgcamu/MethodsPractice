using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber.MaxNumber.Tests
{
    [TestFixture]
    public class MaxNumberTests
    {
        [Test]
        public void TestMaxNumber()
        {
            //arrange
            int a = 5;
            int b = 10;
            int expected = 10;

            //act
            int result = Program.MaxNumber(a, b);

            // Assert
            Assert.Equals(expected, result);
        }
    }
}
