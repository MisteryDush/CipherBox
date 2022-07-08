using System.Runtime.Serialization;

namespace EncryptionMethods.Methods.DateTimeCipher
{
    public static class DateTimeCipherLogic
    {
        public static string Controller(bool mode, string input, string key)
        {
            var str = mode ? Encrypt(input) : Decrypt(input, key);
            return str;
        }

        private static string Decrypt(string input, string key)
        {
            throw new System.NotImplementedException();
        }

        private static string Encrypt(string input)
        {
            throw new System.NotImplementedException();
        }
    }
}