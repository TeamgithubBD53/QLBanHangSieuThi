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
using bai6quanlysieuthi.Views;
using bai6quanlysieuthi.Bus;
namespace bai6quanlysieuthi.Views
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }


        #region khachhang

        #region xem khách hàng
        private void btnViewKh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewKhachHang();
        }

        void ViewKhachHang()
        {
            dgvKh.DataSource = KhachhangController.Instance.XemKhachHang();
            dgvKh.Columns["ma"].HeaderText = @"Mã";
            dgvKh.Columns["ma"].Width = 80;
            dgvKh.Columns["ten"].HeaderText = @"Họ và tên";
            dgvKh.Columns["ten"].Width = 300;
            dgvKh.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvKh.Columns["diachi"].Width = 180;
            dgvKh.Columns["sodienthoai"].HeaderText = @"Số điện thoại";
            dgvKh.Columns["sodienthoai"].Width = 120;
            dgvKh.Columns["uudai"].HeaderText = @"Ưu đãi";
            dgvKh.Columns["uudai"].Width = 55;
        }

        private void dgvKh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakh.Text = dgvKh.CurrentRow.Cells[0].Value.ToString();
            txtTenkh.Text = dgvKh.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dgvKh.CurrentRow.Cells[2].Value.ToString();
            txtSodt.Text = dgvKh.CurrentRow.Cells[3].Value.ToString();
            txtUudai.Text = dgvKh.CurrentRow.Cells[4].Value.ToString();
        }

        #endregion

        #region thêm khách hàng
        private void btnInsertKh_Click(object sender, EventArgs e)
        {
            if (txtMakh.Text == "" || txtTenkh.Text == "")
            {
                if (txtTenkh.Text == "")
                    errorProvider1.SetError(txtMakh, "Chua co ma khach hang");
                if (txtTenkh.Text == "")
                    errorProvider1.SetError(txtTenkh, "Chưa có tên khách hàng");
                MessageBox.Show("Phải có mã, tên khách hàng");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMakh.Text;
                string ten = txtTenkh.Text;
                string diachi = txtDiachi.Text;
                string sodienthoai = txtSodt.Text;
                float uudai = (float)Convert.ToDouble(txtUudai.Text);
                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (KhachhangController.Instance.InsertKhachHang(ma, ten, diachi, sodienthoai, uudai))
                    {

                        MessageBox.Show("Thêm thành công!");
                        ViewKhachHang();

                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thêm dữ liệu");
                return;
            }
        }
        #endregion

        #region sửa khách hàng
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenkh.Text == "")
            {
                errorProvider1.SetError(txtTenkh, "Chưa có dữ liệu");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {

                string ma = txtMakh.Text;
                string ten = txtTenkh.Text;
                string diachi = txtDiachi.Text;
                string sodienthoai = txtSodt.Text;
                float uudai = (float)Convert.ToDouble(txtUudai.Text);
                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (KhachhangController.Instance.UpdateKhachHang(ma, ten, diachi, sodienthoai, uudai))
                    {
                        MessageBox.Show("Sửa thành công!");
                        ViewKhachHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Chưa có thông tin sửa!");
                return;

            }
        }
        #endregion

        #region xóa khách hàng
        private void btnDeleteKh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string ma = txtMakh.Text;
            if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (KhachhangController.Instance.DeleteKhachHang(ma))
                {
                    MessageBox.Show("Xóa thành công!");
                    ViewKhachHang();
                }
                else
                {
                    MessageBox.Show("Khách đã mua hàng!");
                }
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }
        }
        #endregion

        #region tìm khách hàng
        private void btnSearchKh_Click(object sender, EventArgs e)
        {
            if (cmbSearchKh.Text == @"Mã khách hàng")
            {
                if (txtSearchKh.Text != "")
                {
                    dgvKh.DataSource = KhachhangController.Instance.SearchKh(txtSearchKh.Text);
                }
            }
            else if (cmbSearchKh.Text == @"Số điện thoại")
            {
                if (txtSearchKh.Text != "")
                {
                    dgvKh.DataSource = KhachhangController.Instance.SearchKh1(txtSearchKh.Text);
                }
            }
        }
        #endregion


        #region thoát

        private void btnExitKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

#endregion
    }
}