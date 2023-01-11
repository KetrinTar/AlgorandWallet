using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    public class Algo_Rpc : IAlgo_Rpc
    {
        private string _rooturl = "http://192.168.80.131:8195";
        private HttpClient _httpClient;

        public Algo_Rpc()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer 99c59ab70e6b7d7cda1e1492ada369f46b4fa16a4d2ab429f2850915fc5d6b71");
        }

        public async Task<ulong> GetLatestBlockCount()
        {
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer 99c59ab70e6b7d7cda1e1492ada369f46b4fa16a4d2ab429f2850915fc5d6b71");
            var block = await _httpClient.GetAsync($"{_rooturl}/v1/status");
            var response = await block.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ResponseStatus>(response);
            return result.lastRound;
        }
        public async Task<string> Broadcast(string tx)
        {
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer 99c59ab70e6b7d7cda1e1492ada369f46b4fa16a4d2ab429f2850915fc5d6b71");
            var tw = Convert.FromBase64String(tx);
            ByteArrayContent byteArrayContent = new ByteArrayContent(tw);
            var tx1 = await _httpClient.PostAsync($"{_rooturl}/v1/transactions", byteArrayContent);
            var response = await tx1.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BroadcastResponse>(response);
            return result.txId;
        }
        public async Task<decimal> GetAddressBalanceAsync(string address)
        {           
            var balance = await _httpClient.GetAsync($"{_rooturl}/v1/account/{address}");
            var response = await balance.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AlgoBalanceResponse>(response);
            return result.amountwithoutpendingrewards;
        }
        public class ResponseStatus
        {
            public ulong lastRound { get; set; }
            public string lastConsensusVersion { get; set; }
            public string nextConsensusVersion { get; set; }
            public int nextConsensusVersionRound { get; set; }
            public bool nextConsensusVersionSupported { get; set; }
            public long timeSinceLastRound { get; set; }
            public int catchupTime { get; set; }
            public bool hasSyncedSinceStartup { get; set; }
            public bool stoppedAtUnsupportedRound { get; set; }
        }
        public class BroadcastResponse
        {
            public string txId { get; set; }
        }
        public class AlgoBalanceResponse
        {
            public long amountwithoutpendingrewards { get; set; }
        }
    }
}
