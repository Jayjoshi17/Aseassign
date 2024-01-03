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
    public class if_condition_callingTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "No exception founded")]
        public void if_condition_calling()
        {
            if_condition_calling icc = new if_condition_calling(null, null, null, null, null);
            icc.comm();
        }
    }
}