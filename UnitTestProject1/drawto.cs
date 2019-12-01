using ASE_Component_I;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class drawto
    {
        [TestMethod]
        public void drawen()
        {
            var form = new Form1();
            var a = form.xAxis;
            var b = form.yAxis;
            form.drawpen(20,30);
            bool we = false;
            if (a != form.xAxis && b != form.yAxis)
                we = true;
            Assert.IsTrue(we);
        }
    }
}
