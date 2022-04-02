using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculation;

namespace Calulations.Tests
{
    [Collection("Customer")]
    public class CustomerTest
    {
        private readonly CustomerFixture _customerfixture;

        public CustomerTest(CustomerFixture customerfixture)
        {
            _customerfixture = customerfixture;
        }

        [Fact]
        public void CheckCustomerNameNotEmpty()
        {
            var customer = _customerfixture.Cust;
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void CheckLegitDiscount()
        {
            var customer = _customerfixture.Cust;
            Assert.InRange(customer.age, 25, 40);
        }

        [Fact]
        public void GetrderByNameNotNull()
        {
            var customer = _customerfixture.Cust;

            var exceptionDetail = Assert.Throws<ArgumentException>(() => customer.GetOrderByName(null));
            Assert.Equal("Hello", exceptionDetail.Message);
        }
    }
}
