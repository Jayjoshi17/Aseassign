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
    /// This is a unit test for triangle exception class
    /// </summary>
    [TestClass()]
    public class trianglexcTests
    {
        /// <summary>
        /// This will passes null for Graphics object which will throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void trianglexcTest()
        {
            trianglexc tc = new trianglexc(null, 0);
        }
    }
}