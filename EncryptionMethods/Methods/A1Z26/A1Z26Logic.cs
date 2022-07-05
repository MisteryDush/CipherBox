using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptionMethods.Methods.A1Z26
{
    public static class A1Z26Logic
    {
        private enum Alphabet
        {
            a = 1,
            b,
            c,
            d,
            e,
            f,
            g,
            h,
            i,
            j,
            k,
            l,
            m,
            n,
            o,
            p,
            q,
            r,
            s,
            t,
            u,
            v,
            w,
            x,
            y,
            z
        }
        public static string Encrypt(string input, bool mode)
        {
            if (string.IsNullOrEmpty(input)) return "";
            var sb = new StringBuilder();
            if (mode)
            {
                foreach (var ch in input)
                {
                    if (!char.IsLetter(ch)) continue; 
                    var digit = (int)Enum.Parse(typeof(Alphabet), Convert.ToString(ch).ToLower());
                    sb.Append(digit + " ");
                }
            }
            else
            {
                var arr = input.TrimEnd(' ').Split(' ').Select(int.Parse);
                try
                {
                    foreach (var s in arr)
                    {
                        var letter = (Alphabet) s;
                        sb.Append(letter);
                    }
                }
                catch (FormatException e)
                {
                    MessageBox.Show("Please, enter only digits to decrypt!");
                    return "";
                }
            }

            return sb.ToString();
        }
    }
}