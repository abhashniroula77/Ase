using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_Component_I;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Execute()
        {
            var form = new Form1();
            object b = new object();
            EventArgs c = new EventArgs();
            form.button2_Click(b, c);
            Assert.IsTrue(form.execute);
        }
    }
}
