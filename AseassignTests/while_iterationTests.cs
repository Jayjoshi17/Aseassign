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
    /// This is an unit test of while iteration
    /// </summary>
    [TestClass()]
    public class while_iterationTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "No exception founded")]
        public void while_iterationTest()
        {
            while_iteration wi = new while_iteration(null, null, null);
            wi.iterate();
        }
    }
}