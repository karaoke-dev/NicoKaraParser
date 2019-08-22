using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NicoKaraParser.Tests
{
    [TestClass]
    public class UnitTestDecode : BaseUnitTest
    {
        [TestMethod]
        public void Decode()
        {
            var result = DecodeWithFile();

            //TODO : check result
        }
    }
}
