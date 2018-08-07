using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathsComponentNameSpace;

namespace MathsTestProject
{
    //  Summary descroption for UnitTest1

    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            // TODO: Add constructor logic here
        }

        private TestContext testContextInstance;

        // Gets or sets the test context which provides information 
        // about and functionality for the current test run.

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }

            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod] 
        public void TestAdd()
        {
            // TODO: Add text logic here
            MathsComponent obj = new MathsComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            MathsComponent obj = new MathsComponent;
            int result = obj.Subtract(10, 9);
            Assert.AreEqual(1, result);
        }

    }
}
