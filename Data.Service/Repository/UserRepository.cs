using Data.Service.IRepository;
using Data.SQL;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Data.Service.Repository
{
    public class UserRepository : IUserRepository
    {
        public  DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> CheckLoginCredentials(UserLoginView userLoginView)
        {
           
            
            var user = await _context.User
                .FirstOrDefaultAsync(u => u.Username == userLoginView.Username && u.Password == userLoginView.Password);

            return user;
        }
        public User GetUserByEmail(string email)
        {
            return _context.User.FirstOrDefault(u => u.Username == email);
        }

        public bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            string enteredPasswordHash = Encrypt(enteredPassword);
            return string.Equals(enteredPasswordHash, storedPasswordHash);
        }

       
        private string Encrypt(string data)
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

        private static byte[] CreateRandomSalt(int Length)
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

        private static byte[] CreateHash(string password)
        {
            byte[] pwdhash;
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            pwdhash = hashmd5.ComputeHash(Encoding.Unicode.GetBytes(password));
            hashmd5.Clear();
            hashmd5 = null;

            return pwdhash;
        }

    }
}
