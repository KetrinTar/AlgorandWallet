using Diploma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAlgorandWallet
{
    public partial class SendForm : Form
    {
        private string _privKey;
        private string _address;
        IAlgo_Rpc algo_Rpc;
        public SendForm(string address, string privKey)
        {
            InitializeComponent();
            _address = address;
            this.addresstextBox.Text = _address;
            _privKey = privKey;
            this.Show();
            MessageBox.Show("Your destination addres is invalid. Please, input correct ALGO address");
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            var amount = decimal.Parse(amountBox.Text);
            var normAmount = (ulong)(amount * 1000000);
            Create_Transaction transaction = new Create_Transaction(_privKey, destAddrBox.Text, normAmount, algo_Rpc);
            var hash = await transaction.CreateContract();
            this.Hide();
            TxHashForm txHash = new TxHashForm();
            txHash.textBox1.Text = hash;
            txHash.Show();
        }
    }
}
