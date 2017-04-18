using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NCommons.Codec.Digest
{
    public class DigestUtils
    {
        public static String Md5Hex(byte[] bytes)
        {
            MD5 md5 = MD5.Create();
            byte[] HashBytes = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in HashBytes)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
        
        /// <summary>
        /// Generate MD5 hash in hexdecimal format
        /// </summary>
        /// <param name="data"></param>
        /// <param name="encoding">The encoding used to convert data to bytes, if not specified it will be UTF8</param>
        /// <returns>generated MD5 hash hex string</returns>
        public static String Md5Hex(string data, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }

            return Md5Hex(encoding.GetBytes(data));
        }
    }
}
