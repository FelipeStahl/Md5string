using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Md5string.test
{
    [TestClass]
    public class Md5stringTeste
    {
        [TestCategory("MD5 Testes")]
        [TestMethod("Should validate MD5 string")]
        [DataRow(null, false)]
        [DataRow(" ", false)]
        [DataRow("testando", true)]
        public void ShouldValidateMD5string(string value, bool status)
        {
            var result = "CAA9C8F8620CBB30679026BB6427E11F";
            Assert.AreEqual(value.ToMD5() == result, status);
        }

        [TestCategory("MD5 Testes")]
        [TestMethod("Should validate MD5 compare")]
        [DataRow(null, false)]
        [DataRow(" ", false)]
        [DataRow("testando", true)]
        public void ShouldValidateMD5Compare(string value, bool status)
        {
            var result = "CAA9C8F8620CBB30679026BB6427E11F";
            Assert.AreEqual(value.CompareMD5(result), status);
        }
    }
}
