using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Models;
using bai6quanlysieuthi.Bus;
using System.Data;

namespace bai6quanlysieuthi.Controller
{
    class CtPhieuNhapController
    {
        private static CtPhieuNhapController instance;
        public static CtPhieuNhapController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CtPhieuNhapController();
                return CtPhieuNhapController.instance;
            }
            private set { CtPhieuNhapController.instance = value; }
        }

        private CtPhieuNhapController() { }

        public List<chitiepphieunhap> XemCtPhieuNhap()
        {
            List<chitiepphieunhap> list = new List<chitiepphieunhap>();
            string query = "select stt,manhap,mamathang,soluong,dongia from chitiepphieunhap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                chitiepphieunhap hd = new chitiepphieunhap(item);
                list.Add(hd);
            }
            return list;
        }
    }
}
