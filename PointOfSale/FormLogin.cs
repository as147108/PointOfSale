using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class FormLogin : Form
    {
        posDbCRUD posDbCRUD = new posDbCRUD();
        FormMain formMain = new FormMain();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void textBoxAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
                btnLogin_Click(sender, e);
                btnLogin.Focus();
            }
        }
        private void textBoxPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
                btnLogin_Click(sender, e);
                btnLogin.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt;
            
            if (textBoxAccount.Text.Length==0||textBoxPassWord.Text.Length==0)
            {
                MessageBox.Show("請輸入帳號密碼");
            }
            else if (isSPChar(textBoxAccount.Text)||isSPChar(textBoxPassWord.Text))
            {
                MessageBox.Show("請勿輸入特殊字元");
            }
            else
            {
                dt = posDbCRUD.getQueryTable($"select * from users where users_account = '{textBoxAccount.Text}'");
                if (dt.Rows.Count!=0)
                {
                    if (textBoxPassWord.Text == dt.Rows[0]["users_password"].ToString())
                    {
                        orderItemList.account = dt.Rows[0]["users_account"].ToString();
                        orderItemList.userName = dt.Rows[0]["users_name"].ToString();
                        orderItemList.permissions =Convert.ToInt32(dt.Rows[0]["uses_permissions"]);
                        MessageBox.Show("登入成功");
                        orderItemList.isLogin = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("帳號或密碼錯誤");
                        textBoxPassWord.Text = "";
                        textBoxPassWord.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤");
                    textBoxPassWord.Text = "";
                    textBoxPassWord.Focus();
                }
            }         
        }
        private Boolean isSPChar(string str)
        {
            bool isSP = false;
            List<Boolean> lstIsSPChar = new List<Boolean>();
            lstIsSPChar.Add(str.Contains('@'));
            lstIsSPChar.Add(str.Contains('$'));
            lstIsSPChar.Add(str.Contains('('));
            lstIsSPChar.Add(str.Contains(')'));
            lstIsSPChar.Add(str.Contains('+'));
            lstIsSPChar.Add(str.Contains('-'));
            lstIsSPChar.Add(str.Contains('*'));
            lstIsSPChar.Add(str.Contains('/'));
            lstIsSPChar.Add(str.Contains('='));
            lstIsSPChar.Add(str.Contains('|'));
            lstIsSPChar.Add(str.Contains('~'));
            lstIsSPChar.Add(str.Contains('`'));
            lstIsSPChar.Add(str.Contains('!'));
            lstIsSPChar.Add(str.Contains('%'));
            lstIsSPChar.Add(str.Contains('^'));
            lstIsSPChar.Add(str.Contains('&'));
            lstIsSPChar.Add(str.Contains('_'));
            lstIsSPChar.Add(str.Contains('='));
            lstIsSPChar.Add(str.Contains('{'));
            lstIsSPChar.Add(str.Contains('}'));
            lstIsSPChar.Add(str.Contains('['));
            lstIsSPChar.Add(str.Contains(']'));
            lstIsSPChar.Add(str.Contains('<'));
            lstIsSPChar.Add(str.Contains('>'));
            lstIsSPChar.Add(str.Contains(' '));
            lstIsSPChar.Add(str.Contains('.'));
            lstIsSPChar.Add(str.Contains('\''));
            lstIsSPChar.Add(str.Contains('\"'));
            lstIsSPChar.Add(str.Contains('\\'));
            foreach (var item in lstIsSPChar)
            {
                if (item)
                {
                    isSP = true;
                }
            }
            return isSP;
        }
    }
}
