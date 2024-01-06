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
   /// This is unit test for not a valid excetion class
   /// </summary>
    [TestClass()]
    public class notavalidexcTests
    {
        /// <summary>
        /// This passes null for Graphics object which will throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))] 
        public void notavalidexcTest()
        {
            notavalidexc nav = new notavalidexc(null ,0);
        }
    }
}