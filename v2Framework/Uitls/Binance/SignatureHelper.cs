using System;
using System.Security.Cryptography;
using System.Text;

namespace v2Framework.Uitls.Binance
{
    class SignatureHelper
    {
        public static string Sign(string source, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            using (HMACSHA256 hmacsha256 = new HMACSHA256(keyBytes))
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);

                byte[] hash = hmacsha256.ComputeHash(sourceBytes);

                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}
