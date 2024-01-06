using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aseassign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign.Tests
{
    /// <summary>
    /// This is a unit test of command line empty exception
    /// </summary>
    [TestClass()]
    public class emptycmdexcTests
    {
        /// <summary>
        /// This will pass null for Graphic object which will throw an exception
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void emptycmdexcTest()
        {
            emptycmdexc ecmd = new emptycmdexc(null, 0);
        }
    }
}