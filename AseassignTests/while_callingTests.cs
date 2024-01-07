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
    /// This is the unit test for caalling while loop
    /// </summary>
    [TestClass()]
    public class while_callingTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "No exception founded")]
        public void while_callingTest()
        {
            while_calling wc = new while_calling(null, null, null, null, null);
            wc.cmds();
        }
    }
}