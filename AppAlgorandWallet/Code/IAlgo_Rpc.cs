using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    public interface IAlgo_Rpc
    {
        Task<ulong> GetLatestBlockCount();
        Task<string> Broadcast(string tx);
    }
}
