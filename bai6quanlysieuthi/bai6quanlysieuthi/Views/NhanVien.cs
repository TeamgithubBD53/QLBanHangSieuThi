using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bai6quanlysieuthi.Controller;

namespace bai6quanlysieuthi.Views
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
#region menu điều hướng 
        private void menuTrangChu_Click(object sender, EventArgs e)
        {
            TrangChu f = new TrangChu();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuHangHoa_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        #endregion

#region Nhân viên 
        #region show thông tin nhân viên 
        private void  ViewNhanVien() {
            dgvNhanVien.DataSource = NhanVienController.Instance.XemNhanVien();
            dgvNhanVien.Columns["ma"].HeaderText = @"Mã";
            dgvNhanVien.Columns["ma"].Width = 45;
            dgvNhanVien.Columns["ten"].HeaderText = @"Họ và tên";
            dgvNhanVien.Columns["ten"].Width = 100;
            dgvNhanVien.Columns["ngaysinh"].HeaderText = @"Ngày sinh";
            dgvNhanVien.Columns["ngaysinh"].Width = 80;
            dgvNhanVien.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvNhanVien.Columns["diachi"].Width = 120;
            dgvNhanVien.Columns["sodienthoai"].HeaderText = @"Số điện thoại";
            dgvNhanVien.Columns["sodienthoai"].Width = 80;
            dgvNhanVien.Columns["machucvu"].HeaderText = @"Mã chức vụ";
            dgvNhanVien.Columns["machucvu"].Width = 60;
            dgvNhanVien.Columns["taikhoan"].HeaderText = @"Tài khoản";
            dgvNhanVien.Columns["taikhoan"].Width = 120;
            dgvNhanVien.Columns["matkhau"].HeaderText = @"Mật khẩu";
            dgvNhanVien.Columns["matkhau"].Width = 100;
        }
        private void btnView_NV_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtSoDienThoai.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            cbMaChucVu.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtTaiKhoan.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtMatKhau.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
        }
        #endregion

        #region Thêm nhân viên 
        private void btnInsert_NV_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "" || cbMaChucVu.Text == "" || txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                if (txtMa.Text == "")
                    errorProvider1.SetError(txtMa, "Chưa có dữ liệu");
                if (txtTen.Text == "")
                    errorProvider1.SetError(txtTen, "Chưa có dữ liệu");
                if (txtDiaChi.Text == "")
                    errorProvider1.SetError(txtDiaChi, "Chưa có dữ liệu");
                if (txtSoDienThoai.Text == "")
                    errorProvider1.SetError(txtSoDienThoai, "Chưa có dữ liệu");
                if (cbMaChucVu.Text == "")
                    errorProvider1.SetError(cbMaChucVu, "Chưa có dữ liệu");
                if (txtTaiKhoan.Text == "")
                    errorProvider1.SetError(txtTaiKhoan, "Chưa có dữ liệu");
                if (txtMatKhau.Text == "")
                    errorProvider1.SetError(txtMatKhau, "Chưa có dữ liệu");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMa.Text;
                string ten = txtTen.Text;
                string sdt = txtSoDienThoai.Text;
                string mcv = cbMaChucVu.Text;
                DateTime ngaysinh = (DateTime)Convert.ToDateTime(dtpNgaySinh.Value.ToString("MM/dd/yyyy"));
                string diachi = txtDiaChi.Text;
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                if (txtMa.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "" || cbMaChucVu.Text == "" || txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Phải điền đủ thông tin");
                    return;
                }

                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (NhanVienController.Instance.InsertNhanVien(ma, ten, ngaysinh, diachi, sdt, mcv, tk, mk))
                    {
                        MessageBox.Show("Thêm thành công!");
                        ViewNhanVien();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }

            }
            catch
            {
                MessageBox.Show("Lỗi thêm dữ liệu");
                return;
            }

        }
        #endregion

        #region Sửa nhân viên 
        private void btnUpdate_NV_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "" || cbMaChucVu.Text == "" || txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                if (txtMa.Text == "")
                    errorProvider1.SetError(txtMa, "Chưa có dữ liệu");
                if (txtTen.Text == "")
                    errorProvider1.SetError(txtTen, "Chưa có dữ liệu");
                if (txtDiaChi.Text == "")
                    errorProvider1.SetError(txtDiaChi, "Chưa có dữ liệu");
                if (txtSoDienThoai.Text == "")
                    errorProvider1.SetError(txtSoDienThoai, "Chưa có dữ liệu");
                if (cbMaChucVu.Text == "")
                    errorProvider1.SetError(cbMaChucVu, "Chưa có dữ liệu");
                if (txtTaiKhoan.Text == "")
                    errorProvider1.SetError(txtTaiKhoan, "Chưa có dữ liệu");
                if (txtMatKhau.Text == "")
                    errorProvider1.SetError(txtMatKhau, "Chưa có dữ liệu");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMa.Text;
                string ten = txtTen.Text;
                string sdt = txtSoDienThoai.Text;
                string mcv = cbMaChucVu.Text;
                DateTime ngaysinh = (DateTime)Convert.ToDateTime(dtpNgaySinh.Value.ToString("MM/dd/yyyy"));
                string diachi = txtDiaChi.Text;
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                if (txtMa.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "" || cbMaChucVu.Text == "" || txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Phải điền đủ thông tin");
                    return;
                }

                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (NhanVienController.Instance.UpdateNhanVien(ma, ten, ngaysinh, diachi, sdt, mcv, tk, mk))
                    {
                        MessageBox.Show("Sửa thành công!");
                        ViewNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi sửa dữ liệu");
                return;
            }
        }
        #endregion

        #region Xoá nhân viên 
        private void btnDelete_NV_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtMa.Text == "")
            {
                errorProvider1.SetError(txtMa, "Nhập vào mã");
                MessageBox.Show("Không có mã");
                return;
            }
            string ma = txtMa.Text;
            if (NhanVienController.Instance.DeleteNhanVien(ma))
            {
                if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    MessageBox.Show("Xóa thành công!");
                    ViewNhanVien();
                }
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }
        }



        #endregion

        #endregion

        #region Giao ca 
        #endregion

        #region Chi tiết giao ca 
        #endregion

       
    }
}
