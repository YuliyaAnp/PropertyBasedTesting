namespace HashGenerator
{
    public class OutputMessage
    {
        public string Type { get; }
        private string Hash { get; }

        public OutputMessage(string type, string hash)
        {
            Type = type;
            Hash = hash;
        }
    }
}
