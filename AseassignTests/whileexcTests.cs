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
    /// This is a unit test of while exception class.
    /// </summary>
    [TestClass()]
    public class whileexcTests
    {
        /// <summary>
        /// This passes null for Graphics object which will throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void whileexcTest()
        {
            whileexc wc = new whileexc(null, 0);

        }
    }
}