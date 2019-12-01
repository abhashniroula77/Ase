using ASE_Component_I;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTest1
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]

        public void TestMethod1()
        {
            var formA = new Circle();
            var a = formA.r;
            var b = formA.x;
            var c = formA.y;
            formA.values(1, 2, 3);
            bool test = false;
            if (a != formA.r && b != formA.x && c != formA.y)
                test = true;
            Assert.IsTrue(test);

        }
    }
}