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
    public partial class FormMenu : Form
    {
        //連接字串
        SqlConnectionStringBuilder scsb;
        string posDBconnectionString = "";
        posDbCRUD posDbCRUD = new posDbCRUD();
        //暫存
        orderItemList orderItemList = new orderItemList();
        int itemId = 0;
        int orderId = 0;
        //int intItemId = 0;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //sqlConnection
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "posDB";
            scsb.IntegratedSecurity = true;
            posDBconnectionString = scsb.ToString();
            //初始化
            initial();
            populateType();
            var dtOrders = posDbCRUD.getTableOrders();
            var dtItemList = posDbCRUD.getTableOrderItemList();

            if (dtOrders.Rows.Count==0)
            {
                populate();
            }
            else if (Convert.ToInt32(dtOrders.Rows[Convert.ToInt32(dtOrders.Rows.Count-1)]["orders_id"])!= Convert.ToInt32(dtItemList.Rows[Convert.ToInt32(dtItemList.Rows.Count - 1)]["orders_id"]))
            {
                populate();
            }
        }
        private void initial()
        {
            DataTable dtOrder = posDbCRUD.getTableOrders();
            DataTable dtOrderItemList = posDbCRUD.getTableOrderItemList();
            itemId = dtOrderItemList.Rows.Count == 0 ? 0 : Convert.ToInt32(dtOrderItemList.Rows[dtOrderItemList.Rows.Count - 1]["item_id"]);
            orderId = dtOrder.Rows.Count == 0 ? 0 : Convert.ToInt32(dtOrder.Rows[dtOrder.Rows.Count-1]["orders_id"])+1;
            lblItem.Text = "";
            lblCustomize.Text = "";
            lblCustomize2.Text = "";
            lblSubTotal.Text = "";
            orderItemList.itemId = dtOrderItemList.Rows.Count == 0 ? 0 : Convert.ToInt32(dtOrderItemList.Rows[dtOrderItemList.Rows.Count - 1]["item_id"]);
            orderItemList.foodId=-1;
            orderItemList.cusId=-1;
            orderItemList.cusId2=-1;
            orderItemList.subTotal=-1;
            setLblTotal();
            
        }
        //顯示點餐種類
        #region typeShow
        // 顯示TypeBtn
        public void populateType()
        {
            //取得Table
            DataTable dt = posDbCRUD.getQueryTable("select * from type where type_onSelf = 1 order by type_id");
            //產生Button
            Button[] btn = new Button[dt.Rows.Count];
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i] = new Button();
                btn[i].Text = dt.Rows[i]["type_name"].ToString();
                btn[i].AutoSize = false;
                btn[i].Width = flowLayoutPanelType.Width - 5;
                btn[i].Height = 80;
                btn[i].BackColor = Color.FromArgb(223, 228, 234);
                btn[i].ForeColor = Color.FromArgb(88, 177, 159);
                btn[i].FlatAppearance.BorderSize = 1;
                btn[i].FlatStyle = 0;
                btn[i].Font = new Font("微軟正黑體", 20, FontStyle.Bold);

                flowLayoutPanelType.Controls.Add(btn[i]);

                btn[i].Click += new EventHandler(this.btnType_Click);
            }
            if (flowLayoutPanelType.Controls.Count >= 8) { flowLayoutPanelType.AutoScroll = true; }
        }
        //TypeBtn點擊事件
        public void btnType_Click(object sender, EventArgs e)
        {
            DataTable dt = posDbCRUD.getQueryTable("select * from type where type_onSelf = 1 order by type_id");
            Button btn = sender as Button;
            flowLayoutPanelFood.Controls.Clear();
            flowLayoutPanelCustomize.Controls.Clear();
            orderItemList.cusId = -1;
            orderItemList.cusId2 = -1;
            lblCustomize.Text = "";
            lblCustomize2.Text = "";
             
            for (int i = 0; i <dt.Rows.Count; i++)
            {
                if (btn.Text==dt.Rows[i]["type_name"].ToString())
                {
                    populateFood(Convert.ToInt32(dt.Rows[i]["type_id"]));
                }
            }
            flowLayoutPanelCustomize.Controls.Clear();
        }
        #endregion
        //顯示點餐項目
        #region foodShow
        private void populateFood(int type_id)
        {
            DataTable dt= posDbCRUD.getQueryTable($"SELECT * FROM food f WHERE f.type_id = {type_id} and food_onSelf = 1 order by food_id ");
            
            Button[] btn = new Button[dt.Rows.Count];

            for (int i = 0; i < btn.Length; i++)
            {
                btn[i] = new Button();
                btn[i].Text = dt.Rows[i]["food_name"].ToString()+"　$"+dt.Rows[i]["food_price"].ToString();
                btn[i].Name = dt.Rows[i]["type_id"].ToString()+"|"+ dt.Rows[i]["food_id"].ToString();
                btn[i].AutoSize = false;
                btn[i].Width = flowLayoutPanelFood.Width - 5;
                btn[i].Height = 80;
                btn[i].BackColor = Color.FromArgb(223, 228, 234);
                btn[i].ForeColor = Color.FromArgb(88, 177, 159);
                btn[i].FlatAppearance.BorderSize = 1;
                btn[i].FlatStyle = 0;
                btn[i].Font = new Font("微軟正黑體", 20, FontStyle.Bold);

                flowLayoutPanelFood.Controls.Add(btn[i]);

                btn[i].Click += new EventHandler(this.btnFood_Click);
            }
            if (flowLayoutPanelFood.Controls.Count >= 8) { flowLayoutPanelFood.AutoScroll = true; }
        }
        //foodBtn點擊事件
        public void btnFood_Click(object sender, EventArgs e)
        {
            DataTable dtType = posDbCRUD.getTableType();
            Button btn = sender as Button;
            string[] typeidAndFoodid = btn.Name.Split('|');
            string typeId = typeidAndFoodid[0];
            string foodId = typeidAndFoodid[1];
            var priceTable =posDbCRUD.getQueryTable($"SELECT FOOD_PRICE FROM FOOD WHERE FOOD_ID = {Convert.ToInt32(foodId)}");
            this.orderItemList.subTotal = Convert.ToInt32(priceTable.Rows[0]["food_price"]);
            orderItemList.foodId = Convert.ToInt32(foodId);
            lblItem.Text = btn.Text;
            lblSubTotal.Text ="$"+ this.orderItemList.subTotal.ToString();
            populateCustomize(Convert.ToInt32(dtType.Rows[Convert.ToInt32(typeidAndFoodid[0])]["type_isDrink"]),Convert.ToInt32(dtType.Rows[Convert.ToInt32(typeidAndFoodid[0])]["type_id"]));
            btnToList.Enabled = true;
            btnToList.BackColor = Color.FromArgb(116, 125, 140);
            if (flowLayoutPanelCustomize.Controls.Count >= 8) { flowLayoutPanelCustomize.AutoScroll = true; }
        }
        #endregion
        //客製化
        #region customizeShow
        private void populateCustomize(int isDrink,int typeId)
        {
            if (isDrink == 0)
            {
                DataTable dt = posDbCRUD.getQueryTable(
                      "SELECT c.cus_id, c.cus_name, c.cus_price, c.type_id, T.type_isDrink " +
                      "FROM Customize c " +
                      "INNER JOIN Type t ON c.type_id = t.type_id " +
                      $"WHERE t.type_isDrink = 0 AND T.type_id={typeId};");
                flowLayoutPanelCustomize.Controls.Clear();
                CheckBox[] cbxShow = new CheckBox[dt.Rows.Count];
                Panel[] pl = new Panel[dt.Rows.Count];
                for (int i = 0; i < cbxShow.Length; i++)
                {
                    pl[i] = new Panel();
                    pl[i].BorderStyle = BorderStyle.FixedSingle;
                    pl[i].Width = flowLayoutPanelCustomize.Width - 5;
                    pl[i].Height = 80;

                    cbxShow[i] = new CheckBox();
                    cbxShow[i].Text = dt.Rows[i]["cus_name"].ToString()+"　$"+ dt.Rows[i]["cus_price"].ToString();
                    //textBoxCustomerName.Text= dt.Rows[i]["cus_name"].ToString() + "　$" + dt.Rows[i]["cus_price"].ToString();
                    cbxShow[i].Name = dt.Rows[i]["cus_name"].ToString()+"|"+ dt.Rows[i]["cus_price"].ToString()+"|"+i.ToString();
                    cbxShow[i].AutoSize = false;
                    cbxShow[i].Width = flowLayoutPanelCustomize.Width - 5;
                    cbxShow[i].Height = 80;
                    cbxShow[i].BackColor = Color.FromArgb(223, 228, 234);
                    cbxShow[i].ForeColor = Color.FromArgb(88, 177, 159);
                    cbxShow[i].Font = new Font("微軟正黑體", 20, FontStyle.Bold);
                    cbxShow[i].FlatStyle = FlatStyle.Flat;
                    cbxShow[i].TextAlign = ContentAlignment.MiddleCenter;

                    pl[i].Controls.Add(cbxShow[i]);
                    flowLayoutPanelCustomize.Controls.Add(pl[i]);

                    cbxShow[i].CheckedChanged += new EventHandler(this.cbxFoodCustomize_CheckChanged);
                }
            }
            else
            {
                DataTable dt = posDbCRUD.getQueryTable(
                    "SELECT c.cus_id, c.cus_name, c.cus_price, c.type_id, T.type_isDrink " +
                    "FROM Customize c " +
                    "INNER JOIN Type t ON c.type_id = t.type_id " +
                    $"WHERE t.type_isDrink = 1 AND T.type_id={typeId};");
                flowLayoutPanelCustomize.Controls.Clear();
                Panel[] pl = new Panel[2];
                Label[] lbl = new Label[2];
                RadioButton[] rbSugar = new RadioButton[4];
                RadioButton[] rbIce = new RadioButton[4];

                pl[0] = new Panel();
                pl[0].BackColor = Color.White;
                pl[0].BorderStyle = BorderStyle.FixedSingle;
                pl[0].Width = flowLayoutPanelCustomize.Width - 5;
                pl[0].Height = 250;

                lbl[0] = new Label();
                lbl[0].BorderStyle = BorderStyle.FixedSingle;
                lbl[0].Text = " 甜　度";
                lbl[0].Dock = DockStyle.Top;
                lbl[0].AutoSize = false;
                lbl[0].Width = flowLayoutPanelCustomize.Width - 5;
                lbl[0].Height = 50;
                lbl[0].BackColor = Color.FromArgb(88, 177, 159);
                lbl[0].ForeColor = Color.Black;
                lbl[0].Font = new Font("微軟正黑體", 20, FontStyle.Bold);
                lbl[0].FlatStyle = FlatStyle.Flat;
                lbl[0].TextAlign = ContentAlignment.MiddleCenter;

                pl[1] = new Panel();
                pl[1].BackColor = Color.White;
                pl[1].BorderStyle = BorderStyle.FixedSingle;
                pl[1].Width = flowLayoutPanelCustomize.Width - 5;
                pl[1].Height = 250;

                lbl[1] = new Label();
                lbl[1].BorderStyle = BorderStyle.FixedSingle;
                lbl[1].Text = " 冰　塊";
                lbl[1].Dock = DockStyle.Top;
                lbl[1].AutoSize = false;
                lbl[1].Width = flowLayoutPanelCustomize.Width - 5;
                lbl[1].Height = 50;
                lbl[1].BackColor = Color.FromArgb(88, 177, 159);
                lbl[1].ForeColor = Color.Black;
                lbl[1].Font = new Font("微軟正黑體", 20, FontStyle.Bold);
                lbl[1].FlatStyle = FlatStyle.Flat;
                lbl[1].TextAlign = ContentAlignment.MiddleCenter;

                for (int j = 0; j < 4; j++)
                {
                    rbSugar[j] = new RadioButton();
                    if (j == 0)
                    {
                        rbSugar[j].Checked = true;
                        lblCustomize.Text = "正常甜";
                        orderItemList.cusId = Convert.ToInt32(dt.Rows[j]["cus_id"]);
                    }
                    rbSugar[j].Name = dt.Rows[j]["cus_id"].ToString();
                    rbSugar[j].Text = dt.Rows[j]["cus_name"].ToString();
                    rbSugar[j].Dock = DockStyle.Bottom;
                    rbSugar[j].AutoSize = false;
                    rbSugar[j].BackColor = Color.Black;
                    rbSugar[j].Width = flowLayoutPanelCustomize.Width - 5;
                    rbSugar[j].Height = 50;
                    rbSugar[j].BackColor = Color.FromArgb(223, 228, 234);
                    rbSugar[j].ForeColor = Color.FromArgb(88, 177, 159);
                    rbSugar[j].Font = new Font("微軟正黑體", 20, FontStyle.Bold);
                    rbSugar[j].FlatStyle = FlatStyle.Flat;
                    rbSugar[j].TextAlign = ContentAlignment.MiddleCenter;
                    rbSugar[j].Click += new EventHandler(rbSugar_CheckedChanged);
                    pl[0].Controls.Add(rbSugar[j]);
                }
                pl[0].Controls.Add(lbl[0]);
                flowLayoutPanelCustomize.Controls.Add(pl[0]);

                for (int j = 0; j < 4; j++)
                {
                    rbIce[j] = new RadioButton();
                    if (j == 0)
                    {
                        rbIce[j].Checked = true;
                        lblCustomize2.Text = "正常冰";
                        orderItemList.cusId2 = Convert.ToInt32(dt.Rows[j + 4]["cus_id"]);
                    }
                    rbIce[j].Name = dt.Rows[j+4]["cus_id"].ToString();
                    rbIce[j].Text = dt.Rows[j + 4]["cus_name"].ToString();
                    rbIce[j].Dock = DockStyle.Bottom;
                    rbIce[j].AutoSize = false;
                    rbIce[j].BackColor = Color.Black;
                    rbIce[j].Width = flowLayoutPanelCustomize.Width - 5;
                    rbIce[j].Height = 50;
                    rbIce[j].BackColor = Color.FromArgb(223, 228, 234);
                    rbIce[j].ForeColor = Color.FromArgb(88, 177, 159);
                    rbIce[j].Font = new Font("微軟正黑體", 20, FontStyle.Bold);
                    rbIce[j].FlatStyle = FlatStyle.Flat;
                    rbIce[j].TextAlign = ContentAlignment.MiddleCenter;
                    rbIce[j].Click += new EventHandler(rbIce_CheckedChanged);
                    pl[1].Controls.Add(rbIce[j]);
                }
                pl[1].Controls.Add(lbl[1]);
                flowLayoutPanelCustomize.Controls.Add(pl[1]);
            }
        }
        public void cbxFoodCustomize_CheckChanged(object sender,EventArgs e)
        {
            DataTable dt = posDbCRUD.getTableCustomize();
            CheckBox cbx = sender as CheckBox;
            string[] cusNameAndPrice = cbx.Name.Split('|');
            string cusName = cusNameAndPrice[0];
            string cusPrice = cusNameAndPrice[1];
            string cusId = cusNameAndPrice[2];
            if (cbx.Checked == true)
            {
                if (cusName == "加起司")
                {
                    if (lblItem.Text.Length != 0)
                    {
                        lblCustomize.Text = "加起司"+"　$"+cusPrice;
                        this.orderItemList.subTotal += 5;
                        lblSubTotal.Text = "$" + this.orderItemList.subTotal.ToString();
                        orderItemList.cusId = Convert.ToInt32(cusId);
                        //lblSubTotal.Text = "$" + ClassData1.subTotal.ToString();
                    }
                    else
                    {
                        MessageBox.Show("請點主餐");
                    }
                }
                if (cusName == "加　蛋")
                {
                    if (lblItem.Text.Length != 0)
                    {
                        lblCustomize2.Text = "加　蛋" + "　$" + cusPrice;
                        this.orderItemList.subTotal += 10;
                        lblSubTotal.Text = "$" + this.orderItemList.subTotal.ToString();
                        orderItemList.cusId2 = Convert.ToInt32(cusId);

                        //lblSubTotal.Text = "$" + ClassData1.subTotal.ToString();
                    }
                    else
                    {
                        MessageBox.Show("請點主餐");
                    }
                }
            }

            if (cbx.Checked == false)
            {
                if (cusName == "加起司")
                {
                    if (lblItem.Text.Length != 0)
                    {
                        lblCustomize.Text = " ";
                        this.orderItemList.subTotal -= 5;
                        lblSubTotal.Text = "$" + this.orderItemList.subTotal.ToString();
                        orderItemList.cusId = -1;
                        //lblSubTotal.Text = "$" + ClassData1.subTotal.ToString();
                    }
                    else
                    {
                        MessageBox.Show("請點主餐");
                    }
                }
                if (cusName == "加　蛋")
                {
                    if (lblItem.Text.Length != 0)
                    {

                        lblCustomize2.Text = "";
                        this.orderItemList.subTotal -= 10;
                        lblSubTotal.Text = "$"+this.orderItemList.subTotal.ToString();
                        orderItemList.cusId2 = -1;
                        // lblSubTotal.Text = "$" + ClassData1.subTotal.ToString();
                    }
                    else
                    {
                        MessageBox.Show("請點主餐");
                    }
                }
            }
        }
        public void rbSugar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                lblCustomize.Text = rb.Text;
                orderItemList.cusId = Convert.ToInt32(rb.Name);
            }
        }
        public void rbIce_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                lblCustomize2.Text = rb.Text;
                orderItemList.cusId2 = Convert.ToInt32(rb.Name);
            }
        }
        #endregion
        //暫存訂單
        private void btnToList_Click(object sender, EventArgs e)
        {
            if (orderItemList.subTotal>0)
            {
                populateOrderItemList(false);
                //itemId++;
                initial();
                btnToList.Enabled = false;
                btnToList.BackColor = Color.FromArgb(178, 190, 195);
            }
            else
            {
                MessageBox.Show("請點餐");
            }
        }
        public void populateOrderItemList(bool isDelete)
        {
            if (flowLayoutPanelOrderItemList.Controls.Count >= 1)
            {
                flowLayoutPanelOrderItemList.AutoScroll = true;
            }
           
                //取得DB資料
            string strItemId = itemId.ToString();

            var tbFood = posDbCRUD.getQueryTable($"select food_name from food where food_id={orderItemList.foodId}");
            string strFoodName =tbFood.Rows[0]["food_name"].ToString();

            var tbCusName = posDbCRUD.getQueryTable($"select cus_name from customize where cus_id={orderItemList.cusId}");
            string strFoodCusName = tbCusName.Rows.Count == 0 ? "" : tbCusName.Rows[0]["cus_name"].ToString();

            var tbCusName2 = posDbCRUD.getQueryTable($"select cus_name from customize where cus_id={orderItemList.cusId2}");
            string strFoodCusName2 = tbCusName2.Rows.Count == 0 ? "" : tbCusName2.Rows[0]["cus_name"].ToString();

            string strSubTotal = orderItemList.subTotal.ToString();

            var tbOrderItemList = posDbCRUD.getTableOrderItemList();

            var tbOrders = posDbCRUD.getTableOrders();

            itemId =tbOrderItemList.Rows.Count==0 ?0:Convert.ToInt32(tbOrderItemList.Rows[tbOrderItemList.Rows.Count-1]["item_id"]);
            itemId++;
            if (isDelete == false)
            {
                string sql = $"INSERT INTO orderItemList values({orderId},{itemId},{orderItemList.foodId},{orderItemList.cusId},{orderItemList.cusId2},{orderItemList.subTotal},0);";
                posDbCRUD.execeteSql(sql);
            }
            initial();
            populate();
         
        }
        public void populate()
        {
            flowLayoutPanelOrderItemList.Controls.Clear();
            var dtOrderItemList = posDbCRUD.getQueryTable($"select * from orderItemList where orders_id = {orderId}");
            if (dtOrderItemList.Rows.Count!=0)
            { 
                 for (int j = 0; j < dtOrderItemList.Rows.Count; j++)
                  {
                    var tbFood = posDbCRUD.getQueryTable($"select food_name from food where food_id={dtOrderItemList.Rows[j]["food_id"]}");
                    string strFoodName = tbFood.Rows[0]["food_name"].ToString();

                    var tbCusName = posDbCRUD.getQueryTable($"select cus_name from customize where cus_id={dtOrderItemList.Rows[j]["cus_id"]}");
                    string strFoodCusName = tbCusName.Rows.Count == 0 ? "" : tbCusName.Rows[0]["cus_name"].ToString();

                    var tbCusName2 = posDbCRUD.getQueryTable($"select cus_name from customize where cus_id={dtOrderItemList.Rows[j]["cus_id2"]}");
                    string strFoodCusName2 = tbCusName2.Rows.Count == 0 ? "" : tbCusName2.Rows[0]["cus_name"].ToString();

                    string strSubTotal = dtOrderItemList.Rows[j]["item_subTotal"].ToString();

                    var tbOrders = posDbCRUD.getTableOrders();

                    itemId = dtOrderItemList.Rows.Count == 0 ? 0 : Convert.ToInt32(dtOrderItemList.Rows[dtOrderItemList.Rows.Count - 1]["item_id"]);

                    Panel pl = new Panel();
                    Button btn = new Button();
                    Label[] lbl = new Label[3];

                    pl.Name = dtOrderItemList.Rows[j]["item_id"].ToString();
                    pl.BorderStyle = BorderStyle.FixedSingle;
                    pl.Width = flowLayoutPanelOrderItemList.Width - 23;
                    pl.Height = 108;

                    btn.Name = dtOrderItemList.Rows[j]["item_id"].ToString();
                    btn.AutoSize = false;
                    btn.Width = flowLayoutPanelOrderItemList.Width - 5;
                    btn.Height = 40;
                    btn.BackColor = Color.Red;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatStyle = 0;
                    btn.Font = new Font("微軟正黑體", 18, FontStyle.Bold);
                    btn.Dock = DockStyle.Top;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Text = "刪除";
                    btn.Click += new EventHandler(this.orderList_Delete);

                    pl.Controls.Add(btn);

                    for (int i = 0; i < lbl.Length; i++)
                    {
                        lbl[i] = new Label();
                        lbl[i].BorderStyle = BorderStyle.None;
                        lbl[i].Dock = DockStyle.Top;
                        lbl[i].AutoSize = false;
                        lbl[i].Width = flowLayoutPanelOrderItemList.Width - 5;
                        lbl[i].Height = 20;
                        lbl[i].BackColor = Color.FromArgb(223, 228, 234);
                        lbl[i].ForeColor = Color.FromArgb(88, 177, 159);
                        lbl[i].Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                        lbl[i].FlatStyle = FlatStyle.Flat;
                        lbl[i].TextAlign = ContentAlignment.MiddleLeft;

                        if (i == 0)
                        {
                            lbl[i].Text = "$" + strSubTotal;
                        }
                        if (i == 1)
                        {
                            if (strFoodCusName == "" || strFoodCusName2 == "")
                            {
                                lbl[i].Text = strFoodCusName + strFoodCusName2;
                            }
                            else
                            {
                                lbl[i].Text = strFoodCusName + "、" + strFoodCusName2;
                            }
                        }
                        if (i == 2)
                        {
                            lbl[i].Font = new Font("微軟正黑體", 16, FontStyle.Bold);
                            lbl[i].ForeColor = Color.Black;
                            lbl[i].Height = 25;
                            lbl[i].Text = strFoodName;
                        }
                        pl.Controls.Add(lbl[i]);
                    }
                    flowLayoutPanelOrderItemList.Controls.Add(pl);
                }
            }
        }
        private void orderList_Delete(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            DataTable dt = posDbCRUD.getTableOrderItemList();
            foreach (Control pl in flowLayoutPanelOrderItemList.Controls)
            {
                if (pl.Name == btn.Name)
                {
                    flowLayoutPanelOrderItemList.Controls.Remove(pl);
                }
            }
            string sql = $"DELETE FROM orderItemList WHERE item_id = {btn.Name}";
            posDbCRUD.execeteSql(sql);
            setLblTotal();
        }
        private void setLblTotal()
        {
            int total=0;
            var dtTotal = posDbCRUD.getQueryTable(
                $"SELECT ol.orders_id,ol.orders_id,fd.food_price, ISNULL(cus1.cus_price,0) AS cus1Price,ISNULL(cus2.cus_price,0) AS cus2Price " +
                $"FROM orderItemList ol " +
                $"LEFT JOIN food fd ON ol.food_id = fd.food_id " +
                $"LEFT JOIN customize cus1 ON cus1.cus_id = ol.cus_id " +
                $"LEFT JOIN customize cus2 ON cus2.cus_id = ol.cus_id2 " +
                $"where orders_id = {orderId}");

            for (int i = 0; i < dtTotal.Rows.Count; i++)
            {
                total += Convert.ToInt32(dtTotal.Rows[i]["food_price"])+Convert.ToInt32(dtTotal.Rows[i]["cus1Price"])+Convert.ToInt32(dtTotal.Rows[i]["cus2Price"]);
            }
            lblTotal.Text = "$"+total.ToString();
        }
        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelOrderItemList.Controls.Count == 0)
            {
                MessageBox.Show("請點餐");
            }
            else if (textBoxCustomerName.Text.Length==0||textBoxCustomerName.Text== "顧客名稱")
            {
                MessageBox.Show("請輸入顧客名稱");
            }
            else if (isSPChar(textBoxCustomerName.Text))
            {
                MessageBox.Show("請誤輸入特殊字元");
            }
            else if (textBoxCustomerName.Text.Length>6)
            {
                MessageBox.Show("顧客名稱請勿超過6個字");
            }
            else
            {
                if (MessageBox.Show("送出訂單?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string dtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string sql = $"insert into orders (orders_id,orders_orderTime,orders_customerName,orders_isComplete) values({orderId},'{dtime}','{textBoxCustomerName.Text}',0)";
                    posDbCRUD.execeteSql(sql);
                    var dt = posDbCRUD.getTableOrders();
                    orderId = Convert.ToInt32(dt.Rows[Convert.ToInt32(dt.Rows.Count - 1)]["orders_id"]) + 1;
                    flowLayoutPanelOrderItemList.Controls.Clear();
                    MessageBox.Show("訂單已送出");
                    textBoxCustomerName.Text = "顧客名稱";
                    lblTotal.Text = "$0";
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
        private void textBoxCustomerName_Click(object sender, EventArgs e)
        {
            textBoxCustomerName.Text = "";
        }
        private void textBoxCustomerName_Leave(object sender, EventArgs e)
        {
            if (textBoxCustomerName.Text=="")
            {
                textBoxCustomerName.Text = "顧客名稱";
            }
        }
        private void textBoxCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnSendOrder.Focus();
                btnSendOrder_Click(sender,e);
                textBoxCustomerName.Focus();
            }
        }
    }
}
