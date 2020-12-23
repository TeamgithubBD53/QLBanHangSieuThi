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
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }

        #region menustrip

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuTrangChu_Click(object sender, EventArgs e)
        {
            TrangChu f = new TrangChu();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }


        #endregion


        private void HangHoa_Load(object sender, EventArgs e)
        {

        }
        #region View kho hàng
        private void btnView_KH_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewKhoHang();
        }
        void ViewKhoHang()
        {
            dgvKhoHang.DataSource = KhoHangController.Instance.XemKhoHang();
            dgvKhoHang.Columns["ma"].HeaderText = @"Mã kho";
            dgvKhoHang.Columns["ma"].Width = 80;
            dgvKhoHang.Columns["ten"].HeaderText = @"Tên kho";
            dgvKhoHang.Columns["ten"].Width = 200;
            dgvKhoHang.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvKhoHang.Columns["diachi"].Width = 200;
        }

        private void dgvKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKho.Text = dgvKhoHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKho.Text = dgvKhoHang.CurrentRow.Cells[1].Value.ToString();
            rtbDiaChiKho.Text = dgvKhoHang.CurrentRow.Cells[2].Value.ToString();
        }
        #endregion
        #region thêm kho hàng
        private void btnInsert_KH_Click(object sender, EventArgs e)
        {
            if(txtMaKho.Text ==""||txtTenKho.Text==""||rtbDiaChiKho.Text=="")
            {
                if (txtMaKho.Text == "")
                    errorProvider1.SetError(txtMaKho, "Chưa có mã kho");
                if (txtTenKho.Text == "")
                    errorProvider1.SetError(txtTenKho, "Chưa có tên kho");
                if (rtbDiaChiKho.Text == "")
                    errorProvider1.SetError(rtbDiaChiKho, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền đầy đủ thông tin");
                return;
            } 
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaKho.Text;
                string ten = txtTenKho.Text;
                string diachi = rtbDiaChiKho.Text;

                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (KhoHangController.Instance.InsertKhoHang(ma, ten, diachi))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewKhoHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
        #region sửa kho hàng
        private void btnUpdate_KH_Click(object sender, EventArgs e)
        {
            if (txtTenKho.Text == "" || rtbDiaChiKho.Text == "")
            {
                if (txtTenKho.Text == "")
                    errorProvider1.SetError(txtTenKho, "Chưa có tên kho");
                if (rtbDiaChiKho.Text == "")
                    errorProvider1.SetError(rtbDiaChiKho, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền thông tin sửa!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaKho.Text;
                string ten = txtTenKho.Text;
                string diachi = rtbDiaChiKho.Text;
                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (KhoHangController.Instance.UpdateKhoHang(ma, ten, diachi))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewKhoHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
        #region xoá kho hàng
        private void btnDelete_KH_Click(object sender, EventArgs e)
        {
            if (txtMaKho.Text == "")
            {
                errorProvider1.SetError(txtMaKho, "Chưa có mã kho cần xóa");
                MessageBox.Show("Phải có mã kho cần xóa");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaKho.Text;
                if (MessageBox.Show("Bạn có muốn xóa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (KhoHangController.Instance.DeleteKhoHang(ma))
                    {
                        MessageBox.Show("Xóa thành công");
                        ViewKhoHang();
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
        #region tìm kiếm
        private void btnSearch_KQ_Click(object sender, EventArgs e)
        {

            if (cbSearch.Text == @"Quầy hàng")
            {
                if (txtMaQuayH.Text == "" && txtTenQuayH.Text == "")
                {
                    if (txtMaQuayH.Text == "")
                        errorProvider1.SetError(txtMaQuayH, "Chưa nhập mã cần tìm");
                    if (txtTenQuayH.Text == "")
                        errorProvider1.SetError(txtTenQuayH, "Chưa nhập tên cần tìm");
                    MessageBox.Show("Phải nhập mã hoặc tên cần tìm");
                }
                else
                {
                    errorProvider1.Clear();
                }
                string ma = txtMaQuayH.Text;
                string ten = txtTenQuayH.Text;
                if (txtMaQuayH.Text != "" || txtTenQuayH.Text != "")
                {
                    dgvQuayHang.DataSource = QuayHangController.Instance.SearchQuayHang(ma, ten);
                }
            }
            else if (cbSearch.Text == @"Kho hàng")
            {
                if (txtMaKho.Text == "" && txtTenKho.Text == "")
                {
                    if (txtMaKho.Text == "")
                        errorProvider1.SetError(txtMaKho, "Chưa nhập mã cần tìm");
                    if (txtTenKho.Text == "")
                        errorProvider1.SetError(txtTenKho, "Chưa nhập tên cần tìm");
                    MessageBox.Show("Phải nhập vào mã hoặc tên cần tìm");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                }
                string ma = txtMaKho.Text;
                string ten = txtTenKho.Text;
                if (txtMaKho.Text != "" || txtTenKho.Text != "")
                {
                    dgvKhoHang.DataSource = KhoHangController.Instance.SearchKhoHang(ma, ten);
                }
            }
        }
        #endregion
        #region  Xem Quầy hàng
        private void btnView_QH_Click(object sender, EventArgs e)
        {
            dgvQuayHang.DataSource = QuayHangController.Instance.XemQuayHang();
            dgvQuayHang.Columns["ma"].HeaderText = @"Mã quầy";
            dgvQuayHang.Columns["ma"].Width = 70;
            dgvQuayHang.Columns["ten"].HeaderText = @"Tên quầy";
            dgvQuayHang.Columns["ten"].Width = 150;
            dgvQuayHang.Columns["vitri"].HeaderText = @"Vị trí";
            dgvQuayHang.Columns["vitri"].Width = 150;
        }

        void ViewQuayHang()
        {
            dgvQuayHang.DataSource = QuayHangController.Instance.XemQuayHang();
            dgvQuayHang.Columns["ma"].HeaderText = @"Mã quầy";
            dgvQuayHang.Columns["ma"].Width = 70;
            dgvQuayHang.Columns["ten"].HeaderText = @"Tên quầy";
            dgvQuayHang.Columns["ten"].Width = 150;
            dgvQuayHang.Columns["vitri"].HeaderText = @"Vị trí";
            dgvQuayHang.Columns["vitri"].Width = 150;
        }
        #endregion

        private void dgvQuayHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaQuayH.Text = dgvQuayHang.CurrentRow.Cells[0].Value.ToString();
            txtTenQuayH.Text = dgvQuayHang.CurrentRow.Cells[1].Value.ToString();
            rtbViTriQh.Text = dgvQuayHang.CurrentRow.Cells[2].Value.ToString();
        }
        #region thêm quầy hàng
        private void btnInsert_QH_Click(object sender, EventArgs e)
        {
            if (txtMaQuayH.Text == "" || txtTenQuayH.Text == "" || rtbViTriQh.Text == "")
            {
                if (txtMaQuayH.Text == "")
                    errorProvider1.SetError(txtMaQuayH, "Chưa có mã quầy");
                if (txtTenQuayH.Text == "")
                    errorProvider1.SetError(txtTenQuayH, "Chưa có tên quầy");
                if (rtbViTriQh.Text == "")
                    errorProvider1.SetError(rtbViTriQh, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền thông tin đầy đủ!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaQuayH.Text;
                string ten = txtTenQuayH.Text;
                string vitri = rtbViTriQh.Text;

                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (QuayHangController.Instance.InsertQuayHang(ma, ten, vitri))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewQuayHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
        #region sử quầy hàng
        private void btnUpdate_QH_Click(object sender, EventArgs e)
        {
            if (txtTenQuayH.Text == "" || rtbViTriQh.Text == "")
            {
                if (txtTenQuayH.Text == "")
                    errorProvider1.SetError(txtTenQuayH, "Chưa có tên quầy");
                if (rtbViTriQh.Text == "")
                    errorProvider1.SetError(rtbViTriQh, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền thông tin đầy đủ!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaQuayH.Text;
                string ten = txtTenQuayH.Text;
                string vitri = rtbViTriQh.Text;

                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (QuayHangController.Instance.UpdateQuayHang(ma, ten, vitri))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewQuayHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
        #region xoá quầy hàng
        private void btnDelete_QH_Click(object sender, EventArgs e)
        {
            if (txtMaQuayH.Text == "")
            {
                errorProvider1.SetError(txtMaQuayH, "Chưa có mã cần xóa");
                MessageBox.Show("Phải nhập vào mã cần xóa");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaQuayH.Text;
                if (MessageBox.Show("Bạn có muốn xóa hay không", "xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (QuayHangController.Instance.DeleteQuayHang(ma))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewQuayHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion

        private void btnExit_KQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region mặt hàng

        #region View Mặt hàng

        void ViewMatHang()
        {
            dgvMatHang.DataSource = MatHangController.Instance.XemMatHang();
            dgvMatHang.Columns["ma"].HeaderText = @"Mã";
            dgvMatHang.Columns["ma"].Width = 80;
            dgvMatHang.Columns["ten"].HeaderText = @"Tên mặt hàng";
            dgvMatHang.Columns["ten"].Width = 250;
            dgvMatHang.Columns["loaimathang"].HeaderText = @"Loại mặt hàng";
            dgvMatHang.Columns["loaimathang"].Width = 150;
            dgvMatHang.Columns["donvitinh"].HeaderText = @"Đơn vị tính";
            dgvMatHang.Columns["donvitinh"].Width = 80;
            dgvMatHang.Columns["maquay"].HeaderText = @"Mã quầy";
            dgvMatHang.Columns["maquay"].Width = 80;

            dgvMatHang.Columns["manhacc"].Width = 80;
            dgvMatHang.Columns["gia"].Width = 200;
        }
        private void btnView_MH_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewMatHang();
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaHang.Text = dgvMatHang.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvMatHang.CurrentRow.Cells[1].Value.ToString();
            cbLoai.Text = dgvMatHang.CurrentRow.Cells[2].Value.ToString();
            cbDonViTinh.Text = dgvMatHang.CurrentRow.Cells[3].Value.ToString();
            cbMaQuay.Text = dgvMatHang.CurrentRow.Cells[4].Value.ToString();
            txtMaNCC.Text = dgvMatHang.CurrentRow.Cells[5].Value.ToString();
            txtGiaMh.Text = dgvMatHang.CurrentRow.Cells[6].Value.ToString();
        }
        #endregion

        #region Thêm mặt hàng
        private void btnInsert_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" || txtTenHang.Text == "" || cbDonViTinh.Text == "" || cbLoai.Text == "" || txtGiaMh.Text == "" || cbMaQuay.Text == "" || txtMaNCC.Text == "")
            {
                if (txtMaHang.Text == "")
                    errorProvider1.SetError(txtMaHang, "Chưa có mã hàng");
                if (txtTenHang.Text == "")
                    errorProvider1.SetError(txtTenHang, "Chưa có tên hàng");
                if (cbDonViTinh.Text == "")
                    errorProvider1.SetError(cbLoai, "Chưa phân loại hàng");
                if (cbDonViTinh.Text == "")
                    errorProvider1.SetError(cbDonViTinh, "Chưa có đơn vị tính");
                if (cbMaQuay.Text == "")
                    errorProvider1.SetError(cbMaQuay, "Chưa có mã quầy");
                if (txtMaNCC.Text == "")
                    errorProvider1.SetError(txtMaNCC, "Chưa có nhà cung cấp");
                if (txtGiaMh.Text == "")
                    errorProvider1.SetError(txtGiaMh, "Chưa có giá mặt hàng");
                MessageBox.Show("Nhập thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaHang.Text;
                string ten = txtTenHang.Text;
                string loai = cbLoai.Text;
                string donvt = cbDonViTinh.Text;
                string maquay = cbMaQuay.Text;
                string mancc = txtMaNCC.Text;
                float gia = (float)Convert.ToDouble(txtGiaMh.Text);

                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (MatHangController.Instance.InsertMatHang(ma, ten, loai, donvt, maquay, mancc, gia))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewMatHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }

        #endregion

        #region Sửa mặt hàng

        private void btnUpdate_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" || txtTenHang.Text == "" || cbDonViTinh.Text == "" || cbLoai.Text == "" || txtGiaMh.Text == "" || cbMaQuay.Text == "" || txtMaNCC.Text == "")
            {
                if (txtMaHang.Text == "")
                    errorProvider1.SetError(txtMaHang, "Chưa có mã hàng");
                if (txtTenHang.Text == "")
                    errorProvider1.SetError(txtTenHang, "Chưa có tên hàng");
                if (cbDonViTinh.Text == "")
                    errorProvider1.SetError(cbLoai, "Chưa phân loại hàng");
                if (cbDonViTinh.Text == "")
                    errorProvider1.SetError(cbDonViTinh, "Chưa có đơn vị tính");
                if (cbMaQuay.Text == "")
                    errorProvider1.SetError(cbMaQuay, "Chưa có mã quầy");
                if (txtMaNCC.Text == "")
                    errorProvider1.SetError(txtMaNCC, "Chưa có nhà cung cấp");
                if (txtGiaMh.Text == "")
                    errorProvider1.SetError(txtGiaMh, "Chưa có giá mặt hàng");
                MessageBox.Show("Nhập thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaHang.Text;
                string ten = txtTenHang.Text;
                string loai = cbLoai.Text;
                string donvt = cbDonViTinh.Text;
                string maquay = cbMaQuay.Text;
                string mancc = txtMaNCC.Text;
                float gia = (float)Convert.ToDouble(txtGiaMh.Text);

                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (MatHangController.Instance.UpdateMatHang(ma, ten, loai, donvt, maquay, mancc, gia))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewMatHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
        private void btnDelete_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                errorProvider1.SetError(txtMaHang, "Chưa có mã hàng");
                MessageBox.Show("Nhập vào mã cần xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không", "xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (MatHangController.Instance.DeleteMatHang(txtMaHang.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    ViewMatHang();
                }
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }
        }

        private void btnExit_MH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" && txtTenHang.Text == "" && cbLoai.Text == "" && cbMaQuay.Text == "" && txtMaNCC.Text == "")
            {
                if (txtMaHang.Text == "")
                    errorProvider1.SetError(txtMaHang, "Chưa có mã hàng cần tìm");
                if (txtTenHang.Text == "")
                    errorProvider1.SetError(txtTenHang, "Chưa có tên hàng cần tìm");
                if (cbLoai.Text == "")
                    errorProvider1.SetError(cbLoai, "Chưa có loại sản phẩm cần tìm");
                if (cbMaQuay.Text == "")
                    errorProvider1.SetError(cbMaQuay, "Chưa có mã quầy cần tìm");
                if (txtMaNCC.Text == "")
                    errorProvider1.SetError(txtMaNCC, "Chưa có mã nhà cung cấp cần tìm");
                MessageBox.Show("Nhập vào thông tin cần tìm");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            dgvMatHang.DataSource = MatHangController.Instance.SearchMatHang(txtMaHang.Text, txtTenHang.Text, cbLoai.Text, cbMaQuay.Text, txtMaNCC.Text);
        }
        #endregion

        #region Nhà cung cấp

        #region View Nhà cung cấp

        void ViewNhaSanXuat()
        {
            dgvNSX.DataSource = NhaCCController.Instance.XemNhaCC();
            dgvNSX.Columns["ma"].HeaderText = @"Mã ncc";
            dgvNSX.Columns["ma"].Width = 80;
            dgvNSX.Columns["ten"].HeaderText = @"Tên ncc";
            dgvNSX.Columns["ten"].Width = 200;
            dgvNSX.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvNSX.Columns["diachi"].Width = 300;
            dgvNSX.Columns["sodienthoai"].HeaderText = @"Số điện thoại";
            dgvNSX.Columns["sodienthoai"].Width = 150;
            dgvNSX.Columns["email"].HeaderText = @"Email";
            dgvNSX.Columns["email"].Width = 200;
        }
        private void btnView_NSX_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewNhaSanXuat();
        }

        private void dgvNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNCC.Text = dgvNSX.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNSX.CurrentRow.Cells[1].Value.ToString();
            txtDiaChiNCC.Text = dgvNSX.CurrentRow.Cells[2].Value.ToString();
            txtDienThoaiNCC.Text = dgvNSX.CurrentRow.Cells[3].Value.ToString();
            txtEmailNCC.Text = dgvNSX.CurrentRow.Cells[4].Value.ToString();
        }

        #endregion

        #region Thêm Nhà cung cấp
        private void btnInsert_NSX_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChiNCC.Text == "" || txtDienThoaiNCC.Text == "" || txtDiaChiNCC.Text == "")
            {
                if (txtNCC.Text == "")
                    errorProvider1.SetError(txtNCC, "Chưa nhập mã nhà cung cấp");
                if (txtTenNCC.Text == "")
                    errorProvider1.SetError(txtTenNCC, "Chưa nhập tên nhà cung cấp");
                if (txtDienThoaiNCC.Text == "")
                    errorProvider1.SetError(txtDienThoaiNCC, "Chưa nhập số điện thoại");
                if (txtEmailNCC.Text == "")
                    errorProvider1.SetError(txtEmailNCC, "Chưa nhập email");
                if (txtDiaChiNCC.Text == "")
                    errorProvider1.SetError(txtDiaChiNCC, "Chưa nhập địa chỉ");
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtNCC.Text;
                string ten = txtTenNCC.Text;
                string sdt = txtDienThoaiNCC.Text;
                string email = txtEmailNCC.Text;
                string diachi = txtDiaChiNCC.Text;
                if (MessageBox.Show("Bạn có muốn Thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (NhaCCController.Instance.InsertNhaCC(ma, ten, diachi, sdt, email))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewNhaSanXuat();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
        }
        #endregion


        #endregion
        #region Xuất kho
        private void btnDetail_XK_Click(object sender, EventArgs e)
        {
            ChiTiet_XuatKho f = new ChiTiet_XuatKho();
            f.ShowDialog();
        }

        #region tìm kiếm phiếu xuất kho
        private void btnSearch_XK_Click(object sender, EventArgs e)
        {
            if (txtMaXk.Text == "" && cbMaKhoHangXk.Text == "" && cbMaNhanVienXk.Text == "" && cbMaQuayXK.Text == "")
            {
                if (txtMaXk.Text == "")
                    errorProvider1.SetError(txtMaXk, "Chưa có mã xuất cần tìm");
                if (cbMaKhoHangXk.Text == "")
                    errorProvider1.SetError(cbMaKhoHangXk, "Chưa có mã kho cần tìm");
                if (cbMaNhanVienXk.Text == "")
                    errorProvider1.SetError(cbMaNhanVienXk, "Chưa có mã nhân viên cần tìm");
                if (cbMaQuayXK.Text == "")
                    errorProvider1.SetError(cbMaQuayXK, "Chưa có mã quầy cần tìm");
                MessageBox.Show("Phải có thông tin cần tìm");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtMaXk.Text != "" || cbMaKhoHangXk.Text != "" || cbMaNhanVienXk.Text != "" || cbMaQuayXK.Text != "")
            {
                dgvXK.DataSource = XuatKhoController.Instance.SearchXuatKho(txtMaXk.Text, cbMaKhoHangXk.Text, cbMaNhanVienXk.Text, cbMaQuayXK.Text);
            }
        }
        #endregion
        #region phiếu xuất kho
        private void btnView_XK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewXuatKho();
        }
        void ViewXuatKho()
        {
            dgvXK.DataSource = XuatKhoController.Instance.XemXuatKho();
            dgvXK.Columns["ma"].HeaderText = @"Mã xuất kho";
            dgvXK.Columns["ma"].Width = 150;
            dgvXK.Columns["makhohang"].HeaderText = @"Mã kho hàng";
            dgvXK.Columns["makhohang"].Width = 170;
            dgvXK.Columns["ngayxuat"].HeaderText = @"Ngày xuất";
            dgvXK.Columns["ngayxuat"].Width = 150;
            dgvXK.Columns["tonggiatri"].HeaderText = @"Tổng giá trị";
            dgvXK.Columns["tonggiatri"].Width = 150;
            dgvXK.Columns["maquay"].HeaderText = @"Mã quầy";
            dgvXK.Columns["maquay"].Width = 120;
            dgvXK.Columns["manhanvien"].HeaderText = @"Mã nv";
            dgvXK.Columns["manhanvien"].Width = 120;
        }

        private void dgvXK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaXk.Text = dgvXK.CurrentRow.Cells[0].Value.ToString();
            dtpNgayLapXk.Text = dgvXK.CurrentRow.Cells[1].Value.ToString();
            txtTongGiaTriXk.Text = dgvXK.CurrentRow.Cells[2].Value.ToString();
            cbMaKhoHangXk.Text = dgvXK.CurrentRow.Cells[3].Value.ToString();
            cbMaNhanVienXk.Text = dgvXK.CurrentRow.Cells[4].Value.ToString();
            cbMaQuayXK.Text = dgvXK.CurrentRow.Cells[5].Value.ToString();
        }
        #endregion
        #region thêm phiếu xuất kho
        private void btnInsert_XK_Click(object sender, EventArgs e)
        {
            if (txtMaXk.Text == "" || cbMaKhoHangXk.Text == "" || cbMaNhanVienXk.Text == "" || cbMaQuayXK.Text == "")
            {
                if (txtMaXk.Text == "")
                    errorProvider1.SetError(txtMaXk, "Chưa có mã xuất kho");
                if (cbMaKhoHangXk.Text == "")
                    errorProvider1.SetError(cbMaKhoHangXk, "Chưa có mã kho hàng");
                if (cbMaNhanVienXk.Text == "")
                    errorProvider1.SetError(cbMaNhanVienXk, "Chưa có mã nhân viên");
                if (cbMaQuayXK.Text == "")
                    errorProvider1.SetError(cbMaQuayXK, "Chưa có mã quầy");
                MessageBox.Show("Phải điề đầy đủ thông tin!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaXk.Text;
                string makh = cbMaKhoHangXk.Text;
                string manv = cbMaNhanVienXk.Text;
                string maquay = cbMaQuayXK.Text;
                DateTime ngaylap = (DateTime)Convert.ToDateTime(dtpNgayLapXk.Value.ToString("MM/dd/yyyy"));
                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (XuatKhoController.Instance.InsertXuatKho(ma, makh, manv, maquay, ngaylap))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewXuatKho();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
        #region sửa phiếu xuất kho
        private void btnUpdate_XK_Click(object sender, EventArgs e)
        {

            if (txtMaXk.Text == "" || cbMaKhoHangXk.Text == "" || cbMaNhanVienXk.Text == "" || cbMaQuayXK.Text == "")
            {
                if (txtMaXk.Text == "")
                    errorProvider1.SetError(txtMaXk, "Chưa có mã xuất kho");
                if (cbMaKhoHangXk.Text == "")
                    errorProvider1.SetError(cbMaKhoHangXk, "Chưa có mã kho hàng");
                if (cbMaNhanVienXk.Text == "")
                    errorProvider1.SetError(cbMaNhanVienXk, "Chưa có mã nhân viên");
                if (cbMaQuayXK.Text == "")
                    errorProvider1.SetError(cbMaQuayXK, "Chưa có mã quầy");
                MessageBox.Show("Phải điề đầy đủ thông tin!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaXk.Text;
                string makh = cbMaKhoHangXk.Text;
                string manv = cbMaNhanVienXk.Text;
                string maquay = cbMaQuayXK.Text;
                DateTime ngaylap = (DateTime)Convert.ToDateTime(dtpNgayLapXk.Value.ToString("MM/dd/yyyy"));
                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (XuatKhoController.Instance.UpdateXuatKho(ma, makh, manv, maquay, ngaylap))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewXuatKho();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
        #region xóa phiếu xuất kho
        private void btnDelete_XK_Click(object sender, EventArgs e)
        {
            if (txtMaXk.Text == "")
            {
                errorProvider1.SetError(txtMaXk, "Chưa có mã cần xóa");
                MessageBox.Show("Bạn phải có mã cần xóa");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (XuatKhoController.Instance.DeleteXuatKho(txtMaXk.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        ViewXuatKho();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion

        private void btnExit_XK_Click(object sender, EventArgs e)
        {
            this.Close();
        }








        #endregion

        private void btnUpdate_NSX_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChiNCC.Text == "" || txtDienThoaiNCC.Text == "" || txtDiaChiNCC.Text == "")
            {
                if (txtNCC.Text == "")
                    errorProvider1.SetError(txtNCC, "Chưa nhập mã nhà cung cấp");
                if (txtTenNCC.Text == "")
                    errorProvider1.SetError(txtTenNCC, "Chưa nhập tên nhà cung cấp");
                if (txtDienThoaiNCC.Text == "")
                    errorProvider1.SetError(txtDienThoaiNCC, "Chưa nhập số điện thoại");
                if (txtEmailNCC.Text == "")
                    errorProvider1.SetError(txtEmailNCC, "Chưa nhập email");
                if (txtDiaChiNCC.Text == "")
                    errorProvider1.SetError(txtDiaChiNCC, "Chưa nhập địa chỉ");
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtNCC.Text;
                string ten = txtTenNCC.Text;
                string sdt = txtDienThoaiNCC.Text;
                string email = txtEmailNCC.Text;
                string diachi = txtDiaChiNCC.Text;
                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (NhaCCController.Instance.UpdateNhaCC(ma, ten, diachi, sdt, email))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewNhaSanXuat();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
        }

        private void btnDelete_NSX_Click(object sender, EventArgs e)
        {
            if (txtNCC.Text == "")
            {
                errorProvider1.SetError(txtNCC, "Chưa có mã cần xóa");
                MessageBox.Show("Nhập mã cần xóa");
                return;
            }
            try
            {
                string ma = txtNCC.Text;
                if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (NhaCCController.Instance.DeleteNhaCC(ma))
                    {
                        MessageBox.Show("Xóa thành công");
                        ViewNhaSanXuat();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }

        private void btnExit_NSX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_NSX_Click(object sender, EventArgs e)
        {
            if (txtNCC.Text == "" && txtTenNCC.Text == "")
            {
                if (txtNCC.Text == "")
                    errorProvider1.SetError(txtNCC, "Chưa có mã cần tìm");
                if (txtTenNCC.Text == "")
                    errorProvider1.SetError(txtTenNCC, "Chưa có tên cần tìm");
                MessageBox.Show("Nhập vào thông tin cần tìm");
                return;
            }
            dgvNSX.DataSource = NhaCCController.Instance.SearchNhaCC(txtNCC.Text, txtTenNCC.Text);
        }
    }
}
