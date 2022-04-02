using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Customer
    {
        public string Name => "Habeeb";

        public int GetOrderByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }
        public int age => 39;

        public string GetFullName(string firstname, string lastname) => $"{firstname} {lastname}";
            
    }
}
