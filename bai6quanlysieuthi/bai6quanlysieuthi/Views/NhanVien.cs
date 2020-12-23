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
            dgvNhanVien.Columns["ma"].Width = 80;
            dgvNhanVien.Columns["ten"].HeaderText = @"Họ và tên";
            dgvNhanVien.Columns["ten"].Width = 200;
            dgvNhanVien.Columns["ngaysinh"].HeaderText = @"Ngày sinh";
            dgvNhanVien.Columns["ngaysinh"].Width = 150;
            dgvNhanVien.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvNhanVien.Columns["diachi"].Width = 200;
            dgvNhanVien.Columns["sodienthoai"].HeaderText = @"Số điện thoại";
            dgvNhanVien.Columns["sodienthoai"].Width = 150;
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

        #region Tìm kiếm 
        private void btnSearch_NV_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text == @"Mã nhân viên")
            {
                if (txtSearch.Text != "")
                {
                    dgvNhanVien.DataSource = NhanVienController.Instance.SearchNhanVien(txtSearch.Text);
                }
            }
            else if (cbSearch.Text == @"Số điện thoại")
            {
                if (txtSearch.Text != "")
                {
                    dgvNhanVien.DataSource = NhanVienController.Instance.SearchNhanVien1(txtSearch.Text);
                }
            }
        }

        #endregion

        #region Thoát
        private void btnExit_NV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion

