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

        private void HangHoa_Load(object sender, EventArgs e)
        {

        }

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
        #region view phiếu xuất kho
        private void btnView_XK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewXuatKho();
        }
        void ViewXuatKho()
        {
            dgvXK.DataSource = XuatKhoController.Instance.XemXuatKho();
            dgvXK.Columns["ma"].HeaderText = @"Mã xk";
            dgvXK.Columns["ma"].Width = 140;
            dgvXK.Columns["makhohang"].HeaderText = @"Mã kho hàng";
            dgvXK.Columns["makhohang"].Width = 140;
            dgvXK.Columns["ngayxuat"].HeaderText = @"Ngày xuất";
            dgvXK.Columns["ngayxuat"].Width = 140;
            dgvXK.Columns["tonggiatri"].HeaderText = @"Tổng giá trị";
            dgvXK.Columns["tonggiatri"].Width = 160;
            dgvXK.Columns["maquay"].HeaderText = @"Mã quầy";
            dgvXK.Columns["maquay"].Width = 140;
            dgvXK.Columns["manhanvien"].HeaderText = @"Mã nv";
            dgvXK.Columns["manhanvien"].Width = 140;
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
        #region xoa phiếu xuất kho
        private void btnDelete_XK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void btnExit_XK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
