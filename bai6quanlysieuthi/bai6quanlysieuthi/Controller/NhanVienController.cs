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
    class NhanVienController
    {
        public static NhanVienController instance;
        public static NhanVienController Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienController();
                return NhanVienController.instance;
            }
            private set { NhanVienController.instance = value; }
        }

        public NhanVienController() { }
        // xem nhân viên
        public List<nhanvien> XemNhanVien()
        {
            List<nhanvien> list = new List<nhanvien>();
            string query = "select ma,ten,ngaysinh,diachi,sodienthoai,machucvu,taikhoan,matkhau from nhanvien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                nhanvien hd = new nhanvien(item);
                list.Add(hd);
            }
            return list;
        }
        // thêm nhân viên
        public bool InsertNhanVien(string ma, string ten, DateTime ngaysinh, string diachi, string sodt, string macv, string tk, string mk)
        {
            string query = string.Format("insert nhanvien(ma,ten,ngaysinh,diachi,sodienthoai,machucvu,taikhoan,matkhau) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", ma, ten, ngaysinh, diachi, sodt, macv, tk, mk);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // sửa nhân viên
        public bool UpdateNhanVien(string ma, string ten, DateTime ngaysinh, string diachi, string sodt, string macv, string tk, string mk)
        {
            string query = string.Format("update nhanvien set ten=N'{0}',ngaysinh=N'{1}',diachi=N'{2}',sodienthoai=N'{3}',machucvu=N'{4}',taikhoan=N'{5}',matkhau=N'{6}' where ma=N'{7}'", ten, ngaysinh, diachi, sodt, macv, tk, mk, ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        //xóa nhân viên
        public bool DeleteNhanVien(string ma)
        {
            string query = string.Format("delete nhanvien where ma=N'{0}'", ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
       
    }
}
