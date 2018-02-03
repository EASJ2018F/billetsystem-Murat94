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
    public class MCTests
    {
        [TestMethod()]
        public void TesprisTest()
        {
            MC MC1 = new MC();
            int pris = MC1.pris();
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void TestkøretøjTest()
        {
            MC Harley = new MC();
            string køretøj = Harley.køretøj();
            Assert.AreEqual("Mc", køretøj);
        }
    }
}