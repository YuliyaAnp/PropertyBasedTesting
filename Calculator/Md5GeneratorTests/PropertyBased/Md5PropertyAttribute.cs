using FsCheck.NUnit;

namespace Md5GeneratorTests.PropertyBased
{
    public class MD5PropertyAttribute : PropertyAttribute
    {
        public MD5PropertyAttribute()
        {
            Arbitrary = new[] { typeof(NonNullStringArbitrary) };
        }
    }
}
