using System;
using System.Security.Cryptography;
using System.Text;

namespace SendCloudApi.Net.Helpers
{
    public static class HashHelper
    {
        public enum HashType
        {
            HmacSha256,
            HmacSha512
        }

        public static string GetHash(HashType hashType, string s, string key)
        {
            return GetHash(hashType, s, Encoding.UTF8.GetBytes(key));
        }

        public static string GetHash(HashType hashType, string s, byte[] key)
        {
            string str;
            switch (hashType)
            {
                case HashType.HmacSha256:
                    str = GetHmacSha256(s, key);
                    break;
                case HashType.HmacSha512:
                    str = GetHmacSha512(s, key);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return str;
        }

        private static string GetHmacSha256(string s, byte[] key)
        {
            byte[] hash;
            using (var hma = new HMACSHA256(key))
            {
                hash = hma.ComputeHash(Encoding.UTF8.GetBytes(s));
            }
            return ByteToString(hash);
        }

        private static string GetHmacSha512(string s, byte[] key)
        {
            byte[] hash;
            using (var hma = new HMACSHA512(key))
            {
                hash = hma.ComputeHash(Encoding.UTF8.GetBytes(s));
            }
            return ByteToString(hash);
        }

        private static string ByteToString(byte[] hashValue)
        {
            string str = "";
            foreach (byte b in hashValue)
            {
                str += string.Format("{0:x2}", b);
            }
            return str;
        }
    }
}
