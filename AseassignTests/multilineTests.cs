using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aseassign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign.Tests
{
    [TestClass()]
    public class multilineTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "No exception founded")]
        public void multilineTest()
        {
            multiline ln = new multiline(null, null, null);
            ln.multiline_call();
        }
    }
}