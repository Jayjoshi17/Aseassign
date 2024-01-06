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
    /// This unit test is for method exception class file.
    /// </summary>
    [TestClass()]
    public class methdexcTests
    {
        /// <summary>
        /// This passes null for Graphics object which will throw an exception
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]  
        public void methdexcTest()
        {
            methdexc mtc = new methdexc(null, 0);

        }
    }
}