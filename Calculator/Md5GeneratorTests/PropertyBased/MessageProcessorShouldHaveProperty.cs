using System;
using FluentAssertions;
using FsCheck.NUnit;
using HashGenerator;

namespace Md5GeneratorTests.PropertyBased
{
    internal class MessageProcessorShouldHaveProperty
    {
        [Property(Arbitrary = new[] {typeof(InputMessageArbitrary)}, Verbose = true)]
        public void ToReturnOutputMessageWithTheSameType(InputMessage inputMessage)
        {
            Console.WriteLine($"InputMessage: {inputMessage.Type}, {inputMessage.Text}");
            var messageProcessor = new MessageProcessor();
            var expectedOutputType = inputMessage.Type;
            var actualOutputType = messageProcessor.GenerateOutputMessage(inputMessage).Type;

            actualOutputType.ShouldBeEquivalentTo(expectedOutputType);
        }
    }
}