#region Giao ca 

        #region Show thông tin giao ca 
        private void btnView_PGC_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewGiaoCa();
        }
        void ViewGiaoCa()
        {
            dgvPhieuGC.DataSource = GiaoCaController.Instance.XemGiaoCa();
            dgvPhieuGC.Columns["ma"].HeaderText = @"Ma";
            dgvPhieuGC.Columns["ma"].Width = 45;
            dgvPhieuGC.Columns["ngay"].HeaderText = @"Ngày";
            dgvPhieuGC.Columns["ngay"].Width = 80;
            dgvPhieuGC.Columns["ca"].HeaderText = @"Ca";
            dgvPhieuGC.Columns["ca"].Width = 45;
            dgvPhieuGC.Columns["maquay"].HeaderText = @"Mã quầy";
            dgvPhieuGC.Columns["maquay"].Width = 50;
            dgvPhieuGC.Columns["manhanvien"].HeaderText = @"Mã nhân viên";
            dgvPhieuGC.Columns["manhanvien"].Width = 60;
        }
        private void dgvPhieuGC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGC.Text = dgvPhieuGC.CurrentRow.Cells[0].Value.ToString();
            dtpNgayGC.Text = dgvPhieuGC.CurrentRow.Cells[1].Value.ToString();
            cbCaGc.Text = dgvPhieuGC.CurrentRow.Cells[2].Value.ToString();
            txtMaQuayGC.Text = dgvPhieuGC.CurrentRow.Cells[3].Value.ToString();
            txtMaNhanVienGc.Text = dgvPhieuGC.CurrentRow.Cells[4].Value.ToString();
        }

        #endregion

        #region Thêm giao ca
        private void btnInsert_PGC_Click(object sender, EventArgs e)
        {
            if (txtMaGC.Text == "" || cbCaGc.Text == "" || txtMaNhanVienGc.Text == "" || txtMaQuayGC.Text == "")
            {
                if (txtMaGC.Text == "")
                    errorProvider1.SetError(txtMaGC, "Chưa nhập mã giao ca");
                if (cbCaGc.Text == "")
                    errorProvider1.SetError(cbCaGc, "Chưa nhập ca");
                if (txtMaQuayGC.Text == "")
                    errorProvider1.SetError(txtMaQuayGC, "Chưa nhập mã quầy");
                if (txtMaNhanVienGc.Text == "")
                    errorProvider1.SetError(txtMaNhanVienGc, "Chưa nhập mã nhân viên");
                MessageBox.Show("Nhập thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaGC.Text;
                DateTime ngay = (DateTime)Convert.ToDateTime(dtpNgayGC.Value.ToString("MM/dd/yyyy"));
                int ca = 0;
                if (cbCaGc.Text == @"Ca 1")
                {
                    ca = 1;
                }
                else if (cbCaGc.Text == @"Ca 2")
                {
                    ca = 2;
                }
                else if (cbCaGc.Text == @"Ca 3")
                {
                    ca = 3;
                }
                string maquay = txtMaQuayGC.Text;
                string manhanvien = txtMaNhanVienGc.Text;
                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (GiaoCaController.Instance.InsertGiaoCa(ma, ngay, ca, maquay, manhanvien))
                    {
                        MessageBox.Show("Thêm thành công!");
                        ViewGiaoCa();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion

        #region Sửa giao ca 
        private void btnUpdate_PGC_Click(object sender, EventArgs e)
        {
            if (txtMaGC.Text == "" || cbCaGc.Text == "" || txtMaNhanVienGc.Text == "" || txtMaQuayGC.Text == "")
            {
                if (txtMaGC.Text == "")
                    errorProvider1.SetError(txtMaGC, "Chưa nhập mã giao ca để sửa");
                if (cbCaGc.Text == "")
                    errorProvider1.SetError(cbCaGc, "Chưa nhập ca");
                if (txtMaQuayGC.Text == "")
                    errorProvider1.SetError(txtMaQuayGC, "Chưa nhập mã quầy");
                if (txtMaNhanVienGc.Text == "")
                    errorProvider1.SetError(txtMaNhanVienGc, "Chưa nhập mã nhân viên");
                MessageBox.Show("Nhập thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaGC.Text;
                DateTime ngay = (DateTime)Convert.ToDateTime(dtpNgayGC.Value.ToString("MM/dd/yyyy"));
                int ca = 0;
                if (cbCaGc.Text == @"Ca 1")
                {
                    ca = 1;
                }
                else if (cbCaGc.Text == @"Ca 2")
                {
                    ca = 2;
                }
                else if (cbCaGc.Text == @"Ca 3")
                {
                    ca = 3;
                }
                string maquay = txtMaQuayGC.Text;
                string manhanvien = txtMaNhanVienGc.Text;
                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (GiaoCaController.Instance.UpdateGiaoCa(ma, ngay, ca, maquay, manhanvien))
                    {
                        MessageBox.Show("Sửa thành công!");
                        ViewGiaoCa();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion

        #region Xoá giao ca  
        private void btnDelete_PGC_Click(object sender, EventArgs e)
        {
            if (txtMaGC.Text == "")
            {
                errorProvider1.SetError(txtMaGC, "Chưa có mã cần xóa");
                MessageBox.Show("Phải nhập vào mã cần xóa");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (GiaoCaController.Instance.DeleteGiaoCa(txtMaGC.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                    ViewGiaoCa();
                }
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }
        #endregion

        #region Tìm kiếm 
        private void btnSearch_PGC_Click(object sender, EventArgs e)
        {
            if (txtMaGC.Text == "" && txtMaQuayGC.Text == "" && txtMaNhanVienGc.Text == "")
            {
                if (txtMaGC.Text == "")
                    errorProvider1.SetError(txtMaGC, "Chưa có mã cần tìm");
                if (txtMaQuayGC.Text == "")
                    errorProvider1.SetError(txtMaQuayGC, "Chưa có mã quầy cần tìm");
                if (txtMaNhanVienGc.Text == "")
                    errorProvider1.SetError(txtMaNhanVienGc, "Chưa có mã nhân viên cần tìm");
                MessageBox.Show("Nhập vào thông tin cần tìm");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            string ma = txtMaGC.Text;
            string maquay = txtMaQuayGC.Text;
            string manhanvien = txtMaNhanVienGc.Text;
            dgvPhieuGC.DataSource = GiaoCaController.Instance.SearchGiaoCa(ma, maquay, manhanvien);
        }
        #endregion

        #region Thoát 
        private void btnExit_PGC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #endregion

#region Chi tiết giao ca 
        #region Show thông tin giao ca
        private void btnView_CTPGC_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewCTGiaoCa();
        }
        void ViewCTGiaoCa()
        {
            dgvCtGiaoCa.DataSource = CTGiaoCaController.Instance.XemCtGiaoCa();
            dgvCtGiaoCa.Columns["stt"].Width = 45;
            dgvCtGiaoCa.Columns["magiaoca"].HeaderText = @"Mã giao ca";
            dgvCtGiaoCa.Columns["magiaoca"].Width = 80;
            dgvCtGiaoCa.Columns["mamathang"].HeaderText = @"Mã mặt hàng";
            dgvCtGiaoCa.Columns["mamathang"].Width = 80;
            dgvCtGiaoCa.Columns["soluong"].HeaderText = @"Số lượng";
            dgvCtGiaoCa.Columns["soluong"].Width = 80;
            //dgvCtGiaoCa.Columns["phieugiaca"].DividerWidth=0;
        }
        private void dgvCtGiaoCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSTTCgc.Text = dgvCtGiaoCa.CurrentRow.Cells[0].Value.ToString();
            txtMaGiaoCaCgc.Text = dgvCtGiaoCa.CurrentRow.Cells[1].Value.ToString();
            txtMaMatHangCgc.Text = dgvCtGiaoCa.CurrentRow.Cells[2].Value.ToString();
            txtSoLuongCgc.Text = dgvCtGiaoCa.CurrentRow.Cells[3].Value.ToString();
        }

        #endregion

        #region Thêm giao ca
        private void btnInsert_CTPGC_Click(object sender, EventArgs e)
        {
            if (txtMaGiaoCaCgc.Text == "" || txtMaMatHangCgc.Text == "" || txtSoLuongCgc.Text == "")
            {
                if (txtMaGiaoCaCgc.Text == "")
                    errorProvider1.SetError(txtMaGiaoCaCgc, "Chưa nhập mã giao ca");
                if (txtMaMatHangCgc.Text == "")
                    errorProvider1.SetError(txtMaMatHangCgc, "Chưa nhập mã mặt hàng");
                if (txtSoLuongCgc.Text == "")
                    errorProvider1.SetError(txtSoLuongCgc, "Chưa nhập số lượng mặt hàng");
                MessageBox.Show("Nhập thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string maquay = txtMaGiaoCaCgc.Text;
                string mamathang = txtMaMatHangCgc.Text;
                int sl = (int)Convert.ToInt32(txtSoLuongCgc.Text);
                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (CTGiaoCaController.Instance.InsertCtGiaoCa(maquay, mamathang, sl))
                    {
                        MessageBox.Show("Thêm thành công!");
                        ViewGiaoCa();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }

        #endregion

        #region Sửa giao ca 
        private void btnUpdate_CTPGC_Click(object sender, EventArgs e)
        {
            if (txtMaGiaoCaCgc.Text == "" || txtMaMatHangCgc.Text == "" || txtSoLuongCgc.Text == "")
            {
                if (txtMaGiaoCaCgc.Text == "")
                    errorProvider1.SetError(txtMaGiaoCaCgc, "Chưa nhập mã giao ca");
                if (txtMaMatHangCgc.Text == "")
                    errorProvider1.SetError(txtMaMatHangCgc, "Chưa nhập mã mặt hàng");
                if (txtSoLuongCgc.Text == "")
                    errorProvider1.SetError(txtSoLuongCgc, "Chưa nhập số lượng mặt hàng");
                MessageBox.Show("Nhập thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                int stt = (int)Convert.ToInt32(txtSTTCgc.Text);
                string maquay = txtMaGiaoCaCgc.Text;
                string mamathang = txtMaMatHangCgc.Text;
                int sl = (int)Convert.ToInt32(txtSoLuongCgc.Text);
                if (MessageBox.Show("Bạn có muốn sửa hay không", "sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (CTGiaoCaController.Instance.UpdateCtGiaoCa(stt, maquay, mamathang, sl))
                    {
                        MessageBox.Show("Sửa thành công!");
                        ViewGiaoCa();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }

        #endregion

        #region Xoá giao ca  
        private void btnDelete_CTPGC_Click(object sender, EventArgs e)
        {
            if (txtSTTCgc.Text == "")
            {
                errorProvider1.SetError(txtSTTCgc, "Nhập stt cần xóa");
                MessageBox.Show("Nhập vào số thứ tự cần xóa");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            int stt = 0;
            stt = (int)Convert.ToInt32(txtSTTCgc.Text);
            if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (CTGiaoCaController.Instance.DeleteCtGiaoCa(stt))
                {
                    MessageBox.Show("Thêm thành công!");
                    ViewGiaoCa();
                }
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }

        #endregion

        #region Tìm kiếm 
        private void btnSearch_CTPGC_Click(object sender, EventArgs e)
        {
            if (txtMaGiaoCaCgc.Text == "" && txtMaMatHangCgc.Text == "")
            {
                if (txtMaGiaoCaCgc.Text == "")
                    errorProvider1.SetError(txtMaGiaoCaCgc, "Nhập mã giao ca cần tìm");
                if (txtMaMatHangCgc.Text == "")
                    errorProvider1.SetError(txtMaMatHangCgc, "Nhập mã mặt hàng cần tìm");
                MessageBox.Show("Nhập thông tin cần tìm");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            dgvCtGiaoCa.DataSource = CTGiaoCaController.Instance.SearchCtGiaoCa(txtMaGiaoCaCgc.Text, txtMaMatHangCgc.Text);
        }

        #endregion

        #region Thoát 
        private void btnExit_CTPGC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

#endregion


    }
}
