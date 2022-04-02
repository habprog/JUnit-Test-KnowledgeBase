using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulations.Tests
{
    public static class TestShareData
    {
        public static IEnumerable<object[]> IsOddOrEvenData
        {
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 200, false };
            }
        }

        public static IEnumerable<object[]> IsEvenOrOddDataFile
        {
            get
            {
                var allLines = File.ReadAllLines("ShareDataTestFile.txt");

                return allLines.Select(i =>
                {
                    var lineSplit = i.Split(',');
                    return new object[] { int.Parse(lineSplit[0]), bool.Parse(lineSplit[1]) };
                });
            }
        }
    }
}
