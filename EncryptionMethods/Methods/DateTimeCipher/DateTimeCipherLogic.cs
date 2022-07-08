﻿using System;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using EncryptionMethods.Methods.ROT13;
using EncryptionMethods.Methods.Vigenere_Cipher;

namespace EncryptionMethods.Methods.DateTimeCipher
{
    public static class DateTimeCipherLogic
    {

        private static string[] Numbers = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};        
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
            var minsToString = $"{Numbers[int.Parse(char.GetNumericValue(time[1][0]).ToString())]}{Numbers[int.Parse(char.GetNumericValue(time[1][1]).ToString())]}";
            var iter2 = VigenereLogic.Encrypt(iter1, minsToString);
            var secToString = $"{Numbers[int.Parse(char.GetNumericValue(time[2][0]).ToString())]}{Numbers[int.Parse(char.GetNumericValue(time[2][1]).ToString())]}";
            var iter3 = VigenereLogic.Encrypt(iter2, secToString);
            return new[] {iter3, string.Join("", time)};

        }
    }
}