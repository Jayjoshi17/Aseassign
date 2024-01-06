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
    /// This is a unit test of clear exception
    /// </summary>
    [TestClass()]
    public class cexcTests
    {
        /// <summary>
        /// This passes null for Graphics object which will throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void cexcTest()
        {
            cexc cc = new cexc(null, 0);
        }
    }
}