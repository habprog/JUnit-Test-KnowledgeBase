using Calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calulations.Tests
{
    public  class NameTest
    {
        [Fact]
        public void Names_AcceptTwoStringParameterOfFirstAndLastName_ReturnFullName()
        {
            var names = new Names();
            var result = names.MakeFullName("Habeeb", "Bello");

            Assert.Equal("habeeb bello", result, ignoreCase: true); //using Eqaul method is case sensitive
                                                                    //to ignore case sensitive use ignoreCase:true

            //Assert.Contains("habeeb", result, StringComparison.InvariantCultureIgnoreCase); // use of contain check if any of expectedSubstring
            // is present in actualString which is result
            // Conatains is casesensitive and can be ignore

            //Assert.StartsWith("hab", result, StringComparison.InvariantCultureIgnoreCase); //StartsWtih verify that a string start with a given comparison type

            //Assert.EndsWith("hab", result, StringComparison.InvariantCultureIgnoreCase); //Endwith verify that a string end with a given comparison type

            //Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result); // using Regix Matches


        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            names.NickName = "Strong";
            Assert.NotNull(names.NickName);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("habeeb", "bello");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
