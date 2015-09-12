using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace CodeCoverage.UnitTests
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void TestWithParams()
        {
            Program.Main(new[] { "10", "5" });
        }

        [Test]
        public void TestWithNull()
        {
            Program.Main(null);
        }

        [Test]
        public void DivideByZero()
        {
            Program.Main(new[] { "10", "0" });
        }
    }
}
