using System;
using System.Windows.Forms;

namespace FormDanhBa
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }

        private void FormDanhBa_Load(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "" ||
                txtSDT.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Tên và Số điện thoại",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string lienHe = txtTen.Text + " - " + txtSDT.Text;

            if (_indexDangSua == -1)
            {
                lstLienHe.Items.Add(lienHe);

                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items[_indexDangSua] = lienHe;

                _indexDangSua = -1;

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            txtTen.Clear();
            txtSDT.Clear();
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string lienHe = lstLienHe.SelectedItem.ToString();

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " + lienHe +
                "? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);

                MessageBox.Show(
                    "Xóa thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;

            string lienHe = lstLienHe.SelectedItem.ToString();

            string[] thongTin = lienHe.Split('-');

            txtTen.Text = thongTin[0].Trim();
            txtSDT.Text = thongTin[1].Trim();

            txtTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhBa_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            if (txtTen.Text.Trim() != "" ||
                txtSDT.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (result == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();

                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}