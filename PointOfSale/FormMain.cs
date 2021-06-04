using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
using System.Data.SqlClient;

namespace PointOfSale
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (orderItemList.isLogin)
            {
                labelUser.Text = orderItemList.userName;
                formMenuShow();
            }
            else
            {
                labelTitle.Text = "登　入";
                formLoginShow();
            }
            //顯示時間
            timer1.Enabled = true;
        }

        //視窗拖曳
        #region FormDrag

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        bool beginMove = false;//初始化滑鼠位置
        int currentXPosition;
        int currentYPosition;

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//滑鼠的x座標為當前窗體左上角x座標
                currentYPosition = MousePosition.Y;//滑鼠的y座標為當前窗體左上角y座標
            }
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根據滑鼠x座標確定窗體的左邊座標x
                this.Top += MousePosition.Y - currentYPosition;//根據滑鼠的y座標窗體的頂部，即Y座標
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //設定初始狀態
                currentYPosition = 0;
                beginMove = false;
            }
        }
        #endregion

        //顯示時間
        #region ShowTimr
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = DateTime.Now.ToString("yyyy/MM/dd\n   HH:mm:ss");
        }
        #endregion

        //顯示其他Form
        #region FormShowInPanel
        public void formLoginShow()
        {
            labelUser.Text = orderItemList.userName;
            panelFormShow.Controls.Clear();
            FormLogin formLogin = new FormLogin();
            formLogin.TopLevel = false;
            panelFormShow.Controls.Add(formLogin);
            formLogin.Show();
        }
        public void formMenuShow()
        {
            labelUser.Text = orderItemList.userName;
            panelFormShow.Controls.Clear();
            FormMenu formMenu = new FormMenu();
            formMenu.TopLevel = false;
            panelFormShow.Controls.Add(formMenu);
            formMenu.Show();
        }
        public void formOrdersShow()
        {
            labelUser.Text = orderItemList.userName;
            panelFormShow.Controls.Clear();
            FormOrders formOrders = new FormOrders();
            formOrders.TopLevel = false;
            panelFormShow.Controls.Add(formOrders);
            formOrders.Show();
        }
        public void formSearchShow()
        {
            labelUser.Text = orderItemList.userName;
            panelFormShow.Controls.Clear();
            FormSearch formSearch = new FormSearch();
            formSearch.TopLevel = false;
            panelFormShow.Controls.Add(formSearch);
            formSearch.Show();
        }
        public void formSettingShow()
        {
            labelUser.Text = orderItemList.userName;
            panelFormShow.Controls.Clear();
            FormSetting formSetting = new FormSetting();
            formSetting.TopLevel = false;
            panelFormShow.Controls.Add(formSetting);
            formSetting.Show();
        }
        #endregion

        //左側功能按鈕
        #region buttonActionLeft
        private void buttonFoodOrder_Click(object sender, EventArgs e)
        {
            if (orderItemList.isLogin)
            {
                formMenuShow();
                labelTitle.Text = "點　餐";
            }
            else
            {
                MessageBox.Show("請登入!");
            }
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            if (orderItemList.isLogin)
            {
                formOrdersShow();
                labelTitle.Text = "訂　單";
            }
            else
            {
                MessageBox.Show("請登入!");
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (orderItemList.isLogin)
            {
                formSearchShow();
                labelTitle.Text = "訂單查詢";
            }
            else
            {
                MessageBox.Show("請登入!");
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否離開?", "exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
        //上方功能按鈕
        #region buttonActionTop

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (!orderItemList.isLogin)
            {
                MessageBox.Show("尚未登入");
            }
            else if (MessageBox.Show("是否登出?", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                labelTitle.Text = "登　入";
                orderItemList.account = "";
                orderItemList.userName = "";
                orderItemList.permissions = -1;
                labelUser.Text = "";
                orderItemList.isLogin = false;
                MessageBox.Show("已登出!");
                panelFormShow.Controls.Clear();
                formLoginShow();
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            if (!orderItemList.isLogin)
            {
                MessageBox.Show("尚未登入");
            }
            else if (orderItemList.permissions<1)
            {
                MessageBox.Show("權限不足");
            }
            else
            {
                formSettingShow();
                labelTitle.Text = "設　定";
            }
        } 
        #endregion
    }
}
