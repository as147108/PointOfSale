
namespace PointOfSale
{
    partial class FormOrders
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
            this.flowLayoutPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelOrders
            // 
            this.flowLayoutPanelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOrders.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelOrders.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            this.flowLayoutPanelOrders.Size = new System.Drawing.Size(1051, 571);
            this.flowLayoutPanelOrders.TabIndex = 0;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1051, 571);
            this.Controls.Add(this.flowLayoutPanelOrders);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrders;
    }
}