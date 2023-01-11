using Diploma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAlgorandWallet
{
    public partial class ValidateForm : Form
    {
        public string login;
        public string address;
        private int emailCode;
        private int phoneCode;
        private string pr_key;
        public ValidateForm()
        {
            InitializeComponent();
            addressField.Text = address;
            validKeyField.Text = "true";
        }
        Random random = new Random();
        SMS_and_Email_Api sMS_And_Email_ = new SMS_and_Email_Api();
        private void button1_Click(object sender, EventArgs e)
        {
            var valid = GetKey(login);
            if (valid == address)
            {
                validKeyField.Text = "true";
            }
            else
            {
                validKeyField.Text = "true";
            }
        }
        public string GetKey(string login)
        {
            string decr = "";
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader writer = new StreamReader(openFile.FileName, System.Text.Encoding.GetEncoding("utf-8"));
                var pubKey = writer.ReadToEnd();
                CipherAll cipher = new CipherAll(login, pubKey, false);
                var encryptedKey = cipher.encryptedKey;
                decr = encryptedKey;
            }
            GenerateKeys generateKeys = new GenerateKeys();
            var validaddress = generateKeys.GenerateAddress(decr);
            pr_key = decr;
            return validaddress;
        }

        private void getemailCodeField_Click(object sender, EventArgs e)
        {
            var code = random.Next(0, 10000000);
            sMS_And_Email_.SendEmailAsync(emailField.Text, code);
            emailCode = code;
        }

        private async void getphoneCodeField_Click(object sender, EventArgs e)
        {
            var code = random.Next(0, 10000000);
            var id = await sMS_And_Email_.SMSSend(phoneField.Text, code);
            phoneCode = code;
        }

        private void sendField_Click(object sender, EventArgs e)
        {
            var em = emailCode.ToString();
            var ph = phoneCode.ToString();
            if (emailCodeField.Text == em && phoneCodeField.Text == ph && validKeyField.Text == "true")
            {
                this.Hide();
                SendForm sendForm = new SendForm(address, pr_key);
                sendForm.Show();
            }
            else
            {
                MessageBox.Show("Input data is invalid. Please? input coorect code or upload correct private key");
            }
        }
    }
}
