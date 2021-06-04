
namespace PointOfSale
{
    partial class FormMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelInMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelOrderItemList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCustomize2 = new System.Windows.Forms.Label();
            this.lblCustomize = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnToList = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.flowLayoutPanelCustomize = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelFood = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelType = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu.SuspendLayout();
            this.panelInMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelInMenu);
            this.panelMenu.Controls.Add(this.flowLayoutPanelCustomize);
            this.panelMenu.Controls.Add(this.flowLayoutPanelFood);
            this.panelMenu.Controls.Add(this.flowLayoutPanelType);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1035, 573);
            this.panelMenu.TabIndex = 0;
            // 
            // panelInMenu
            // 
            this.panelInMenu.BackColor = System.Drawing.Color.Yellow;
            this.panelInMenu.Controls.Add(this.panel2);
            this.panelInMenu.Controls.Add(this.flowLayoutPanelOrderItemList);
            this.panelInMenu.Controls.Add(this.panel1);
            this.panelInMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInMenu.Location = new System.Drawing.Point(750, 0);
            this.panelInMenu.Name = "panelInMenu";
            this.panelInMenu.Size = new System.Drawing.Size(285, 573);
            this.panelInMenu.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSendOrder);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.textBoxCustomerName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 152);
            this.panel2.TabIndex = 3;
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.btnSendOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOrder.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSendOrder.Location = new System.Drawing.Point(0, 94);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(285, 58);
            this.btnSendOrder.TabIndex = 3;
            this.btnSendOrder.Text = "送出";
            this.btnSendOrder.UseVisualStyleBackColor = false;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.panel6.Controls.Add(this.lblTotal);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 51);
            this.panel6.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.lblTotal.Location = new System.Drawing.Point(90, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(195, 51);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "總計：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCustomerName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.textBoxCustomerName.Location = new System.Drawing.Point(0, 0);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(285, 43);
            this.textBoxCustomerName.TabIndex = 0;
            this.textBoxCustomerName.Text = "顧客名稱";
            this.textBoxCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCustomerName.Click += new System.EventHandler(this.textBoxCustomerName_Click);
            this.textBoxCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCustomerName_KeyDown);
            this.textBoxCustomerName.Leave += new System.EventHandler(this.textBoxCustomerName_Leave);
            // 
            // flowLayoutPanelOrderItemList
            // 
            this.flowLayoutPanelOrderItemList.AutoScroll = true;
            this.flowLayoutPanelOrderItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.flowLayoutPanelOrderItemList.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelOrderItemList.Location = new System.Drawing.Point(0, 181);
            this.flowLayoutPanelOrderItemList.Name = "flowLayoutPanelOrderItemList";
            this.flowLayoutPanelOrderItemList.Size = new System.Drawing.Size(285, 240);
            this.flowLayoutPanelOrderItemList.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnToList);
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 181);
            this.panel1.TabIndex = 0;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.lblSubTotal.Location = new System.Drawing.Point(90, 92);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(195, 44);
            this.lblSubTotal.TabIndex = 7;
            this.lblSubTotal.Text = "Total";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.label3.Location = new System.Drawing.Point(0, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "小計:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 1);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.lblCustomize2);
            this.panel4.Controls.Add(this.lblCustomize);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 45);
            this.panel4.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(138, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 45);
            this.panel7.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblCustomize2
            // 
            this.lblCustomize2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCustomize2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCustomize2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.lblCustomize2.Location = new System.Drawing.Point(139, 0);
            this.lblCustomize2.Name = "lblCustomize2";
            this.lblCustomize2.Size = new System.Drawing.Size(146, 45);
            this.lblCustomize2.TabIndex = 2;
            this.lblCustomize2.Text = "CUS2";
            this.lblCustomize2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomize
            // 
            this.lblCustomize.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCustomize.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCustomize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.lblCustomize.Location = new System.Drawing.Point(0, 0);
            this.lblCustomize.Name = "lblCustomize";
            this.lblCustomize.Size = new System.Drawing.Size(143, 45);
            this.lblCustomize.TabIndex = 1;
            this.lblCustomize.Text = "CUS";
            this.lblCustomize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 1);
            this.panel3.TabIndex = 3;
            // 
            // btnToList
            // 
            this.btnToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.btnToList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnToList.Enabled = false;
            this.btnToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnToList.Image = global::PointOfSale.Properties.Resources.down32px;
            this.btnToList.Location = new System.Drawing.Point(0, 136);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(285, 45);
            this.btnToList.TabIndex = 2;
            this.btnToList.UseVisualStyleBackColor = false;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // lblItem
            // 
            this.lblItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItem.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.lblItem.Location = new System.Drawing.Point(0, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(285, 45);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "lblItem";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelCustomize
            // 
            this.flowLayoutPanelCustomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.flowLayoutPanelCustomize.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelCustomize.Location = new System.Drawing.Point(500, 0);
            this.flowLayoutPanelCustomize.Name = "flowLayoutPanelCustomize";
            this.flowLayoutPanelCustomize.Size = new System.Drawing.Size(250, 573);
            this.flowLayoutPanelCustomize.TabIndex = 2;
            // 
            // flowLayoutPanelFood
            // 
            this.flowLayoutPanelFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.flowLayoutPanelFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelFood.Location = new System.Drawing.Point(250, 0);
            this.flowLayoutPanelFood.Name = "flowLayoutPanelFood";
            this.flowLayoutPanelFood.Size = new System.Drawing.Size(250, 573);
            this.flowLayoutPanelFood.TabIndex = 1;
            // 
            // flowLayoutPanelType
            // 
            this.flowLayoutPanelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.flowLayoutPanelType.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelType.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelType.Name = "flowLayoutPanelType";
            this.flowLayoutPanelType.Size = new System.Drawing.Size(250, 573);
            this.flowLayoutPanelType.TabIndex = 0;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1035, 573);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelInMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelType;
        private System.Windows.Forms.Panel panelInMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCustomize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnToList;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCustomize2;
        private System.Windows.Forms.Label lblCustomize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrderItemList;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
    }
}