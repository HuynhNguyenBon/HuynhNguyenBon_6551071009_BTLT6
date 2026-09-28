namespace NoteManager
{
    partial class FormGhiChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtTieuDe = new TextBox();
            label2 = new Label();
            txtNoiDung = new TextBox();
            label3 = new Label();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 15);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Tiêu đề:";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(144, 16);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(535, 27);
            txtTieuDe.TabIndex = 1;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 71);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(58, 113);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(621, 194);
            txtNoiDung.TabIndex = 3;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 327);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 4;
            label3.Text = "Mức độ ưu tiên:";
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.Location = new Point(58, 369);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(151, 28);
            cboMucDoUuTien.TabIndex = 5;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuuGhiChu.Location = new Point(548, 362);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(131, 37);
            btnLuuGhiChu.TabIndex = 6;
            btnLuuGhiChu.Text = "Lưu ghi chú";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(label3);
            Controls.Add(txtNoiDung);
            Controls.Add(label2);
            Controls.Add(txtTieuDe);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "FormGhiChu";
            Text = "Ghi chú mới";
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTieuDe;
        private Label label2;
        private TextBox txtNoiDung;
        private Label label3;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;
    }
}