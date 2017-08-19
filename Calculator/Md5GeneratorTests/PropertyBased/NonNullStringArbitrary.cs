using FsCheck;

namespace Md5GeneratorTests.PropertyBased
{
    public static class NonNullStringArbitrary
    {
        public static Arbitrary<string> Strings()
        {
            return Arb.Default.String().Filter(x => x != null);
        }
    }
}
