namespace HashGenerator
{
    public class MessageProcessor
    {
        public OutputMessage GenerateOutputMessage(InputMessage inputMessage)
        {
            var md5Generator = new Md5Generator();
            var outputMessage =
                new OutputMessage(inputMessage.Type, md5Generator.Md5(inputMessage.Text));

            return outputMessage;
        }
    }
}
