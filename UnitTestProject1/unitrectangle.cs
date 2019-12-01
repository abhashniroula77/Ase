using ASE_Component_I;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{

    [TestClass]
    public class unitrectangle
    {
        [TestMethod]
        public void TestMethod2()
        {
            var formv = new Rectangle ();
            var a = formv.x;
            var b = formv.y;
            var c = formv.b;
            var d = formv.l;
            formv.values(1, 2, 3,4);
            bool test = false;
            if (a != formv.x && b != formv.y && c != formv.b && d != formv.l) 
                test = true;
            Assert.IsTrue(test);

        }
    }
}
