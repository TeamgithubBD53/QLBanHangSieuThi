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
    public partial class ChiTiet_XuatKho : Form
    {
        public ChiTiet_XuatKho()
        {
            InitializeComponent();
        }

        private void btnSearch_CTXK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewCtXuatKho();
        }
        void ViewCtXuatKho()
        {
            dgvCtXuatKho.DataSource = CtXuatKhoController.Instance.XemCtXuatKho();
            dgvCtXuatKho.Columns["stt"].Width = 45;
            dgvCtXuatKho.Columns["maxuat"].HeaderText = @"Mã xuất";
            dgvCtXuatKho.Columns["maxuat"].Width = 80;
            dgvCtXuatKho.Columns["mamathang"].HeaderText = @"Mã mặt hàng";
            dgvCtXuatKho.Columns["mamathang"].Width = 80;
            dgvCtXuatKho.Columns["soluong"].HeaderText = @"Số lượng";
            dgvCtXuatKho.Columns["soluong"].Width = 80;
            dgvCtXuatKho.Columns["dongia"].HeaderText = @"Đơng giá";
            dgvCtXuatKho.Columns["dongia"].Width = 80;
        }

        private void btnInsert_CTXK_Click(object sender, EventArgs e)
        {

            if (cbMaXuat.Text == "" || cbMaMatHang.Text == "" || txtSoLuong.Text == "")
            {
                if (cbMaXuat.Text == "")
                    errorProvider1.SetError(cbMaXuat, "Chưa có mã xuất");
                if (cbMaMatHang.Text == "")
                    errorProvider1.SetError(cbMaMatHang, "Chưa có mã mặt hàng");
                if (txtSoLuong.Text == "")
                    errorProvider1.SetError(txtSoLuong, "Chưa nhập số lượng");
                MessageBox.Show("Chưa có thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                int sl = (int)Convert.ToInt32(txtSoLuong.Text);
                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (CtXuatKhoController.Instance.InsertCtXuat(cbMaXuat.Text, cbMaMatHang.Text, sl))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewCtXuatKho();
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

        private void btnUpdate_CTXK_Click(object sender, EventArgs e)
        {
            if (txtSTT.Text == "" || cbMaXuat.Text == "" || cbMaMatHang.Text == "" || txtSoLuong.Text == "")
            {
                if (txtSTT.Text == "")
                    errorProvider1.SetError(txtSTT, "Chưa có stt cần sửa");
                if (cbMaXuat.Text == "")
                    errorProvider1.SetError(cbMaXuat, "Chưa có mã xuất");
                if (cbMaMatHang.Text == "")
                    errorProvider1.SetError(cbMaMatHang, "Chưa có mã mặt hàng");
                if (txtSoLuong.Text == "")
                    errorProvider1.SetError(txtSoLuong, "Chưa nhập số lượng");
                MessageBox.Show("Chưa có thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                int stt = (int)Convert.ToInt32(txtSTT.Text);
                int sl = (int)Convert.ToInt32(txtSoLuong.Text);
                if (MessageBox.Show("Bạn có muốn sửa hay không", "sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (CtXuatKhoController.Instance.UpdateCtXuat(stt, cbMaXuat.Text, cbMaMatHang.Text, sl))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewCtXuatKho();
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

        private void btnDelete_CTXK_Click(object sender, EventArgs e)
        {
            if (txtSTT.Text == "")
            {
                errorProvider1.SetError(txtSTT, "Chưa có stt cần xóa");
                MessageBox.Show("Nhập vào stt cần xóa");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                int stt = (int)Convert.ToInt32(txtSTT.Text);
                if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (CtXuatKhoController.Instance.DeleteCtXuat(stt))
                    {
                        MessageBox.Show("Xóa thành công");
                        ViewCtXuatKho();
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
    }
}
