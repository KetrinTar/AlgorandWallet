using Algorand;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Diploma
{
    public class GenerateKeys
    {
        public string GeneratePrivateKeys()
        {
            byte[] privateKey = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(privateKey);
            }
            return Hex.ToHexString(privateKey);
            
        }
        public string GenerateAddress(string privKey)
        {
            Account account = new Algorand.Account(Hex.Decode(privKey));
            return account.Address.ToString();
        }

    }
}
