using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Bus;
using bai6quanlysieuthi.Models;
using System.Data;

namespace bai6quanlysieuthi.Controller
{
    class MatHangController
    {
        private static MatHangController instance;
        public static MatHangController Instance
        {
            get
            {
                if (instance == null)
                    instance = new MatHangController();
                return MatHangController.instance;
            }
            private set { MatHangController.instance = value; }
        }

        private MatHangController() { }
        // xem mat hang
        public List<mathang> XemMatHang()
        {
            List<mathang> list = new List<mathang>();
            string query = "select ma,ten,loaimathang,donvitinh,maquay,manhacc,gia from mathang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                mathang mh = new mathang(item);
                list.Add(mh);
            }
            return list;
        }
    }
}
