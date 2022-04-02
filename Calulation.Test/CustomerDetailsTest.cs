using Calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calulations.Tests
{
    [Collection("Customer")]
    public class CustomerDetailsTest
    {
        private readonly CustomerFixture _customerfixture;

        public CustomerDetailsTest(CustomerFixture customerfixture)
        {
            _customerfixture = customerfixture;
        }

        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnFullName()
        {
            var cust = _customerfixture.Cust;
            Assert.Equal("Bello Habeeb", cust.GetFullName("Bello", "Habeeb"));
        }
    }
}
