using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aseassign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Aseassign.Tests
{
    [TestClass()]
    public class vb_opTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "No exception founded")]
        public void vb_opTest()
        {
           vb_op vp = new vb_op(null, null);
            vp.n_w(null);
        }
    }
}