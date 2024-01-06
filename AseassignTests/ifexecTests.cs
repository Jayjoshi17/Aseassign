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
    /// This is unit test of exception for if condtion
     /// </summary>
    [TestClass()]
    public class ifexecTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]  
        public void ifexecTest()
        {
            ifexec ifec = new ifexec(null, 0);
            ifec.Source = null;
        }
    }
}