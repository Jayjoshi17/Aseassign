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
    /// This is a unit test of exception for circle.
    /// </summary>
    [TestClass()]
    public class circleexcepTests
    {
        /// <summary>
        /// This will throw an exception for Graphics object when null passes it. 
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "This Exception is not found")]
        public void circleexcepTest()
        {
            circleexcep cc = new circleexcep(null, 0);
        }
    }
}