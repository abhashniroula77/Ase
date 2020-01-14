using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_Component_I;

namespace unittest
{
    [TestClass]
    public class methodtesting
    {
        Form1 form;
        [TestInitialize]
        public void Initialize()
        {

            form = new Form1();

        }
        [TestMethod]
        public void checkMethod()
        {
            //Arrange

            string line = "method myMethod(radius)";
            //act

            bool result = form.checkMethod(line);
            //Assert

            Assert.IsTrue(result);
        }


    }
}
