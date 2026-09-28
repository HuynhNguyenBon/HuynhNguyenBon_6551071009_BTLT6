namespace FormBanVe
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg =
            new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (txtTenKhach.Text.Trim() == "" ||
                cboPhim.Text == "" ||
                cboSuatChieu.Text == "" ||
                txtGheDaChon.Text == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin đặt vé.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show(
                "Đặt vé thành công!\n\n" +
                "Tên khách: " + txtTenKhach.Text + "\n" +
                "Phim: " + cboPhim.Text + "\n" +
                "Suất chiếu: " + cboSuatChieu.Text + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá vé: 75.000đ/vé",
                "Xác nhận đặt vé",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = -1;
            cboSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();
        }
    }
}
