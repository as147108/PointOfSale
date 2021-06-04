
namespace PointOfSale
{
    partial class FormLogin
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
            this.panelPassWord = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPassWord.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPassWord
            // 
            this.panelPassWord.Controls.Add(this.btnLogin);
            this.panelPassWord.Controls.Add(this.panel3);
            this.panelPassWord.Controls.Add(this.panel);
            this.panelPassWord.Location = new System.Drawing.Point(292, 107);
            this.panelPassWord.Name = "panelPassWord";
            this.panelPassWord.Size = new System.Drawing.Size(458, 281);
            this.panelPassWord.TabIndex = 11;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Thistle;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Gray;
            this.btnLogin.Location = new System.Drawing.Point(58, 192);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(326, 44);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxAccount);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(58, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 45);
            this.panel3.TabIndex = 10;
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.textBoxAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxAccount.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.textBoxAccount.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxAccount.Location = new System.Drawing.Point(64, 0);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(262, 40);
            this.textBoxAccount.TabIndex = 7;
            this.textBoxAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAccount_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 1);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 1);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PointOfSale.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(13, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 42);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.textBoxPassWord);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(58, 111);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(326, 45);
            this.panel.TabIndex = 7;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.textBoxPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassWord.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxPassWord.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.textBoxPassWord.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPassWord.Location = new System.Drawing.Point(64, 0);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '*';
            this.textBoxPassWord.Size = new System.Drawing.Size(262, 40);
            this.textBoxPassWord.TabIndex = 7;
            this.textBoxPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassWord_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 1);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.padlock32px;
            this.pictureBox1.Location = new System.Drawing.Point(13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 39);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1019, 534);
            this.Controls.Add(this.panelPassWord);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.panelPassWord.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPassWord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}