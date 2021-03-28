using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Md5string.test
{
    [TestClass]
    public class Md5stringTeste
    {
        [TestCategory("MD5 Testes")]
        [TestMethod("Shold validate MD5 string")]
        [DataRow(null, false)]
        [DataRow(" ", false)]
        [DataRow("testando", true)]
        //CAA9C8F8620CBB30679026BB6427E11F == testando
        public void SholdValidateMd5string(string value, bool status)
        {
            var result = "CAA9C8F8620CBB30679026BB6427E11F";
            Assert.AreEqual(value.ToMd5() == result, status);
        }

        [TestCategory("MD5 Testes")]
        [TestMethod("Shold validate MD5 compare")]
        [DataRow(null, false)]
        [DataRow(" ", false)]
        [DataRow("testando", true)]
        //CAA9C8F8620CBB30679026BB6427E11F == testando
        public void SholdValidateMd5Compare(string value, bool status)
        {
            var result = "CAA9C8F8620CBB30679026BB6427E11F";
            Assert.AreEqual(value.CompareMd5(result), status);
        }
    }
}
