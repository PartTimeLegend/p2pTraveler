namespace p2pTraveler
{
    public class Strings
    {
        public static string Reverse(string text)
        {
            var reverse = string.Empty;
            for (var i = text.Length - 1; i > -1; i--)
            {
                reverse += text[i];
            }
            return reverse;
        }
    }
}
