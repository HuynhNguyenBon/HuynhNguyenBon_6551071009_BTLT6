using System.Linq;
namespace FormDangKy
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }
        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            errorProvider1.Clear();

            // Kiểm tra họ tên
            if (txtHoTen.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Vui lòng nhập họ tên");
                hopLe = false;
            }
            else if (txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên phải có ít nhất 3 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // Kiểm tra số điện thoại
            if (txtSDT.Text.Length != 10 ||
                !txtSDT.Text.All(char.IsDigit) ||
                !txtSDT.Text.StartsWith("0"))
            {
                errorProvider1.SetError(
                    txtSDT,
                    "Số điện thoại phải có 10 chữ số và bắt đầu bằng 0");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // Kiểm tra email
            int viTriA = txtEmail.Text.IndexOf("@");
            int viTriCham = txtEmail.Text.IndexOf(".", viTriA + 1);

            if (viTriA <= 0 || viTriCham <= viTriA + 1)
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Email phải có @ và dấu . phía sau @");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // Kiểm tra mật khẩu
            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "Mật khẩu phải có ít nhất 6 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // Kiểm tra xác nhận mật khẩu
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(
                    txtXacNhanMK,
                    "Mật khẩu xác nhận không khớp");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }
            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;

            errorProvider1.Clear();

            this.Close();
        }
    }
}
