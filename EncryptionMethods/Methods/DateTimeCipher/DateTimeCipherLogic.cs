using System;
using System.Runtime.Serialization;
using System.Text;
using EncryptionMethods.Methods.ROT13;
using EncryptionMethods.Methods.Vigenere_Cipher;

namespace EncryptionMethods.Methods.DateTimeCipher
{
    public static class DateTimeCipherLogic
    {
        public static string[] Controller(bool mode, string input, string key)
        {
            var arr = mode ? Encrypt(input) : Decrypt(input, key);
            return arr;
        }

        private static string[] Decrypt(string input, string key)
        {
            throw new System.NotImplementedException();
        }

        private static string[] Encrypt(string input)
        {
            var time = DateTime.Now.ToString("hh:mm:ss").Split(':');
            // Step 1. Use hours to encrypt using ROT, e.g. 5pm will be ROT with the key of 17
            var iter1 = ROTLogic.Rot(input, true, int.Parse(time[0]));
            // Step 2. Use minutes and seconds as a key for Vigenere Cipher, first iteration is using minutes, second is using seconds.
            var iter2 = VigenereLogic.Encrypt(iter1, time[1]);
            var iter3 = VigenereLogic.Encrypt(iter2, time[2]);
            return new[] {iter3, string.Join("", time)};

        }
    }
}