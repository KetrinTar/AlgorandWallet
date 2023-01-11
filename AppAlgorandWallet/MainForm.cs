using Diploma;
using MySql.Data.MySqlClient;
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
    public partial class MainForm : Form
    {
        public string login;
        public MainForm()
        {
            InitializeComponent();

        }
       
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public async Task<string> GetBalance(string address)
        {
            Algo_Rpc algo = new Algo_Rpc();
            var balance = await algo.GetAddressBalanceAsync(address);
            var intBal = balance / 1000000;
            return intBal.ToString() + " ALGO";
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            ValidateForm validateForm = new ValidateForm();
            validateForm.address = AddressTextBox.Text;
            validateForm.login = login;
            this.Hide();
            validateForm.Show();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            balanceLabel.Text = await GetBalance(AddressTextBox.Text);
        }
    }
}
