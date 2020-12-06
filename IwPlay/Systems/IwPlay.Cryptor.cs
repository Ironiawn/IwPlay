using System.Security.Cryptography;
using System.IO;
using System.Text;
using System;
using System.Linq;

namespace IwPlay.Systems
{
    public static class Hashing
    {
        static string EncryptString(string plainText)
        {
            byte[] textoAsBytes = Encoding.ASCII.GetBytes(plainText);
            string resultado = System.Convert.ToBase64String(textoAsBytes);
            return resultado;
        }

        static string DecryptString(string cipherText)
        {
            byte[] dadosAsBytes = System.Convert.FromBase64String(cipherText);
            string resultado = System.Text.ASCIIEncoding.ASCII.GetString(dadosAsBytes);
            return resultado;
        }

        public static string Encrypt(string text)
        {
            return EncryptString(text);
        }

        public static string Decrypt(string text)
        {
            return DecryptString(text);
        }
    }
}
