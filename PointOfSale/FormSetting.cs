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
    public partial class FormSetting : Form
    {
        posDbCRUD CRUD = new posDbCRUD();
        string delAccount = "";
        string modiAccount = "";
        DataTable dtUsers;
        int cbxDelIdx = 0;
        int cbxModiIdx = 0;
        int permissions = -1;
        int cbxFoodTypeIdx = -1;
        int cbxDelType = -1;
        int cbxAddFood = -1;
        int typeId = -1;
        int cbxDelFoodType = -1;
        int cbxDelFood = -1;
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            initial();
        }
        private void initial()
        {
            txtboxOldName.Text = (CRUD.getQueryTable($"select * from users where users_account = '{orderItemList.account}'")).Rows[0]["users_name"].ToString();
            //Modify Name
            txtboxNewName.Text = "";
            txtboxPassword.Text = "";
            //Modify Password
            txtboxOldPassword.TabIndex = 2;
            txtboxNewPassword.TabIndex = 3;
            txtboxNewPasswordConfirm.TabIndex = 4;
            txtboxOldPassword.Text = "";
            txtboxNewPassword.Text = "";
            txtboxNewPasswordConfirm.Text = "";
            //Add User
            txtboxAddName.Text = "";
            txtboxAddAccount.Text = "";
            txtboxAddPassword.Text = "";
            //Modify User
            txtboxModifyName.Text = "";
            txtboxModifyPassword.Text = "";
            comboBoxPermissions.Items.Clear();
            comboBoxModify.Items.Clear();
            //Delete User
            comboBoxDelete.Items.Clear();
            //Tab Index
            txtboxNewName.TabIndex = 0;
            txtboxPassword.TabIndex = 1;
            txtboxAddName.TabIndex = 0;
            txtboxAddAccount.TabIndex = 1;
            txtboxAddPassword.TabIndex = 2;
            txtboxModifyName.TabIndex = 3;
            txtboxModifyPassword.TabIndex = 5;
            //add Type
            textBoxAddtype.Text = "";
            //add food
            textBoxAddFood.Text = "";
            textBoxAddFoodPrice.Text = "";
            //新增帳號combobox
            if (orderItemList.permissions == 1)
            {
                comboBoxPermissions.Items.Add("員工");
            }
            else if (orderItemList.permissions == 2)
            {
                comboBoxPermissions.Items.Add("員工");
                comboBoxPermissions.Items.Add("管理職");
            }
            comboBoxPermissions.SelectedIndex = 0;
            //刪除帳號combobox
            if (orderItemList.permissions == 1)
            {
                dtUsers = CRUD.getQueryTable($"select * from users where uses_permissions = 0 order by users_account");


                for (int i = 0; i < dtUsers.Rows.Count; i++)
                {
                    comboBoxDelete.Items.Add(dtUsers.Rows[i]["users_name"]);
                    comboBoxDelete.SelectedIndex = 0;
                    cbxDelIdx = 0;
                    delAccount = dtUsers.Rows[0]["users_account"].ToString();
                }

            }
            else if (orderItemList.permissions == 2)
            {
                dtUsers = CRUD.getQueryTable($"select * from users where uses_permissions = 0 or uses_permissions = 1 order by users_account");
                for (int i = 0; i < dtUsers.Rows.Count; i++)
                {
                    comboBoxDelete.Items.Add(dtUsers.Rows[i]["users_name"]);
                    comboBoxDelete.SelectedIndex = 0;
                    cbxDelIdx = 0;
                    delAccount = dtUsers.Rows[0]["users_account"].ToString();
                }
            }

            //修改帳號combobox
            if (orderItemList.permissions == 1)
            {
                dtUsers = CRUD.getQueryTable($"select * from users where uses_permissions = 0 order by users_account");
                for (int i = 0; i < dtUsers.Rows.Count; i++)
                {
                    comboBoxModify.Items.Add(dtUsers.Rows[i]["users_name"]);
                    comboBoxModify.SelectedIndex = 0;
                    cbxModiIdx = 0;
                    modiAccount=dtUsers.Rows[0]["users_account"].ToString();
                }
            }
            else if (orderItemList.permissions == 2)
            {
                dtUsers = CRUD.getQueryTable($"select * from users where uses_permissions = 0 or uses_permissions = 1 order by users_account");
                for (int i = 0; i < dtUsers.Rows.Count; i++)
                {
                    comboBoxModify.Items.Add(dtUsers.Rows[i]["users_name"]);
                    comboBoxModify.SelectedIndex = 0;
                    cbxModiIdx = 0;
                    modiAccount = dtUsers.Rows[0]["users_account"].ToString();
                }
            }
            //新增種類combobox
            comboBoxAddType.Items.Clear();
            comboBoxAddType.Items.Add("食物");
            comboBoxAddType.Items.Add("飲料");
            comboBoxAddType.SelectedIndex = 0;
            cbxFoodTypeIdx = 0;
            //刪除種類combobox
            comboBoxDeleteType.Items.Clear();
            var dtType = CRUD.getQueryTable($"select * from type where type_onSelf = 1 order by type_id");
            for (int i = 0; i < dtType.Rows.Count; i++)
            {
                comboBoxDeleteType.Items.Add(dtType.Rows[i]["type_name"]);
            }
            comboBoxDeleteType.SelectedIndex = 0;
            cbxDelType = 0;
            //新增食物combobox
            comboBoxAddFood.Items.Clear();
            for (int i = 0; i < dtType.Rows.Count; i++)
            {
                comboBoxAddFood.Items.Add(dtType.Rows[i]["type_name"]);
            }
            comboBoxAddFood.SelectedIndex = 0;
            cbxAddFood= 0;


            //刪除食物combobox
            comboBoxDeleteFoodType.Items.Clear();
            for (int i = 0; i < dtType.Rows.Count; i++)
            {
                comboBoxDeleteFoodType.Items.Add(dtType.Rows[i]["type_name"]);
            }
            comboBoxDeleteFoodType.SelectedIndex = 0;
            cbxDelFoodType = 0;
            typeId = 0;
        }

        #region accountSetting

        #region updateName
        private void txtboxNewName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdateName.Focus();
                btnUpdateName_Click(sender, e);
                txtboxNewName.Focus();
            }
        }

        private void txtboxPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdateName.Focus();
                btnUpdateName_Click(sender, e);
                txtboxPassword.Focus();
            }
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            var dtAccount = CRUD.getQueryTable($"select * from users where users_account ='{orderItemList.account}'");
            if (txtboxNewName.Text.Length == 0)
            {
                MessageBox.Show("請輸入新名稱");
            }
            else if (isSPChar(txtboxNewName.Text) || isSPChar(txtboxPassword.Text))
            {
                MessageBox.Show("請勿輸入特殊字元");
            }
            else if (txtboxPassword.Text != dtAccount.Rows[0]["users_password"].ToString())
            {
                MessageBox.Show("密碼錯誤");
            }
            else
            {
                if (MessageBox.Show("是否更改名稱?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CRUD.execeteSql($"update users set users_name = '{txtboxNewName.Text}' where users_account = '{orderItemList.account}'");
                    MessageBox.Show("更改成功");
                    orderItemList.userName = txtboxNewName.Text;
                }
                initial();
            }
        }
        #endregion

        #region updatePassword

        private void txtboxOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdatePassword.Focus();
                btnUpdatePassword_Click(sender, e);
                txtboxOldPassword.Focus();
            }
        }

        private void txtboxNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdatePassword.Focus();
                btnUpdatePassword_Click(sender, e);
                txtboxNewPassword.Focus();
            }
        }

        private void txtboxNewPasswordConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdatePassword.Focus();
                btnUpdatePassword_Click(sender, e);
                txtboxNewPasswordConfirm.Focus();
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            var dtAccount = CRUD.getQueryTable($"select * from users where users_account ='{orderItemList.account}'");
            if (txtboxOldPassword.Text.Length == 0 || txtboxNewPassword.Text.Length == 0 || txtboxNewPasswordConfirm.Text.Length == 0)
            {
                MessageBox.Show("欄位不得為空");
            }
            else if (isSPChar(txtboxOldPassword.Text) || isSPChar(txtboxNewPassword.Text) || isSPChar(txtboxNewPasswordConfirm.Text))
            {
                MessageBox.Show("請勿輸入特殊字元");
            }
            else if (txtboxOldPassword.Text != dtAccount.Rows[0]["users_password"].ToString())
            {
                MessageBox.Show("密碼錯誤");
            }
            else if (txtboxNewPassword.Text.Length < 4 || txtboxNewPasswordConfirm.Text.Length < 4)
            {
                MessageBox.Show("密碼不得小於4個字元");
            }
            else if (txtboxNewPassword.Text != txtboxNewPasswordConfirm.Text)
            {
                MessageBox.Show("新密碼不一致");
            }
            else
            {
                if (MessageBox.Show("是否更改密碼?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CRUD.execeteSql($"update users set users_password = '{txtboxNewPassword.Text}' where users_account = '{orderItemList.account}'");
                    MessageBox.Show("更改成功");
                }
                initial();
            }
        }
        #endregion

        #endregion

        #region employeeManager

        #region addAccount
        private void txtboxAddName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
                btnAdd_Click(sender, e);
                txtboxAddName.Focus();
            }
        }

        private void txtboxAddAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
                btnAdd_Click(sender, e);
                txtboxAddAccount.Focus();
            }
        }

        private void txtboxAddPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
                btnAdd_Click(sender, e);
                txtboxAddPassword.Focus();
            }
        }
        private void comboBoxPermissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            permissions = comboBoxPermissions.SelectedIndex;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dt = CRUD.getTableUsers();
            bool isExist = false;
            if (txtboxAddName.Text.Length == 0 || txtboxAddAccount.Text.Length == 0 || txtboxAddPassword.Text.Length == 0)
            {
                MessageBox.Show($"名稱、帳號、密碼不得為空");
            }
            else if (isSPChar(txtboxAddName.Text) || isSPChar(txtboxAddAccount.Text) || isSPChar(txtboxAddPassword.Text))
            {
                MessageBox.Show("請勿輸入特殊字元");
            }
            else if (txtboxAddAccount.Text.Length < 4)
            {
                MessageBox.Show($"帳號不得小於4字元");
            }
            else if (txtboxAddPassword.Text.Length < 4)
            {
                MessageBox.Show($"密碼不得小於4字元");
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (txtboxAddAccount.Text == dt.Rows[i]["users_account"].ToString())
                    {
                        isExist = true;
                    }
                }
                if (isExist)
                {
                    MessageBox.Show("帳號已存在");
                }
                else if (MessageBox.Show("是否新增帳戶?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CRUD.execeteSql($"insert into users(users_name,users_account,users_password,uses_permissions) values('{txtboxAddName.Text}','{txtboxAddAccount.Text}','{txtboxAddPassword.Text}',{permissions})");
                    MessageBox.Show("新增成功");
                    initial();
                }
            }
        }


        #endregion

        #region deleteAccount

        private void comboBoxDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDelIdx = comboBoxDelete.SelectedIndex;
            if (orderItemList.permissions == 1)
            {
                dtUsers = CRUD.getQueryTable($"select * from users where uses_permissions = 0 order by users_account");
                delAccount = dtUsers.Rows[cbxDelIdx]["users_account"].ToString();
            }
            else if (orderItemList.permissions == 2)
            {
                dtUsers = CRUD.getQueryTable($"select * from users where uses_permissions = 0 or uses_permissions = 1 order by users_account");
                delAccount = dtUsers.Rows[cbxDelIdx]["users_account"].ToString();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否刪除", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.execeteSql($"delete from users where users_account = '{delAccount}'");
                MessageBox.Show("刪除成功");
            }
            initial();
        }
        #endregion

        #region modifyAccount

        private void comboBoxModify_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModiIdx = comboBoxModify.SelectedIndex;
            if (orderItemList.permissions == 1)
            {
                dtUsers = CRUD.getQueryTable($"select * from users where uses_permissions = 0 order by users_account");
                modiAccount = dtUsers.Rows[cbxModiIdx]["users_account"].ToString();
            }
            else if (orderItemList.permissions == 2)
            {
                dtUsers = CRUD.getQueryTable($"select * from users where uses_permissions = 0 or uses_permissions = 1 order by users_account");
                modiAccount = dtUsers.Rows[cbxModiIdx]["users_account"].ToString();
            }
            var dt = CRUD.getQueryTable($"select * from users where users_account = '{modiAccount}'");
            txtboxModifyName.Text = dt.Rows[0]["users_name"].ToString();
            txtboxModifyPassword.Text = dt.Rows[0]["users_password"].ToString();
        }
        private void txtboxModifyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnModify.Focus();
                btnModify_Click(sender, e);
                txtboxAddName.Focus();
            }
        }
        private void txtboxModifyPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnModify.Focus();
                btnModify_Click(sender, e);
                txtboxAddPassword.Focus();
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtboxModifyName.Text.Length == 0 || txtboxModifyPassword.Text.Length == 0)
            {
                MessageBox.Show("欄位值不能為空");
            }
            else if (isSPChar(txtboxModifyName.Text) || isSPChar(txtboxModifyPassword.Text))
            {
                MessageBox.Show("請勿輸入特殊字元");
            }
            else if (txtboxModifyPassword.Text.Length < 4)
            {
                MessageBox.Show("密碼不能小於4字元");
            }
            else
            {
                CRUD.execeteSql($"update users set users_name = '{txtboxModifyName.Text}',users_password = '{txtboxModifyPassword.Text}' where users_account = '{modiAccount}'");
                MessageBox.Show("更改成功");
            }
            initial();
        }

        #endregion

        #endregion

        #region foodSetting

        #region addType
        private void comboBoxAddType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxFoodTypeIdx = comboBoxAddType.SelectedIndex;
        }
        private void textBoxAddtype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnAdd.Focus();
                btnAdd_Click(sender, e);
                txtboxAddAccount.Focus();
            }
        }
        private void buttonAddType_Click(object sender, EventArgs e)
        {
            var dtType = CRUD.getTableType();
            if (textBoxAddtype.Text.Length==0)
            {
                MessageBox.Show("請輸入種類名稱");
            }
            else if (isSPChar(textBoxAddtype.Text))
            {
                MessageBox.Show("請勿輸入特殊字元");
            }
            else if (MessageBox.Show("是否新增種類","", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int newId =Convert.ToInt32(dtType.Rows[dtType.Rows.Count - 1]["type_id"])+1 ;
                var dtCus = CRUD.getTableCustomize();
                CRUD.execeteSql($"INSERT INTO Type(type_id,type_name,type_isDrink,type_onSelf) VALUES({newId.ToString()},'{textBoxAddtype.Text}',{cbxFoodTypeIdx.ToString()},1)");
                if (cbxFoodTypeIdx==0)
                {
                    int cusId = (Convert.ToInt32(dtCus.Rows[dtCus.Rows.Count - 1]["cus_id"]) + 1);
                    int cusId2 = (cusId+ 1);
                    CRUD.execeteSql($"INSERT INTO Customize(cus_id,cus_name,cus_price,type_id) VALUES({cusId},'加起司',5,{newId})");
                    CRUD.execeteSql($"INSERT INTO Customize(cus_id,cus_name,cus_price,type_id) VALUES({cusId2},'加　蛋',10,{newId})");
                }
                else
                {
                    int cusId = (Convert.ToInt32(dtCus.Rows[dtCus.Rows.Count - 1]["cus_id"]) + 1);
                    int cusId2 = (cusId + 1);
                    int cusId3 = (cusId2+ 1);
                    int cusId4 = (cusId3+ 1);
                    int cusId5 = (cusId4+ 1);
                    int cusId6 = (cusId5+ 1);
                    int cusId7 = (cusId6+ 1);
                    int cusId8 = (cusId7+ 1);
                    CRUD.execeteSql($"INSERT INTO Customize(cus_id,cus_name,cus_price,type_id) VALUES({cusId.ToString()},'正常甜',0,{newId.ToString()})");
                    CRUD.execeteSql($"INSERT INTO Customize(cus_id,cus_name,cus_price,type_id) VALUES({cusId2.ToString()},'少　糖',0,{newId.ToString()})");
                    CRUD.execeteSql($"INSERT INTO Customize(cus_id,cus_name,cus_price,type_id) VALUES({cusId3.ToString()},'微　糖',0,{newId.ToString()})");
                    CRUD.execeteSql($"INSERT INTO Customize(cus_id,cus_name,cus_price,type_id) VALUES({cusId4.ToString()},'無　糖',0,{newId.ToString()})");
                    CRUD.execeteSql($"INSERT INTO Customize(cus_id,cus_name,cus_price,type_id) VALUES({cusId5.ToString()},'正常冰',0,{newId.ToString()})");
                    CRUD.execeteSql($"INSERT INTO Customize(cus_id,cus_name,cus_price,type_id) VALUES({cusId6.ToString()},'少　冰',0,{newId.ToString()})");
                    CRUD.execeteSql($"INSERT INTO Customize(cus_id,cus_name,cus_price,type_id) VALUES({cusId7.ToString()},'微　冰',0,{newId.ToString()})");
                    CRUD.execeteSql($"INSERT INTO Customize(cus_id,cus_name,cus_price,type_id) VALUES({cusId8.ToString()},'去　冰',0,{newId.ToString()})");
                }
                MessageBox.Show("新增成功");
            }
            initial();
        }
        #endregion

        #region deleteType
        private void comboBoxDeleteType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDelType = comboBoxDeleteType.SelectedIndex;
        }

        private void buttonDeleteType_Click(object sender, EventArgs e)
        {
            var dtType = CRUD.getQueryTable($"select * from type where type_onSelf = 1 order by type_id");
            string typeId = dtType.Rows[cbxDelType]["type_id"].ToString();
            if (MessageBox.Show("子類別食物也將刪除，是否刪除?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                CRUD.execeteSql($"update food set food_onSelf = 0 where type_id = {typeId}");
                CRUD.execeteSql($"update type set type_onSelf = 0 where type_id = {typeId}");
                MessageBox.Show("刪除成功");
            }
            initial();
        }
        #endregion

        #region addFood
        private void comboBoxAddFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAddFood = comboBoxAddFood.SelectedIndex;
        }

        private void textBoxAddFood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                buttonAddFood.Focus();
                buttonAddFood_Click(sender, e);
                textBoxAddFood.Focus();
            }
        }
        private void textBoxAddFoodPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddFood.Focus();
                buttonAddFood_Click(sender, e);
                textBoxAddFoodPrice.Focus();
            }
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            int price = 0;
            if (textBoxAddFood.Text.Length==0||textBoxAddFoodPrice.Text.Length==0)
            {
                MessageBox.Show("欄位不得為空");
            }
            else if (isSPChar(textBoxAddFood.Text)||isSPChar(textBoxAddFoodPrice.Text))
            {
                MessageBox.Show("請勿輸入特殊字元");
            }
            else if (int.TryParse(textBoxAddFoodPrice.Text,out price))
            {
                if (MessageBox.Show("是否新增","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    var dtType = CRUD.getQueryTable($"select * from type where type_onSelf = 1 order by type_id");
                    string typeId = dtType.Rows[cbxAddFood]["type_id"].ToString();
                    var dtFood = CRUD.getTableFood();
                    string foodId = (Convert.ToInt32(dtFood.Rows[dtFood.Rows.Count - 1]["food_id"]) + 1).ToString();
                    CRUD.execeteSql($"insert into food(food_id,food_name,food_price,food_onSelf,type_id) values({foodId},'{textBoxAddFood.Text}',{price.ToString()},1,{typeId})");
                    MessageBox.Show("新增成功");
                }
            }
            else
            {
                MessageBox.Show("價錢輸入錯誤");
            }
            initial();
        }
        #endregion

        #region deleteFood

        #endregion
        #endregion
        //禁止輸入特殊字元
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

        private void comboBoxDeleteFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {           
            cbxDelFoodType = comboBoxDeleteFoodType.SelectedIndex;
            var dtType = CRUD.getQueryTable($"select * from type where type_onSelf = 1 order by type_id");
            typeId =Convert.ToInt32(dtType.Rows[cbxDelFoodType]["type_id"]);
            var dtFood = CRUD.getQueryTable($"SELECT * FROM food WHERE food_onSelf = 1 and type_id = {typeId.ToString()} order by food_id");
            comboBoxDeleteFood.Items.Clear();
            for (int i = 0; i < dtFood.Rows.Count; i++)
            {
                comboBoxDeleteFood.Items.Add(dtFood.Rows[i]["food_name"].ToString());
            }
            comboBoxDeleteFood.SelectedIndex = 0;
            cbxDelFood = 0;
        }

        private void comboBoxDeleteFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDelFood = comboBoxDeleteFood.SelectedIndex;
        }

        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            var dtDelFood = CRUD.getQueryTable($"SELECT * FROM food WHERE food_onSelf = 1 and type_id = {typeId.ToString()} order by food_id");
            string foodId = dtDelFood.Rows[cbxDelFood]["food_id"].ToString();
            if (MessageBox.Show("是否刪除","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                CRUD.execeteSql($"update food set food_onSelf = 0 where food_id = {foodId}");
                MessageBox.Show("刪除成功");
            }
            initial();
        }
    }
}
