using NUnit.Framework;
using System.Text.RegularExpressions;
using HashGenerator;

namespace Md5GeneratorTests.PropertyBased
{
    public class Md5GeneratorShouldHaveProperty
    {
        [FsCheck.NUnit.Property]
        public void ToReturnStringOfTheSameLength(string input)
        {
            var md5Generator = new Md5Generator();
            var actualMd5 = md5Generator.Md5(input);
            
            Assert.AreEqual(32, actualMd5.Length);
        }

        //[FsCheck.NUnit.Property(Arbitrary = new[] { typeof(NonNullStringArbitrary) })]
        //public void ToReturnStringOfAlphaNumericCharacters(string input)
        //{
        //    var md5Generator = new Md5Generator();
        //    var actualMd5 = md5Generator.Md5(input);

        //    Assert.True(Regex.IsMatch(actualMd5, @"\A\b[0-9a-fA-F]+\b\Z"));

        //}

        //[FsCheck.NUnit.Property(Arbitrary = new[] { typeof(NonNullStringArbitrary) })]
        //public void ToReturnSameHashForSameInput(string input)
        //{
        //    var md5Generator = new Md5Generator();
        //    var actualMd5First = md5Generator.Md5(input);
        //    var actualMd5Second = md5Generator.Md5(input);

        //    Assert.AreEqual(actualMd5First, actualMd5Second);
        //}

        //[MD5Property]
        //public void ToReturnStringDifferentFromInput(string input)
        //{
        //    var md5Generator = new Md5Generator();
        //    var actualMd5 = md5Generator.Md5(input);

        //    Assert.AreNotEqual(input, actualMd5);
        //}

        //[FsCheck.NUnit.Property(Arbitrary = new[] { typeof(NonNullStringArbitrary) }, Verbose = true)]
        //public void ToReturnDifferentHashesForSimilarInputs(string input, char addition)
        //{
        //    var similar = input + addition;
        //    var md5Generator = new Md5Generator();
        //    var actualMd5First = md5Generator.Md5(input);
        //    var actualMd5Second = md5Generator.Md5(similar);

        //    var difference = Difference(actualMd5First, actualMd5Second);
        //    Assert.Less(difference, 8);
        //}

        private int Difference(string first, string second)
        {
            var result = 0;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])
                    result++;
            }

            return result;
        }
    }
}
