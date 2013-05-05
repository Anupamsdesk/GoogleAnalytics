using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unitTest
{
    using Json;
    using Model;

    [TestClass]
    public class JsonSerializerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var myobject = new Json.Deserializer().parseFromFile<GoogleOAuth2Config>("testconfig.json");
            Assert.AreEqual(myobject.GetType(), typeof(GoogleOAuth2Config));
        }
    }
}
