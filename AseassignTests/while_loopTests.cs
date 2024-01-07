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
    /// This is an unit test of while loop
    /// </summary>
    [TestClass()]
    public class while_loopTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "No exception founded")]
        public void while_loopTest()
        {
            while_loop wl = new while_loop(null);
            wl.validation();
        }
    }
}