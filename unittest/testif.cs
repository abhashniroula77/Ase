using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_Component_I;

namespace unittest
{
    [TestClass]
    public class testif
    {
        Form1 form;
        [TestInitialize]
        public void Initialize()
        {

            form = new Form1();

        }
        [TestMethod]
        public void checkIf()
        {
            //Arrange

            string line = "if(radius=10)";
            //act

            bool result = form.checkIfElse(line);
            //Assert

            Assert.IsTrue(result);
        }


    }
}

