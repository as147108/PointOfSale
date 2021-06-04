
namespace PointOfSale
{
    partial class FormSearch
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOrderSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelOrderSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 93);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonOrderSearch);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(26, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 41);
            this.panel2.TabIndex = 1;
            // 
            // buttonOrderSearch
            // 
            this.buttonOrderSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOrderSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderSearch.ForeColor = System.Drawing.Color.White;
            this.buttonOrderSearch.Location = new System.Drawing.Point(413, 0);
            this.buttonOrderSearch.Name = "buttonOrderSearch";
            this.buttonOrderSearch.Size = new System.Drawing.Size(127, 41);
            this.buttonOrderSearch.TabIndex = 7;
            this.buttonOrderSearch.Text = "搜　尋";
            this.buttonOrderSearch.UseVisualStyleBackColor = true;
            this.buttonOrderSearch.Click += new System.EventHandler(this.buttonOrderSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(390, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 41);
            this.panel3.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 39);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 19F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "訂單日期：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelOrderSearch
            // 
            this.flowLayoutPanelOrderSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOrderSearch.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelOrderSearch.Location = new System.Drawing.Point(0, 93);
            this.flowLayoutPanelOrderSearch.Name = "flowLayoutPanelOrderSearch";
            this.flowLayoutPanelOrderSearch.Size = new System.Drawing.Size(1035, 480);
            this.flowLayoutPanelOrderSearch.TabIndex = 1;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1035, 573);
            this.Controls.Add(this.flowLayoutPanelOrderSearch);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormSearch";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOrderSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrderSearch;
    }
}