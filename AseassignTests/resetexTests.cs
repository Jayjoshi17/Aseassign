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
    /// This is a unit test for reset exception class
    /// </summary>
    [TestClass()]
    public class resetexTests
    {
        /// <summary>
        /// Null for Graphics object which will throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void resetexTest()
        {
           resetex rs = new resetex(null ,0);
        }
    }
}