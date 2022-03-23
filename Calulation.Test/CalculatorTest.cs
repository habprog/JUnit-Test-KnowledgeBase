using Calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calulations.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_GivenTwoIntValue_ReturnInt()
        {
            var cal = new Calculator();
            var result = cal.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenDoubleValue_ReturnDouble()
        {
            var cal = new Calculator();
            var result = cal.AddDouble(1.2, 3.5);

            Assert.Equal(4.7, result);
        }

        [Fact]
        public void FiboDoesNotContainZero()
        {
            var cal = new Calculator();
            Assert.All(cal.FiboNumbers, n => Assert.NotEqual(0, n)); // check if zero is not included in the fibo serize

        }

        [Fact]
        public void FiboInclude13()
        {
            var cal = new Calculator();
            Assert.Contains(13, cal.FiboNumbers); // check if 13 is included
        }

        [Fact]
        public void FiboDoesNotInclude4()
        {
            var cal = new Calculator();
            Assert.DoesNotContain(4, cal.FiboNumbers); // check if 4 is not included
        }

        [Fact]
        public void CheckCollection()
        {
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var cal = new Calculator();

            Assert.Equal(expectedCollection, cal.FiboNumbers); // check collection of serize against another
        }
    }
}
