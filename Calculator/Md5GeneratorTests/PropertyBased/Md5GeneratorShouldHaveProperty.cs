using FsCheck.NUnit;
using Md5;

namespace Md5GeneratorTests.PropertyBased
{
    public class Md5GeneratorShouldHaveProperty
    {
        [Property]
        public void ToReturnStringOfTheSameLength(string input)
        {
            var md5Generator = new Md5Generator();
            var actualMd5 = md5Generator.Md5(input);
            
            NUnit.Framework.Assert.AreEqual(32, actualMd5.Length);
        }
    }
}
