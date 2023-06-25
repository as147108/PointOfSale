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
using System.IO;

namespace PointOfSale
{
    public class posDbCRUD
    {
        SqlConnectionStringBuilder scsb;
        string posDBconnectionString = "";
        DataSet ds = new DataSet();
        SqlConnection con = null;
        public posDbCRUD()
        {
            //連接字串

            //SQL Server
            //scsb = new SqlConnectionStringBuilder();
            //scsb.DataSource = @".\SQLEXPRESS";
            //scsb.InitialCatalog = "posDB";
            //scsb.IntegratedSecurity = true;
            //posDBconnectionString = scsb.ToString();
            //con = new SqlConnection(posDBconnectionString);
            //localDB
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = @".\posDB.mdf";
            string absolutePath = Path.GetFullPath(Path.Combine(currentDirectory, relativePath));
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"(LocalDB)\MSSQLLocalDB";
            scsb.AttachDBFilename = absolutePath;
            scsb.IntegratedSecurity = true;
            posDBconnectionString = scsb.ToString();
            con = new SqlConnection(posDBconnectionString);

            dataInitial();
        }
        #region Initial
        private void dataInitial()
        {
            con.Open();
            ds.Clear();
            //dataAdapter
            SqlDataAdapter sdaType = new SqlDataAdapter($"SELECT * FROM Type", con);
            sdaType.TableMappings.Add("Table", "type");
            SqlDataAdapter sdaFood = new SqlDataAdapter($"SELECT * FROM food", con);
            sdaFood.TableMappings.Add("Table", "food");
            SqlDataAdapter sdaCustomize = new SqlDataAdapter($"SELECT * FROM Customize", con);
            sdaCustomize.TableMappings.Add("Table", "Customize");
            SqlDataAdapter sdaOrderItemList = new SqlDataAdapter($"SELECT * FROM orderItemList", con);
            sdaOrderItemList.TableMappings.Add("Table", "orderItemList");
            SqlDataAdapter sdaOrders = new SqlDataAdapter($"SELECT * FROM orders", con);
            sdaOrders.TableMappings.Add("Table", "orders");
            SqlDataAdapter sdaUsers = new SqlDataAdapter($"SELECT * FROM users", con);
            sdaUsers.TableMappings.Add("Table", "users");
            //dataSet
            sdaType.Fill(ds);
            sdaFood.Fill(ds);
            sdaCustomize.Fill(ds);
            sdaOrderItemList.Fill(ds);
            sdaOrders.Fill(ds);
            sdaUsers.Fill(ds);
            con.Close();
        }
        #endregion
        #region execeteSql
        public void execeteSql(string sql)
        {
            SqlConnection con = new SqlConnection(posDBconnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region GetTable
        public DataTable getTableType()
        {
            dataInitial();
            return ds.Tables["type"];
        }
        public DataTable getTableFood()
        {
            dataInitial();
            return ds.Tables["food"];
        }
        public DataTable getTableCustomize()
        {
            dataInitial();
            return ds.Tables["customize"];
        }
        public DataTable getTableOrderItemList()
        {
            dataInitial();
            return ds.Tables["orderItemList"];
        }
        public DataTable getTableOrders()
        {
            dataInitial();
            return ds.Tables["orders"];
        }
        public DataTable getTableUsers()
        {
            dataInitial();
            return ds.Tables["users"];
        }
        /// <summary>
        ///輸入TSQL取得Table 
        /// </summary>
        /// <param name="strSql">TSQL</param>
        /// <returns>Table</returns>
        public DataTable getQueryTable(string strSql)
        {
            //connect
            con.Open();
            //dataAdapter
            SqlDataAdapter sda = new SqlDataAdapter(strSql, con);

            //dataSet
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();

            return ds.Tables[0];
        }
        #endregion
    }
}
