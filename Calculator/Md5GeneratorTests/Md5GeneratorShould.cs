using Md5;
using NUnit.Framework;

namespace Md5GeneratorTests
{
    [TestFixture]
    public class Md5GeneratorShould
    {
        [Test]
        public void ReturnCorrectHashForFooInput()
        {
            var md5Generator = new Md5Generator();
            var actualMd5 = md5Generator.Md5("foo");
            var expectedMd5 = "acbd18db4cc2f85cedef654fccc4a4d8";

            Assert.AreEqual(expectedMd5, actualMd5);
        }
    }
}
