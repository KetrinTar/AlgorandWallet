using Algorand;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    public class Create_Transaction
    {
        private string privKey { get; set; }
        private string destaddress { get; set; }
        private ulong amount { get; set; }

        IAlgo_Rpc algo_Rpc;

        public Create_Transaction(string privKey, string destaddress, ulong amount, IAlgo_Rpc rpc)
        {
            this.privKey = privKey;
            this.destaddress = destaddress;
            this.amount = amount;
            algo_Rpc = rpc;
        }

        public async Task<string> CreateContract()
        {
            Account account = new Account(privKey);
            var sender = account.Address;
            Address receiver = new Address(destaddress);
            
            ulong firstValidRound = await algo_Rpc.GetLatestBlockCount();

            Algorand.Transaction transaction = new Algorand.Transaction(
                sender,
                receiver, 
                Utils.AlgosToMicroalgos(0.01), 
                Utils.AlgosToMicroalgos(amount), 
                firstValidRound, firstValidRound + 100, 
                "mainnet-v1.0", 
                new Digest("wGHE2Pwdvd7S12BL5FaOP20EGYesN73ktiC1qzkkit8="
                ));           
            var signed = account.SignTransaction(transaction);
            byte[] encodedOutBytes = Algorand.Encoder.EncodeToMsgPack(signed);
            var hash = Convert.ToBase64String(encodedOutBytes);
            string hashTx = await algo_Rpc.Broadcast(hash);
            return hashTx;
        }         
    }
}
