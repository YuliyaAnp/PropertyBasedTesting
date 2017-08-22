using FsCheck;
using HashGenerator;

namespace Md5GeneratorTests.PropertyBased
{
    public class InputMessageArbitrary
    {
        public static Arbitrary<InputMessage> InputMessages()
        {
            return Gen.Sized(InputMessageGenerator.Generator).ToArbitrary();
        }
    }

    public static class InputMessageGenerator
    {
        public static Gen<InputMessage> Generator(int depth)
        {
            var inputMessage = 
                from type in Arb.Generate<string>() where type != null
                from text in Arb.Generate<string>() where text != null
                select new InputMessage(type, text);
            return inputMessage;
        }
    }



}
