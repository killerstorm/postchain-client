using Chromia.Postchain.Client.GTV.Merkle.Proof;
using Chromia.Postchain.Client.GTV.Merkle;

namespace Chromia.Postchain.Client.GTV
{
    public class Gtv
    {
        public static byte[] Hash (object obj)
        {
            return MerkleProof.MerkleHashSummary(obj, new MerkleHashCalculator(new CryptoSystem())).MerkleHash;
        }
    }    
}