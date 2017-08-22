namespace HashGenerator
{
    public class InputMessage
    {
        public string Type { get; }
        public string Text { get; }

        public InputMessage(string type, string text)
        {
            Type = type;
            Text = text;
        }
    }
}
