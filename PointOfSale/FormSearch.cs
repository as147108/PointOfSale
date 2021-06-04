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
    public partial class FormSearch : Form
    {
        posDbCRUD posDbCRUD = new posDbCRUD();
        string orderTime;
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            orderTime = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            orderTime = dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }

        private void buttonOrderSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanelOrderSearch.Controls.Clear();
            orderTime = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            int o_id;
            int total;
            var dtOrderDate = posDbCRUD.getQueryTable($"select * from orders where CONVERT(varchar, orders.orders_orderTime, 111) = '{orderTime}'");
            if (dtOrderDate.Rows.Count==0)
            {
                MessageBox.Show("查無訂單");
            }
            else
            {
                for (int i = 0; i < dtOrderDate.Rows.Count; i++)
                {
                    o_id = Convert.ToInt32(dtOrderDate.Rows[i]["orders_id"]);
                    total = 0;

                    string sql = "SELECT ol.*,ISNULL(cus1.cus_name,' ') as cusName1, ISNULL(cus2.cus_name,' ') AS cusName2, f.food_name, f.food_price,o.orders_isComplete , CONVERT(varchar, O.orders_orderTime, 111) " +
                      "from orderItemList ol " +
                      "left join customize cus1 on cus1.cus_id = ol.cus_id " +
                      "left join customize cus2 on cus2.cus_id = ol.cus_id2 " +
                      "left join food f on ol.food_id = f.food_id " +
                      "LEFT JOIN orders o ON o.orders_id = ol.orders_id " +
                      $"WHERE CONVERT(varchar, O.orders_orderTime, 111) = '{orderTime}' and ol.orders_id = {o_id}";

                    var dtOrdersSearch = posDbCRUD.getQueryTable(sql);

                    FlowLayoutPanel fl = new FlowLayoutPanel();
                    Panel plInpl = new Panel();
                    Label[] lbl = new Label[dtOrdersSearch.Rows.Count];
                    plInpl = new Panel();
                    Label lblCustomerNameAndTotal = new Label();
                    Label lblDate = new Label();
                    plInpl.Name = o_id.ToString();
                    plInpl.Width = 270;
                    plInpl.Height = 545;
                    plInpl.AutoScroll = true;
                    lblCustomerNameAndTotal.BackColor = Color.FromArgb(128, 142, 155);
                    lblCustomerNameAndTotal.Height = 40;
                    lblCustomerNameAndTotal.BorderStyle = BorderStyle.FixedSingle;
                    lblCustomerNameAndTotal.TextAlign = ContentAlignment.MiddleCenter;
                    lblCustomerNameAndTotal.Dock = DockStyle.Top;
                    lblCustomerNameAndTotal.AutoSize = false;
                    lblCustomerNameAndTotal.Font = new Font("微軟正黑體", 16, FontStyle.Bold);
                    lblCustomerNameAndTotal.ForeColor = Color.White;
                    var dtOrderCusName = posDbCRUD.getQueryTable($"select orders_customerName,orders_orderTime from orders where orders_id = {o_id}");
                    lblCustomerNameAndTotal.Text = "顧客:" + dtOrderCusName.Rows[0]["orders_customerName"].ToString();
                    string strDate = ((DateTime)dtOrderCusName.Rows[0]["orders_orderTime"]).ToString("yyyy-MM-dd HH:mm");
                    lblDate.Text = strDate;
                    for (int j = 0; j < dtOrdersSearch.Rows.Count; j++)
                    {
                        lbl[j] = new Label();
                        if ((j + 2) % 2 == 0)
                        {
                            lbl[j].BackColor = Color.FromArgb(43, 203, 186);
                        }
                        else
                        {
                            lbl[j].BackColor = Color.FromArgb(52, 231, 228);
                        }
                        lbl[j].Height = 35;
                        lbl[j].TextAlign = ContentAlignment.MiddleCenter;
                        lbl[j].Dock = DockStyle.Top;
                        lbl[j].AutoSize = false;
                        lbl[j].Font = new Font("微軟正黑體", 16, FontStyle.Bold);
                        lbl[j].ForeColor = Color.Black;
                        lbl[j].Text = dtOrdersSearch.Rows[j]["food_name"].ToString() + " " + dtOrdersSearch.Rows[j]["cusName1"].ToString() + " " + dtOrdersSearch.Rows[j]["cusName2"].ToString();
                        total += Convert.ToInt32(dtOrdersSearch.Rows[j]["item_subTotal"]);
                        plInpl.Controls.Add(lbl[j]);
                    }
                    lblCustomerNameAndTotal.Text = "顧客:" + dtOrderCusName.Rows[0]["orders_customerName"].ToString() + "　" + "金額:" + "$" + total.ToString();
                    plInpl.Controls.Add(lblCustomerNameAndTotal);
                    plInpl.Controls.Add(lblDate);

                    flowLayoutPanelOrderSearch.Controls.Add(plInpl);
                    flowLayoutPanelOrderSearch.AutoScroll = true;

                }
            }
        }
    }
}
