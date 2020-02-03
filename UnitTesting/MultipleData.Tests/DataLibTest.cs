using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultipleData.Tests
{
    [TestClass]
    public class DataLibTest
    {
        public TestContext TestContext { get; set; }
        public DataLib DataLib = new DataLib();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "User", DataAccessMethod.Sequential)]
        [TestMethod]
        public void IsVerifiedUserTest()
        {
            var name = Convert.ToString(TestContext.DataRow["name"]);
            var email = Convert.ToString(TestContext.DataRow["email"]);
            var phone = Convert.ToString(TestContext.DataRow["phone"]);
            var res = DataLib.IsVerifiedUser(name, email, phone);
            Assert.IsTrue(res,"Error");
        }
    }
}
