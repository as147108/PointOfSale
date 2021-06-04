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
    public partial class FormOrders : Form
    {
        posDbCRUD posDbCRUD = new posDbCRUD();
        public FormOrders()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            flowLayoutPanelOrders.Controls.Clear();
            Orders_Add();
        }
    
        public void Orders_Add()
        {
            DataTable dtOrders = posDbCRUD.getQueryTable("select * from orders where orders_isComplete = 0");
            int o_id;
            int total;
            for (int i = 0; i < dtOrders.Rows.Count; i++)
            {
                o_id =Convert.ToInt32(dtOrders.Rows[i]["orders_id"]);
                total = 0;
                string sql = "SELECT ol.*,ISNULL(cus1.cus_name,' ') as cusName1, ISNULL(cus2.cus_name,' ') AS cusName2, f.food_name, f.food_price,o.orders_isComplete,Item_isFinish " +
                "from orderItemList ol " +
                "left join  customize cus1 on cus1.cus_id = ol.cus_id " +
                "left join  customize cus2 on cus2.cus_id = ol.cus_id2 " +
                "left join  food f on ol.food_id = f.food_id " +
                "LEFT JOIN orders o ON o.orders_id = ol.orders_id " +
                $"WHERE ol.orders_id = {o_id} AND orders_isComplete=0" ;
                var dtOrderitem = posDbCRUD.getQueryTable(sql);

                FlowLayoutPanel fl = new FlowLayoutPanel();
                Panel plInpl = new Panel();
                Label[] lbl = new Label[dtOrderitem.Rows.Count];
                CheckBox[] cbx = new CheckBox[dtOrderitem.Rows.Count];
                plInpl = new Panel();
                Label lblCustomerNameAndTotal = new Label();
                Label lblDate = new Label();
                Button btnDelete = new Button();
                plInpl.Name = o_id.ToString();
                plInpl.Width = 270;
                plInpl.Height = 545 ;
                plInpl.AutoScroll = true;
                lblCustomerNameAndTotal.BackColor = Color.FromArgb(128, 142, 155);
                lblCustomerNameAndTotal.Height = 40;
                lblCustomerNameAndTotal.BorderStyle = BorderStyle.FixedSingle;
                lblCustomerNameAndTotal.TextAlign = ContentAlignment.MiddleCenter;
                lblCustomerNameAndTotal.Dock = DockStyle.Top;
                lblCustomerNameAndTotal.AutoSize = false;
                lblCustomerNameAndTotal.Font = new Font("微軟正黑體", 16, FontStyle.Bold);
                lblCustomerNameAndTotal.ForeColor = Color.White;
                lblDate.BackColor = Color.FromArgb(116, 125, 140);
                lblDate.Height = 40;
                lblDate.BorderStyle = BorderStyle.FixedSingle;
                lblDate.TextAlign = ContentAlignment.MiddleCenter;
                lblDate.Dock = DockStyle.Top;
                lblDate.AutoSize = false;
                lblDate.Font = new Font("微軟正黑體", 16, FontStyle.Bold);
                lblDate.ForeColor = Color.White;
                btnDelete.Name = o_id.ToString();
                btnDelete.AutoSize = false;
                btnDelete.Height = 40;
                btnDelete.BackColor = Color.Red;
                btnDelete.ForeColor = Color.White;
                btnDelete.FlatAppearance.BorderSize = 1;
                btnDelete.FlatStyle = 0;
                btnDelete.Font = new Font("微軟正黑體", 18, FontStyle.Bold);
                btnDelete.Dock = DockStyle.Top;
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.Text = "完成訂單";
                btnDelete.Click += new EventHandler(this.btn_Finish);
                var dtOrderCusName = posDbCRUD.getQueryTable($"select orders_customerName,orders_orderTime from orders where orders_id = {o_id}");
                lblCustomerNameAndTotal.Text = "顧客:"+dtOrderCusName.Rows[0]["orders_customerName"].ToString();
                string strDate = ((DateTime)dtOrderCusName.Rows[0]["orders_orderTime"]).ToString("yyyy-MM-dd HH:mm");
                lblDate.Text = strDate;
                plInpl.Controls.Add(btnDelete);
                for (int j = 0; j <dtOrderitem.Rows.Count; j++)
                {
                    cbx[j] = new CheckBox();
                    if ((j+2)%2==0)
                    {
                        cbx[j].BackColor = Color.FromArgb(43, 203, 186);
                    }
                    else
                    {
                        cbx[j].BackColor = Color.FromArgb(52, 231, 228);
                    }
                    cbx[j].Height = 35;
                    cbx[j].TextAlign = ContentAlignment.MiddleCenter;
                    cbx[j].Dock = DockStyle.Top;
                    cbx[j].AutoSize = false;
                    cbx[j].Font = new Font("微軟正黑體", 16, FontStyle.Bold);
                    var isFinish = Convert.ToInt32(dtOrderitem.Rows[j]["Item_isFinish"]);
                    if (isFinish == 1)
                    {
                        cbx[j].Font = new Font("微軟正黑體", 16, FontStyle.Strikeout);
                        cbx[j].Checked = true;
                    }
                    cbx[j].ForeColor = Color.Black;
                    cbx[j].Text = dtOrderitem.Rows[j]["food_name"].ToString() +" "+ dtOrderitem.Rows[j]["cusName1"].ToString() +" "+ dtOrderitem.Rows[j]["cusName2"].ToString();
                    cbx[j].CheckedChanged += new EventHandler(this.cbx_CheckedChanged);
                    cbx[j].Tag = dtOrderitem.Rows[j]["item_id"];
                    total+=Convert.ToInt32(dtOrderitem.Rows[j]["item_subTotal"]);
                    plInpl.Controls.Add(cbx[j]);
                }
                var dtOd = posDbCRUD.getQueryTable($"select * from orders where orders_id = {o_id}");
                if (dtOd.Rows[0]["orders_Total"].ToString()=="")
                {
                    posDbCRUD.execeteSql($"update orders set orders_Total = {total} where orders_id = {o_id}");
                }
                lblCustomerNameAndTotal.Text = "顧客:" + dtOrderCusName.Rows[0]["orders_customerName"].ToString()+"　"+ "金額:" +"$"+ total.ToString();
                plInpl.Controls.Add(lblCustomerNameAndTotal);
                plInpl.Controls.Add(lblDate);

                flowLayoutPanelOrders.Controls.Add(plInpl);
                if (flowLayoutPanelOrders.Controls.Count>3)
                {
                    flowLayoutPanelOrders.AutoScroll = true;
                }
            }
        }
        private void btn_Finish(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (MessageBox.Show("訂單已完成?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                posDbCRUD.execeteSql($"UPDATE orders SET orders_isComplete = 1 where orders_id = {btn.Name} ");
                FormOrders_Load(sender, e);
            } 
        }
        private void cbx_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbx = sender as CheckBox;
            if (cbx.Checked)
            {
                cbx.Font=new Font("微軟正黑體", 16, FontStyle.Strikeout);
                posDbCRUD.execeteSql($"update orderItemList set item_isFinish = 1 where item_id = {cbx.Tag.ToString()}");
            }
            else if (!cbx.Checked)
            {
                cbx.Font = new Font("微軟正黑體", 16, FontStyle.Bold);
                posDbCRUD.execeteSql($"update orderItemList set item_isFinish = 0 where item_id = {cbx.Tag.ToString()}");
            }
        }
    }
}
