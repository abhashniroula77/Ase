using ASE_Component_I;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class movetest
    {
        
        [TestMethod]
        public void movep()
        {
            var form = new Form1();
            var a = form.xAxis;
            var b = form.yAxis;
            form.movepen(20, 30);
            bool we = false;
            if (a != form.xAxis && b != form.yAxis)
                we = true;
            Assert.IsTrue(we);
        }
    } 
}
