
namespace AppAlgorandWallet
{
    partial class ValidateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailCodeField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.phoneCodeField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.addressField = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getphoneCodeField = new System.Windows.Forms.Button();
            this.getemailCodeField = new System.Windows.Forms.Button();
            this.sendField = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.validKeyField = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.emailCodeField);
            this.panel1.Controls.Add(this.phoneField);
            this.panel1.Controls.Add(this.phoneCodeField);
            this.panel1.Controls.Add(this.emailField);
            this.panel1.Controls.Add(this.addressField);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.getphoneCodeField);
            this.panel1.Controls.Add(this.getemailCodeField);
            this.panel1.Controls.Add(this.sendField);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.validKeyField);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 3;
            // 
            // emailCodeField
            // 
            this.emailCodeField.Location = new System.Drawing.Point(609, 200);
            this.emailCodeField.Name = "emailCodeField";
            this.emailCodeField.Size = new System.Drawing.Size(100, 20);
            this.emailCodeField.TabIndex = 27;
            // 
            // phoneField
            // 
            this.phoneField.Location = new System.Drawing.Point(171, 260);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(100, 20);
            this.phoneField.TabIndex = 26;
            // 
            // phoneCodeField
            // 
            this.phoneCodeField.Location = new System.Drawing.Point(609, 262);
            this.phoneCodeField.Name = "phoneCodeField";
            this.phoneCodeField.Size = new System.Drawing.Size(100, 20);
            this.phoneCodeField.TabIndex = 25;
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(171, 201);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(100, 20);
            this.emailField.TabIndex = 24;
            // 
            // addressField
            // 
            this.addressField.AutoSize = true;
            this.addressField.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressField.Location = new System.Drawing.Point(415, 25);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(73, 26);
            this.addressField.TabIndex = 23;
            this.addressField.Text = "adress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Your address";
            // 
            // getphoneCodeField
            // 
            this.getphoneCodeField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getphoneCodeField.Location = new System.Drawing.Point(304, 256);
            this.getphoneCodeField.Name = "getphoneCodeField";
            this.getphoneCodeField.Size = new System.Drawing.Size(120, 28);
            this.getphoneCodeField.TabIndex = 21;
            this.getphoneCodeField.Text = "Get phone code";
            this.getphoneCodeField.UseVisualStyleBackColor = true;
            this.getphoneCodeField.Click += new System.EventHandler(this.getphoneCodeField_Click);
            // 
            // getemailCodeField
            // 
            this.getemailCodeField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getemailCodeField.Location = new System.Drawing.Point(304, 198);
            this.getemailCodeField.Name = "getemailCodeField";
            this.getemailCodeField.Size = new System.Drawing.Size(120, 30);
            this.getemailCodeField.TabIndex = 20;
            this.getemailCodeField.Text = "Get email code";
            this.getemailCodeField.UseVisualStyleBackColor = true;
            this.getemailCodeField.Click += new System.EventHandler(this.getemailCodeField_Click);
            // 
            // sendField
            // 
            this.sendField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendField.Location = new System.Drawing.Point(304, 357);
            this.sendField.Name = "sendField";
            this.sendField.Size = new System.Drawing.Size(182, 27);
            this.sendField.TabIndex = 19;
            this.sendField.Text = "Create Transaction";
            this.sendField.UseVisualStyleBackColor = true;
            this.sendField.Click += new System.EventHandler(this.sendField_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Input phone code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(454, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Input email code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter your phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter your email";
            // 
            // validKeyField
            // 
            this.validKeyField.AutoSize = true;
            this.validKeyField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validKeyField.Location = new System.Drawing.Point(203, 84);
            this.validKeyField.Name = "validKeyField";
            this.validKeyField.Size = new System.Drawing.Size(41, 19);
            this.validKeyField.TabIndex = 10;
            this.validKeyField.Text = "false";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Upload your private key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox1.Image = global::AppAlgorandWallet.Properties.Resources._44;
            this.pictureBox1.Location = new System.Drawing.Point(51, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(1317, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            // 
            // ValidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ValidateForm";
            this.Text = "ValidateForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Button getphoneCodeField;
        private System.Windows.Forms.Button getemailCodeField;
        private System.Windows.Forms.Button sendField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label validKeyField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label addressField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox emailCodeField;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.TextBox phoneCodeField;
    }
}