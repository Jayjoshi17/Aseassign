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
    public class method_calling_with_paramtresTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "No exception founded")]
        public void method_calling_with_paramtresTest()
        {
            method_calling_with_paramtres mp = new method_calling_with_paramtres(null, null, null, null, null);
            mp.cmds();
        }
    }
}