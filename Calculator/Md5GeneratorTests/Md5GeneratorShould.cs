using NUnit.Framework;
using HashGenerator;

namespace Md5GeneratorTests
{
    [TestFixture]
    public class Md5GeneratorShould
    {
        [TestCase("foo", "acbd18db4cc2f85cedef654fccc4a4d8")]
        [TestCase("bar", "37b51d194a7513e45b56f6524f2d51f2")]
        public void ReturnCorrectHashForFooInput(string input, string expectedMd5)
        {
            var md5Generator = new Md5Generator();
            var actualMd5 = md5Generator.Md5(input);

            Assert.AreEqual(expectedMd5, actualMd5);
        }
    }
}
