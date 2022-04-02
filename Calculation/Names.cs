using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Names
    {
        public string NickName { get; set; }
        public string MakeFullName (string firstname, string lastname)
        {
            return $"{firstname} {lastname}";
        }


        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
