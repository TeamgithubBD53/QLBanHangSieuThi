using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Models;
using System.Data;
using bai6quanlysieuthi.Bus;

namespace bai6quanlysieuthi.Controller
{
    class NhapKhoController
    {
        private static NhapKhoController instance;
        public static NhapKhoController Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhapKhoController();
                return NhapKhoController.instance;
            }
            private set { NhapKhoController.instance = value; }
        }

        private NhapKhoController() { }

        public List<phieunhapkho> XemNhapKho()
        {
            List<phieunhapkho> list = new List<phieunhapkho>();
            string query = "select ma,makhohang,ngaynhap,tonggiatri,manhacungcap,manhanvien from phieunhapkho";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                phieunhapkho nk = new phieunhapkho(item);
                list.Add(nk);
            }
            return list;
        }
    }
}
