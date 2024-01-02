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
    public class CircleTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException),"No exception founded")]
        public void drawTest()
        {
            Circle c = new Circle(50);
            c.draw(null,null,0,0);
        }
    }
}