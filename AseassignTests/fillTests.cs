﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aseassign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign.Tests
{
    [TestClass()]
    public class fillTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "No exception founded")]
        public void fillTest()
        {
            fill fl = new fill(null);
            fl.fillvalue = null;
        }
    }
}