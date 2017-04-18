using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCommons.Codec.Binary
{
    public class Hex
    {
        public static String EncodeHex(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
