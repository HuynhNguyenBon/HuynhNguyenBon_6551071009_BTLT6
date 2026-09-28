using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NoteManager
{
    public partial class FormGhiChu : Form
    {
        private bool noiDungDaThayDoi = false;
        public FormGhiChu()
        {
            InitializeComponent();
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuuGhiChu.PerformClick();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (noiDungDaThayDoi)
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn có muốn đóng ghi chú này không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNoiDung.Text.Length >= 500 &&
            e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            noiDungDaThayDoi = true;
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text;

            MessageBox.Show(
                "Đã lưu ghi chú",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            noiDungDaThayDoi = false;

        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = SystemColors.Control;
        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            if (txtTieuDe.Text.Trim() == "")
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được để trống.");

                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if (txtTieuDe.Text.Length > 50)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được vượt quá 50 ký tự.");

                txtTieuDe.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtTieuDe, "");
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;

            errorProvider1.SetError(
                txtTieuDe,
                "");
        }
    }
}
