using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_Component_I;

namespace unittest
{
    [TestClass]
    public class savetest
    {

        Form1 form;
        [TestInitialize]
        public void Initialize()
        {
            string[] shapes = { "drawto", "moveto", "rectangle", "circle", "triangle" };
            form = new Form1();

        }
        [TestMethod]
        public void checkCommandTest()
        {
            //Arrange

            string line = "circle(10)";
            //act

            bool result = form.checkCommand(line);
            //Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void runShape()
        {
            //Arrange

            string line = "circle(10)";
            string[] m_syntax = { "circle", "10)" };
            //act

            bool result = form.runShape(m_syntax, line);
            //Assert

            Assert.IsTrue(result);
        }


    }
}
