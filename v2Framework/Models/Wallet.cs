using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2Framework.Models
{
    public class Wallet
    {
        public string name { get; set; }
        public List<string> mnemonic_sentence { get; set; }
        public string passphrase { get; set; }
        public int address_pool_gap { get; set; }

        public Wallet(string name, List<string> mnemonic_sentence, string passphrase)
        {
            this.name = name;
            this.mnemonic_sentence = mnemonic_sentence;
            this.passphrase = passphrase;
            this.address_pool_gap = 20;
        }
        public Wallet()
        {
        }
    }

    public class ListWallet
    {
        public List<WalletItem> walletlist { get; set; }
    }


    public class WalletItem
    {
        public string id { get; set; }
        public int address_pool_gap { get; set; }
        public string name { get; set; }
        public Balance balance { get; set; }
        public State state { get; set; }

        public WalletItem()
        {
        }
    }

    public class State
    {
        public string status { get; set; }
    }

    public class Balance{
        public BalanceItem available { get; set; }
        public BalanceItem reward { get; set; }
        public BalanceItem total { get; set; }
    }

    public class BalanceItem
    {
        public double quantity { get; set; }
        public string unit { get; set; }
    }

}
