using Diploma;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAlgorandWallet
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            emailField.Text = "Input email";
            phoneField.Text = "Input phone number";
            loginField.Text = "Input login";
            passField.Text = "Input password";
            emailField.ForeColor = Color.Gray;
            phoneField.ForeColor = Color.Black;
            loginField.ForeColor = Color.Black;
            passField.ForeColor = Color.Black;
        }
        CipherAll cipher = new CipherAll();
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.White;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Coral;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
       
        private void emailField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == "Input email")
            {
                emailField.Text = "";
                emailField.ForeColor = Color.Black;
            }                           
        }

        private void emailField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text == "") 
            {
                emailField.Text = "Input email";
                emailField.ForeColor = Color.Gray;
            }
                
        }
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == "Input login")
            {
                emailField.Text = "";
                emailField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text == "")
            {
                emailField.Text = "Input login";
                emailField.ForeColor = Color.Black;
            }
        }

        private void phoneField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == "Input phone number")
            {
                emailField.Text = "";
                emailField.ForeColor = Color.Black;
            }
        }

        private void phoneField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text == "")
            {
                emailField.Text = "Input phone number";
                emailField.ForeColor = Color.Black;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == "Input password")
            {
                emailField.Text = "";
                emailField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text == "")
            {
                emailField.Text = "Input password";
                emailField.ForeColor = Color.Black;
            }
        }

        private void buttonRedister_Click(object sender, EventArgs e)
        {
            
            if (emailField.Text == "Input email")
            {
                MessageBox.Show("Input email");
                return;
            }
            if (phoneField.Text == "Input phone number")
            {
                MessageBox.Show("Input phone number");
                return;
            }
            if (loginField.Text == "Input login")
            {
                MessageBox.Show("Input login");
                return;
            }
            if (passField.Text == "Input password")
            {
                MessageBox.Show("Input password");
                return;
            }

            if (isUserExists())
                return;
            var address = SaveKey(loginField.Text);
            if (address == null)
            {
                return;
            }
            DB dB = new DB();
            dB.OpenConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user` (`login`, `pass`, `email`, `phone`, `address`) VALUES (@login, @password, @email, @phone, @address)", dB.GetConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = cipher.EncryptSha3(emailField.Text);
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = cipher.EncryptSha3(phoneField.Text);
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = cipher.EncryptSha3(passField.Text);
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value =  address;

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();                
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Not ok");
            }

            dB.CloseConnection();

        }

        public bool isUserExists()
        {
            DB dB = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            dB.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `login` LIKE @uL", dB.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = cipher.EncryptSha3(loginField.Text);

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dB.CloseConnection();
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Login is busy");
                return true;
            }
            else
            {
                return false;
            }            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }        

        public string SaveKey(string login)
        {
            GenerateKeys key = new GenerateKeys();

            var privatekey = key.GeneratePrivateKeys();
            var address = key.GenerateAddress(privatekey);
            CipherAll cipher = new CipherAll(login, privatekey, true);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "(*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFile.FileName, false, System.Text.Encoding.GetEncoding("utf-8"));
                var encryptedKey = cipher.encryptedKey;
                writer.Write(encryptedKey);
                writer.Close();
            }
            return address;
        }

        
    }
}
