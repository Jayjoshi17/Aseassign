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
    public class if_conditionTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "No exception founded")]
        public void if_conditionTest()
        {
            if_condition ifc = new if_condition(null, null);
            ifc.if_statement();
        }
    }
}