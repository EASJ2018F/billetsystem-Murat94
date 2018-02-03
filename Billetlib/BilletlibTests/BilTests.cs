using Microsoft.VisualStudio.TestTools.UnitTesting;
using Billetlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetlib.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void TestprisPris()
        {
            Bil bil1 = new Bil();
            int pris = bil1.pris();
            Assert.AreEqual(240,pris);
        }

        [TestMethod()]
        public void TestkøretøjPris()
        {
            Bil bil2 = new Bil();
            int pris = bil2.pris();
            Assert.AreEqual(240, pris);
        }
    }
}