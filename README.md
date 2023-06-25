## 簡介

以WindowsForm(C#)開發的簡易的點餐系統，使用ADO.NET對MS SQL Server進行資料存取。

## 功能
- [x] **分權管理**：<br>
      以帳號登入的方式實施分權管理功能，權限分為三個等級<br>
      　1.root：(1)點餐(2)查詢訂單(3)更改名稱<非帳號>、密碼(4)對餐點資料進行CRUD、(5)對所有帳號進行CRUD，此帳號不能刪除。<br>
      　2.manager：(1)點餐(2)查詢訂單(3)更改名稱<非帳號>、密碼(4)對餐點資料進行CRUD(5)對權限為employee的帳號進行CRUD<br>
      　3.employee：僅有點餐與查詢訂單功能<br>
        <br>
        ![image](https://github.com/as147108/PointOfSale/blob/master/Images/Login.png)<br>
        <br>
      **帳號設定**：<br>
        <br>
        ![image](https://github.com/as147108/PointOfSale/blob/master/Images/SettingAccount.PNG?raw=true)<br>
        <br>
      **餐點設定**：<br>
        <br>
        ![image](https://github.com/as147108/PointOfSale/blob/master/Images/SettingFood.PNG?raw=true)<br>
        <br>
      **員工管理**：<br>
        <br>
        ![image](https://github.com/as147108/PointOfSale/blob/master/Images/SettingEmployee.PNG?raw=true)<br>
        <br>
- [x] **點餐**：<br>
      點選餐點後及時顯示總價並能看到已點列表，已點選餐點能隨時刪除，送出訂單後能在訂單頁面查詢。<br>
        <br>
        ![image](https://github.com/as147108/PointOfSale/blob/master/Images/Order.PNG?raw=true)<br>
        <br>
- [x] **查看訂單**：<br>
      查看未完成的訂單，點選訂單內的餐點會顯示刪除線，方便製作餐點。<br>
      <br>
      ![image](https://github.com/as147108/PointOfSale/blob/master/Images/OrderList.PNG?raw=true)<br>
      <br>
- [x] **訂單查詢**：<br>
      以日期查詢已完成餐點<br>
      <br>
       ![image](https://github.com/as147108/PointOfSale/blob/master/Image/OrderSearch.PNG?raw=true)<br>
      <br>
