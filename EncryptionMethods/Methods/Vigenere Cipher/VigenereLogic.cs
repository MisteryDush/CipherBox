﻿using System.Text;

namespace EncryptionMethods.Methods.Vigenere_Cipher
{
    public static class VigenereLogic
    {
        private static string AlphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string AlphabetLower = "abcdefghijklmnopqrstuvwxyz";
        public static string Encrypt(string input, bool mode, string key)
        {
            var sb = new StringBuilder();
            var i = 0;
            var keyCount = key.Length;
            if (mode)
            {
                foreach (var ch in input)
                {
                    if (char.IsLetter(ch))
                    {
                        if (char.IsUpper(ch))
                        {
                            var indexLetter = AlphabetUpper.IndexOf(ch);
                            var keyLetterIndex = AlphabetUpper.IndexOf(char.ToUpper(key[i % keyCount]));
                            var newLetter = AlphabetUpper[(indexLetter + keyLetterIndex) % 26];
                            sb.Append(newLetter);
                            i++;
                        }
                        else
                        {
                            var indexLetter = AlphabetLower.IndexOf(ch);
                            var keyLetterIndex = AlphabetLower.IndexOf(char.ToLower(key[i % keyCount]));
                            var newLetter = AlphabetLower[(indexLetter + keyLetterIndex) % 26];
                            sb.Append(newLetter);
                            i++;
                        }
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }
            }

            return sb.ToString();
        }
    }
}