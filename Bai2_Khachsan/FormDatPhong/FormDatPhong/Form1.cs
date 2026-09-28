using System.Drawing;
using System.Globalization;
namespace FormDatPhong
{
    public partial class FormDatPhong : Form
    {
        public FormDatPhong()
        {
            InitializeComponent();
        }

        private void txtHoTen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtHoTen.BackColor = Color.Honeydew;
            if (txtHoTen.Text.Trim() == "")
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtHoTen,
                    "Vui lòng nhập họ tên");

                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtHoTen, "");

                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        private void txtCCCD_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtCCCD.BackColor = Color.Honeydew;
            if (txtCCCD.Text.Length != 12 ||
                !long.TryParse(txtCCCD.Text, out _))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtCCCD,
                    "CCCD phải gồm đúng 12 chữ số");

                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtCCCD, "");

                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayNhan_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtNgayNhan.BackColor = Color.Honeydew;
            DateTime ngayNhan;

            if (!DateTime.TryParseExact(
                txtNgayNhan.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày phải có dạng dd/MM/yyyy");

                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nhận phải từ hôm nay trở đi");

                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtNgayNhan, "");

                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayTra_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtNgayTra.BackColor = Color.Honeydew;
            DateTime ngayTra;
            DateTime ngayNhan;

            if (!DateTime.TryParseExact(
                txtNgayTra.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayTra))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày phải có dạng dd/MM/yyyy");

                txtNgayTra.BackColor = Color.MistyRose;

                return;
            }

            if (!DateTime.TryParseExact(
                txtNgayNhan.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayTra,
                    "Vui lòng nhập ngày nhận hợp lệ trước");

                txtNgayTra.BackColor = Color.MistyRose;

                return;
            }

            if (ngayTra <= ngayNhan)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày trả phải lớn hơn ngày nhận");

                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtNgayTra, "");

                txtNgayTra.BackColor = Color.Honeydew;
            }
        }

        private void txtSoNguoiLon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtSoNguoiLon.BackColor = Color.Honeydew;
            int soNguoiLon;

            if (!int.TryParse(txtSoNguoiLon.Text, out soNguoiLon) ||
                soNguoiLon < 1 ||
                soNguoiLon > 4)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtSoNguoiLon,
                    "Số người lớn phải từ 1 đến 4");

                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtSoNguoiLon, "");

                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        private void txtSoTreEm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtSoTreEm.BackColor = Color.Honeydew;
            int soTreEm;

            if (!int.TryParse(txtSoTreEm.Text, out soTreEm) ||
                soTreEm < 0 ||
                soTreEm > 3)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtSoTreEm,
                    "Số trẻ em phải từ 0 đến 3");

                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtSoTreEm, "");

                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DateTime ngayNhan;
            DateTime ngayTra;

            if (!DateTime.TryParseExact(
                txtNgayNhan.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan))
            {
                return;
            }

            if (!DateTime.TryParseExact(
                txtNgayTra.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayTra))
            {
                return;
            }

            int soDem = (ngayTra - ngayNhan).Days;

            MessageBox.Show(
                "Đặt phòng thành công!\n\n" +
                "Tên khách: " + txtHoTen.Text + "\n" +
                "Số đêm: " + soDem + "\n" +
                "Số người lớn: " + txtSoNguoiLon.Text + "\n" +
                "Số trẻ em: " + txtSoTreEm.Text,
                "Thông tin đặt phòng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
