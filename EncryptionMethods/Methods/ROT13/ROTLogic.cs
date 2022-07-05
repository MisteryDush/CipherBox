namespace EncryptionMethods.Methods.ROT13
{
    public static class ROTLogic
    {
        public static string Rot(string input, bool mode, int steps)
        {
            if (mode)
            {
                var result = string.Empty;
                const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string lower = "abcdefghijklmnopqrstuvwxyz";
                foreach (var ch in input)
                {
                    if (!char.IsLetter(ch))
                    {
                        result += ch;
                        continue;
                    }

                    var set = char.IsUpper(ch) ? upper : lower;
                    var letter = set[(set.IndexOf(ch) + steps) % 26];
                    result += letter;
                }

                return result;
            }
            else
            {
                var result = string.Empty;
                const string upper = "ZYXWVUTSRQPONMLKJIHGFEDCBA";
                const string lower = "zyxwvutsrqponmlkjihgfedcba";
                foreach (var ch in input)
                {
                    if (!char.IsLetter(ch))
                    {
                        result += ch;
                        continue;
                    }

                    var set = char.IsUpper(ch) ? upper : lower;
                    var letter = set[(set.IndexOf(ch) + steps) % 26];
                    result += letter;
                }

                return result;
            }
        }
    }
}