using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_Component_I;
namespace unittest
{
    [TestClass]
    public class parametermethodtest
    {
        [TestMethod]
        public void getParameterTestMethod()
        {
            Form1 form = new Form1();
            //arrange
            string line = "rectangle(20,30)";
            string[] expectedArray = { "20", "30" };

            //act
            string[] actualArray = form.getParameter(line);

            //assert
            CollectionAssert.AreEqual(expectedArray, actualArray);


        }
    }
}

