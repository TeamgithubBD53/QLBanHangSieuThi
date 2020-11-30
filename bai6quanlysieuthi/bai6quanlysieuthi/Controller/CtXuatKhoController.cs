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
    class CtXuatKhoController
    {
        private static CtXuatKhoController instance;
        public static CtXuatKhoController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CtXuatKhoController();
                return CtXuatKhoController.instance;
            }
            private set { CtXuatKhoController.instance = value; }
        }
        private CtXuatKhoController() { }
        // xem chi tiết phiếu xuất
        public List<chitietphieuxuat> XemCtXuatKho()
        {
            List<chitietphieuxuat> list = new List<chitietphieuxuat>();
            string query = "select stt,maxuat ,mamathang,soluong,dongia from chitietphieuxuat";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                chitietphieuxuat hd = new chitietphieuxuat(item);
                list.Add(hd);
            }
            return list;
        }
    }
}
