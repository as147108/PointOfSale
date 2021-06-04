using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class orderItemList
    {
        public static bool isLogin = false;
        public static string account = ""; 
        public static string userName = "";
        public static int permissions = -1;
        public orderItemList()
        {

        }
        private int _itemId;
        private int _foodId;
        private int _cusId;
        private int _cusId2;
        private int _subTotal;

        public int itemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        public int foodId
        {
            get { return _foodId; }
            set { _foodId = value; }
        }

        public int cusId
        {
            get { return _cusId; }
            set { _cusId = value; }
        }
        public int cusId2
        {
            get { return _cusId2; }
            set { _cusId2 = value; }
        }
        public int subTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }
    }
}
