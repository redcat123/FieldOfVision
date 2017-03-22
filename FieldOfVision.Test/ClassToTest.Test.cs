using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FieldOfVision;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FieldOfVision.Test
{
    [TestClass]
    public class ClassToTestTest
    {
        [TestMethod]
        public void Can_Double()
        {
            int input = 6;
            var classToTest = new ClassToTest();
            Assert.AreEqual(input * 2, classToTest.Doubler(input), "Doubler didn't work");
        }
    }
}
