namespace NoteManager
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }
        private void CapNhatSoLuongGhiChu()
        {
            lblSoLuongGhiChu.Text =
                "Số ghi chú đang mở: " +
                this.MdiChildren.Length;
        }
        private void mnuMoGhiChu_Click(object sender, EventArgs e)
        {
            FormGhiChu frm = new FormGhiChu();

            frm.MdiParent = this;

            frm.FormClosed += Frm_FormClosed;

            frm.Show();

            CapNhatSoLuongGhiChu();
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CapNhatSoLuongGhiChu();
        }
        private void mnuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void mnuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void mnuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
