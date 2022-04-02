using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var  names = new List<Names>()
            {
                new Names
                {
                    firstName = "habeeb",
                    lastName = "Bello"
                },
                new Names
                {
                    firstName = "afolabi",
                    lastName = "Bello"
                }
            };


            var c = names.Where(a => a.firstName == "haeeb").FirstOrDefault();
            if(c != null)
            {

            Console.WriteLine(c.lastName);  
            }
            else
            {

            Console.WriteLine("not found");
            }
            Console.ReadLine();

        }
    }
}
