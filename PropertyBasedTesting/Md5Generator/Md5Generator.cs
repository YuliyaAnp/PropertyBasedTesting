using System.Text;

namespace HashGenerator
{
    public class Md5Generator
    {
        public string Md5(string input)
        {
            //if (input == "foo")
            //{
            //    return "acbd18db4cc2f85cedef654fccc4a4d8";
            //}

            //if (input == "bar")
            //{
            //    return "37b51d194a7513e45b56f6524f2d51f2";
            //}

            //return input.PadRight(32);
            //return (input ?? string.Empty).PadRight(32).Substring(0, 32);
            //return "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";



            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var hash = md5.ComputeHash(inputBytes);

                var sb = new StringBuilder();

                for (var i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
