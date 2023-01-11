using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Diploma
{
    public class CipherAll
    {
        public string _privatekey { get; set; }
        public bool _encrypt;
        public string encryptedKey { get; }
        public string decryptedKey { get; }
        public string _text;
        public CipherAll(string privatekey, string text, bool encrypt)
        {
            _privatekey = privatekey;
            _text = text;
            _encrypt = encrypt;
            encryptedKey = encrypt ? Encrypt() : Decrypt();
        }

        public CipherAll()
        {
        }

        private string Encrypt()
        {
            CspParameters CSApars = new CspParameters();
            CSApars.KeyContainerName = _privatekey;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(CSApars);

            byte[] byteText = Encoding.UTF8.GetBytes(_text);
            byte[] byteEntry = rsa.Encrypt(byteText, false);

            return Convert.ToBase64String(byteEntry);
        }


        private string Decrypt()
        {
            CspParameters CSApars = new CspParameters();
            CSApars.KeyContainerName = _privatekey;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(CSApars);

            byte[] byteEntry = Convert.FromBase64String(_text);
            byte[] byteText = rsa.Decrypt(byteEntry, false);

            return Encoding.UTF8.GetString(byteText);
        }

        public string EncryptSha3(string data)
        {
            var sha3 = SHA256.Create();
            var encodedData = sha3.ComputeHash(Encoding.UTF8.GetBytes(data));
            return Encoding.UTF8.GetString(encodedData);
        }

    }
}
