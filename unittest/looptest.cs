using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_Component_I;

namespace unittest
{
    [TestClass]
    public class looptest
    {

        Form1 form;
        [TestInitialize]
        public void Initialize()
        {

            form = new Form1();

        }
        [TestMethod]
        public void checkLoop()
        {
            //Arrange

            string line = "loop for counter<=10";
            //act

            bool result = form.checkLoop(line);
            //Assert

            Assert.IsTrue(result);
        }


    }
}
