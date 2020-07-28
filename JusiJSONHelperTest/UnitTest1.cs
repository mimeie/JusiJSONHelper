using Microsoft.VisualStudio.TestTools.UnitTesting;
using JusiJSONHelper;

namespace JusiJSONHelperTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IntHelper ih = new IntHelper();
            bool result = ih.getResult();
        }
    }
}
