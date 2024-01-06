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
    /// This is a unit test for square and rectangle class
    /// </summary>
    [TestClass()]
    public class sqandrecexTests
    {
        /// <summary>
        /// This passes null for Graphics object which will throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void sqandrecexTest()
        {
            sqandrecex sqr = new sqandrecex(null, 0);
        }
    }
}