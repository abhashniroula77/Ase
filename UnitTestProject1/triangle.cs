using ASE_Component_I;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestProject1
{ 
 

        [TestClass]
        public class triangle
        {
            [TestMethod]
            public void TestMethod2()
            {
                var formv = new Triangle();
                var a = formv.val1;
                var b = formv.val2;
                var c = formv.bas;
                var d = formv.perp;
                var e = formv.hypt;
                formv.values(1, 2, 3, 4);
                bool test = true;
                if (a != formv.val1 && b != formv.val2 && c != formv.bas && d != formv.perp  && e!=formv.hypt)
                    test = true;
                Assert.IsTrue(test);

            }
        }

    
}
