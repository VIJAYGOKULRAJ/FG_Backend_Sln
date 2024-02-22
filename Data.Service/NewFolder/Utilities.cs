using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.Service.NewFolder
{
    public static class Utilities
    {
        public static bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            string enteredPasswordHash = Encrypt(enteredPassword);
            return string.Equals(enteredPasswordHash, storedPasswordHash);
        }


        public static string Encrypt(string data)
        {
            byte[] buff;
            byte[] desKey = CreateHash("n4phc4r3");
            byte[] salt = CreateRandomSalt(7);
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(desKey, salt);
            tdes.Key = pdb.CryptDeriveKey("TripleDES", "MD5", 192, tdes.IV);
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            buff = ASCIIEncoding.ASCII.GetBytes(data);
            string encryptedResult = Convert.ToBase64String(tdes.CreateEncryptor().TransformFinalBlock(buff, 0, buff.Length));
            tdes.Clear();
            tdes = null;

            return encryptedResult;
        }

        public static byte[] CreateRandomSalt(int Length)
        {
            byte[] randBytes;

            if (Length >= 1)
            {
                randBytes = new byte[Length];
            }
            else
            {
                randBytes = new byte[1];
            }
            RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            rand.GetBytes(randBytes);

            return randBytes;
        }

        public static byte[] CreateHash(string password)
        {
            byte[] pwdhash;
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            pwdhash = hashmd5.ComputeHash(Encoding.Unicode.GetBytes(password));
            hashmd5.Clear();
            hashmd5 = null;

            return pwdhash;
        }
        public static string GenerateUniqueID(int length = 30)
        {
            var guid = Guid.NewGuid().ToString().Replace("-", "");

            var ticks = DateTime.Now.Ticks.ToString();
            var id = ticks.Substring(ticks.Length - 10) + guid;
            id = id.Substring(0, length);

            return id;
        }
    }
}
