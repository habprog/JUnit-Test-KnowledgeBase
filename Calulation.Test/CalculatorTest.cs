using Calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calulations.Tests
{

    public class CalculatorFixture
    {
        public Calculator Cal => new Calculator();
    }

    public class CalculatorTest : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _calculatorFixture;
        public CalculatorTest(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture =  calculatorFixture;
        }

        [Fact]
        public void Add_GivenTwoIntValue_ReturnInt()
        {
            var cal = _calculatorFixture.Cal;
            var result = cal.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenDoubleValue_ReturnDouble()
        {
            var cal = _calculatorFixture.Cal;
            var result = cal.AddDouble(1.2, 3.5);

            Assert.Equal(4.7, result);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotContainZero()
        {
            var cal = _calculatorFixture.Cal;
            Assert.All(cal.FiboNumbers, n => Assert.NotEqual(0, n)); // check if zero is not included in the fibo serize

        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboInclude13()
        {
            var cal = _calculatorFixture.Cal;
            Assert.Contains(13, cal.FiboNumbers); // check if 13 is included
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            var cal = _calculatorFixture.Cal;
            Assert.DoesNotContain(4, cal.FiboNumbers); // check if 4 is not included
        }

        [Fact]
        public void CheckCollection()
        {
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var cal = _calculatorFixture.Cal;

            Assert.Equal(expectedCollection, cal.FiboNumbers); // check collection of serize against another
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnTrue()
        {
            var cal = _calculatorFixture.Cal;
            var result  = cal.IsOdd(1);
            Assert.True(result);
        }
        
        [Fact]
        public void IsOdd_GivenEvenValue_ReturnFalse()
        {
            var cal = _calculatorFixture.Cal;
            var result  = cal.IsOdd(2);
            Assert.False(result);
        }

        [Theory]
        //[InlineData(1, true)] //using inline data
        //[InlineData(2, false)]
        //[MemberData(nameof(TestShareData.IsOddOrEvenData), MemberType = typeof(TestShareData))] //using share data
        [MemberData(nameof(TestShareData.IsEvenOrOddDataFile), MemberType = typeof(TestShareData))] //using external data
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var cal = _calculatorFixture.Cal;
            var result = cal.IsOdd(value);
            Assert.True(expected);
        }
    }
}
