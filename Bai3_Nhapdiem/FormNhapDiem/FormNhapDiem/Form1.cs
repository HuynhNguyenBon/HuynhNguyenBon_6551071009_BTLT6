namespace FormNhapDiem
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl(
                        (Control)sender,
                        true,
                        true,
                        true,
                        true);
                }
            }
        }

        private void txtToan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtToan_Enter(object sender, EventArgs e)
        {
            txtToan.SelectAll();
        }

        private void txtVan_Enter(object sender, EventArgs e)
        {
            txtVan.SelectAll();
        }

        private void txtAnh_Enter(object sender, EventArgs e)
        {
            txtAnh.SelectAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            decimal diemToan;
            decimal diemVan;
            decimal diemAnh;

            bool hopLe = true;

            errorProvider1.Clear();

            if (!decimal.TryParse(txtToan.Text, out diemToan) ||
                diemToan < 0 ||
                diemToan > 10)
            {
                errorProvider1.SetError(
                    txtToan,
                    "Điểm Toán phải từ 0.0 đến 10.0");

                hopLe = false;
            }

            if (!decimal.TryParse(txtVan.Text, out diemVan) ||
                diemVan < 0 ||
                diemVan > 10)
            {
                errorProvider1.SetError(
                    txtVan,
                    "Điểm Văn phải từ 0.0 đến 10.0");

                hopLe = false;
            }

            if (!decimal.TryParse(txtAnh.Text, out diemAnh) ||
                diemAnh < 0 ||
                diemAnh > 10)
            {
                errorProvider1.SetError(
                    txtAnh,
                    "Điểm Anh phải từ 0.0 đến 10.0");

                hopLe = false;
            }

            if (!hopLe)
            {
                return;
            }

            string dong = txtMaHS.Text + " | "
                        + txtHoTen.Text + " | T:" + txtToan.Text
                        + " V:" + txtVan.Text
                        + " A:" + txtAnh.Text;

            lstKetQua.Items.Add(dong);

            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            txtMaHS.Focus();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider1.Clear();

            txtMaHS.Focus();
        }
    }
}
