
namespace PointOfSale
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelFillForm = new System.Windows.Forms.Panel();
            this.panelFormShow = new System.Windows.Forms.Panel();
            this.panelB4 = new System.Windows.Forms.Panel();
            this.panelB3 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelB1 = new System.Windows.Forms.Panel();
            this.panelB2 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelUser = new System.Windows.Forms.Label();
            this.panelFillForm.SuspendLayout();
            this.panelFormShow.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFillForm
            // 
            this.panelFillForm.Controls.Add(this.panelFormShow);
            this.panelFillForm.Controls.Add(this.labelTitle);
            this.panelFillForm.Controls.Add(this.panelOptions);
            this.panelFillForm.Controls.Add(this.panelTitleBar);
            this.panelFillForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFillForm.Location = new System.Drawing.Point(0, 0);
            this.panelFillForm.Name = "panelFillForm";
            this.panelFillForm.Size = new System.Drawing.Size(1180, 733);
            this.panelFillForm.TabIndex = 0;
            // 
            // panelFormShow
            // 
            this.panelFormShow.Controls.Add(this.panelB4);
            this.panelFormShow.Controls.Add(this.panelB3);
            this.panelFormShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormShow.Location = new System.Drawing.Point(145, 160);
            this.panelFormShow.Name = "panelFormShow";
            this.panelFormShow.Size = new System.Drawing.Size(1035, 573);
            this.panelFormShow.TabIndex = 4;
            // 
            // panelB4
            // 
            this.panelB4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panelB4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelB4.Location = new System.Drawing.Point(1, 0);
            this.panelB4.Name = "panelB4";
            this.panelB4.Size = new System.Drawing.Size(1034, 1);
            this.panelB4.TabIndex = 3;
            // 
            // panelB3
            // 
            this.panelB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panelB3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelB3.Location = new System.Drawing.Point(0, 0);
            this.panelB3.Name = "panelB3";
            this.panelB3.Size = new System.Drawing.Size(1, 573);
            this.panelB3.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(145, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1035, 120);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "點　餐";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.buttonSearch);
            this.panelOptions.Controls.Add(this.buttonExit);
            this.panelOptions.Controls.Add(this.buttonOrders);
            this.panelOptions.Controls.Add(this.buttonMenu);
            this.panelOptions.Controls.Add(this.panel2);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOptions.Location = new System.Drawing.Point(0, 40);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(145, 693);
            this.panelOptions.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Image = global::PointOfSale.Properties.Resources.search32px2;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch.Location = new System.Drawing.Point(0, 405);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(145, 144);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "查詢";
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = global::PointOfSale.Properties.Resources.exit32px;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.Location = new System.Drawing.Point(0, 549);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(145, 144);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "離開";
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Image = global::PointOfSale.Properties.Resources.form32px;
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOrders.Location = new System.Drawing.Point(0, 262);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(145, 143);
            this.buttonOrders.TabIndex = 2;
            this.buttonOrders.Text = "訂單";
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Image = global::PointOfSale.Properties.Resources.order32px;
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMenu.Location = new System.Drawing.Point(0, 120);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(145, 142);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "點餐";
            this.buttonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonFoodOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.panelB1);
            this.panel2.Controls.Add(this.panelB2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 120);
            this.panel2.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(144, 119);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelB1
            // 
            this.panelB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panelB1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelB1.Location = new System.Drawing.Point(0, 119);
            this.panelB1.Name = "panelB1";
            this.panelB1.Size = new System.Drawing.Size(144, 1);
            this.panelB1.TabIndex = 0;
            // 
            // panelB2
            // 
            this.panelB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panelB2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelB2.Location = new System.Drawing.Point(144, 0);
            this.panelB2.Name = "panelB2";
            this.panelB2.Size = new System.Drawing.Size(1, 120);
            this.panelB2.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.panelTitleBar.Controls.Add(this.labelUser);
            this.panelTitleBar.Controls.Add(this.buttonSetting);
            this.panelTitleBar.Controls.Add(this.buttonLogout);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1180, 40);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            this.panelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseUp);
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.buttonSetting.Image = global::PointOfSale.Properties.Resources.settings24px;
            this.buttonSetting.Location = new System.Drawing.Point(1080, 0);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(50, 40);
            this.buttonSetting.TabIndex = 7;
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.buttonLogout.Image = global::PointOfSale.Properties.Resources.logout21px_man_;
            this.buttonLogout.Location = new System.Drawing.Point(1130, 0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(50, 40);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelUser
            // 
            this.labelUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.labelUser.Location = new System.Drawing.Point(735, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(345, 40);
            this.labelUser.TabIndex = 8;
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1180, 733);
            this.Controls.Add(this.panelFillForm);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PA";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelFillForm.ResumeLayout(false);
            this.panelFormShow.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFillForm;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFormShow;
        private System.Windows.Forms.Panel panelB4;
        private System.Windows.Forms.Panel panelB3;
        private System.Windows.Forms.Panel panelB1;
        private System.Windows.Forms.Panel panelB2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Label labelUser;
    }
}

