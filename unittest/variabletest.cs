using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_Component_I;

namespace unittest
{
    [TestClass]
    public class variabletest
    {
        Form1 form;
        /* Dictionary<string,string> VariableDict = new Dictionary<string,string>();*/

        [TestInitialize]
        public void Initialize()
        {

            form = new Form1();
            /* VariableDict.Add("radius","10");*/
        }
        [TestMethod]
        public void checkVariableDec()
        {
            //Arrange

            string line = "radius=10";
            //act

            bool result = form.checkVariableDec(line);
            //Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void checkVariableOperation()
        {
            //Arrange

            string line = "radius+1";

            //act

            bool result = form.checkVariableOperation(line);
            //Assert

            Assert.IsTrue(result);
        }


    }
}
