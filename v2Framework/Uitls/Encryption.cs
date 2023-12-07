using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace v2Framework.Uitls
{
    public static class Encryption
    {
        private static string CONSTKEY = "abhf@311";
        private static int[] charmap = new int[256]
        {
      61,
      101,
      133,
      179,
      24,
      219,
      226,
      135,
      241,
      82,
      171,
      99,
      75,
      181,
      160,
      95,
      125,
      104,
      123,
      155,
      36,
      194,
      40,
      103,
      138,
      222,
      164,
      38,
      30,
      3,
      235,
      23,
      111,
      52,
      62,
      122,
      63,
      210,
      169,
      106,
      15,
      233,
      53,
      86,
      31,
      177,
      77,
      16,
      120,
      217,
      117,
      246,
      188,
      65,
      4,
      129,
      97,
      6,
      249,
      173,
      214,
      213,
      41,
      126,
      134,
      158,
      121,
      229,
      5,
      186,
      132,
      204,
      110,
      39,
      142,
      176,
      93,
      168,
      243,
      159,
      208,
      162,
      113,
      184,
      88,
      221,
      44,
      56,
      153,
      76,
      72,
      7,
      85,
      228,
      83,
      140,
      70,
      182,
      45,
      165,
      175,
      50,
      34,
      64,
      220,
      80,
      195,
      161,
      37,
      139,
      156,
      22,
      96,
      92,
      207,
      253,
      12,
      152,
      28,
      212,
      55,
      109,
      60,
      58,
      48,
      232,
      108,
      49,
      71,
      245,
      51,
      218,
      67,
      200,
      227,
      94,
      25,
      148,
      236,
      230,
      163,
      149,
      20,
      224,
      157,
      100,
      250,
      89,
      21,
      197,
      47,
      202,
      187,
      11,
      223,
      242,
      151,
      191,
      10,
      118,
      180,
      73,
      68,
      90,
      29,
      240,
      0,
      150,
      33,
      128,
      (int) sbyte.MaxValue,
      26,
      130,
      57,
      79,
      193,
      167,
      215,
      13,
      209,
      216,
      (int) byte.MaxValue,
      19,
      147,
      112,
      238,
      91,
      239,
      190,
      9,
      185,
      119,
      114,
      231,
      178,
      84,
      183,
      42,
      199,
      115,
      144,
      102,
      32,
      14,
      81,
      237,
      248,
      124,
      143,
      46,
      244,
      18,
      198,
      43,
      131,
      205,
      172,
      203,
      59,
      196,
      78,
      192,
      105,
      54,
      98,
      2,
      174,
      136,
      252,
      170,
      66,
      8,
      166,
      69,
      87,
      211,
      154,
      189,
      225,
      35,
      141,
      146,
      74,
      17,
      137,
      116,
      107,
      145,
      251,
      254,
      201,
      1,
      234,
      27,
      247,
      206
        };

        public static string UnWarpCode(string warptext)
        {
            try
            {
                string str = "";
                string input = warptext.Replace("\r\n", "\n");
                System.Text.RegularExpressions.Match match = new Regex("\n([0-9a-f]+[ ])([0-9a-f]+[\n])", RegexOptions.IgnoreCase).Match(input);
                int uint16 = (int)Convert.ToUInt16(match.Groups[2].Value.Trim(), 16);
                int startIndex = match.Index + match.Length;
                int length = input.Length - startIndex;
                if (startIndex + length <= input.Length)
                    str = input.Substring(startIndex, length);
                byte[] numArray1 = Convert.FromBase64String(str.Replace("\n", ""));
                byte[] numArray2 = new byte[numArray1.Length];
                for (int index1 = 0; index1 < numArray1.Length; ++index1)
                {
                    int index2 = (int)numArray1[index1] & (int)byte.MaxValue;
                    numArray2[index1] = Convert.ToByte(Encryption.charmap[index2]);
                }
                byte[] numArray3 = new byte[20];
                byte[] data = new byte[numArray2.Length - 20];
                Array.Copy((Array)numArray2, 0, (Array)numArray3, 0, 20);
                Array.Copy((Array)numArray2, 20, (Array)data, 0, numArray2.Length - 20);
                return Encoding.UTF8.GetString(Encryption.Decompress(data)).Replace("\n", "\r\n");
            }
            catch
            {
                return "Can't unwrap code. Please check code again!";
            }
        }

        public static byte[] Compress(byte[] data)
        {
            MemoryStream memoryStream = new MemoryStream();
            using (DeflateStream deflateStream = new DeflateStream((Stream)memoryStream, CompressionLevel.Optimal))
                deflateStream.Write(data, 0, data.Length);
            return memoryStream.ToArray();
        }

        public static byte[] Decompress(byte[] data)
        {
            MemoryStream memoryStream1 = new MemoryStream(data);
            MemoryStream memoryStream2 = new MemoryStream();
            memoryStream1.Position = 2L;
            using (DeflateStream deflateStream = new DeflateStream((Stream)memoryStream1, CompressionMode.Decompress))
                deflateStream.CopyTo((Stream)memoryStream2);
            return memoryStream2.ToArray();
        }

        public static string AESEncrypt(string textToEncrypt)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Mode = CipherMode.CBC;
            rijndaelManaged.Padding = PaddingMode.PKCS7;
            rijndaelManaged.KeySize = 128;
            rijndaelManaged.BlockSize = 128;
            byte[] bytes1 = Encoding.UTF8.GetBytes(Encryption.CONSTKEY);
            byte[] numArray = new byte[16];
            int length = bytes1.Length;
            if (length > numArray.Length)
                length = numArray.Length;
            Array.Copy((Array)bytes1, (Array)numArray, length);
            rijndaelManaged.Key = numArray;
            rijndaelManaged.IV = numArray;
            ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor();
            byte[] bytes2 = Encoding.UTF8.GetBytes(textToEncrypt);
            return Convert.ToBase64String(encryptor.TransformFinalBlock(bytes2, 0, bytes2.Length));
        }

        public static string AESDecrypt(string textToDecrypt)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Mode = CipherMode.CBC;
            rijndaelManaged.Padding = PaddingMode.PKCS7;
            rijndaelManaged.KeySize = 128;
            rijndaelManaged.BlockSize = 128;
            byte[] inputBuffer = Convert.FromBase64String(textToDecrypt);
            byte[] bytes = Encoding.UTF8.GetBytes(Encryption.CONSTKEY);
            byte[] numArray = new byte[16];
            int length = bytes.Length;
            if (length > numArray.Length)
                length = numArray.Length;
            Array.Copy((Array)bytes, (Array)numArray, length);
            rijndaelManaged.Key = numArray;
            rijndaelManaged.IV = numArray;
            return Encoding.UTF8.GetString(rijndaelManaged.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
        }

        public static string MD5Encrypt(string text) => Convert.ToBase64String(new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(text)));

        public static string SHA256Encrypt(string text)
        {
            SHA256Managed shA256Managed = new SHA256Managed();
            string str = "";
            foreach (byte num in shA256Managed.ComputeHash(Encoding.UTF8.GetBytes(text), 0, Encoding.UTF8.GetByteCount(text)))
                str += num.ToString("x2");
            return str;
        }
    }

}
