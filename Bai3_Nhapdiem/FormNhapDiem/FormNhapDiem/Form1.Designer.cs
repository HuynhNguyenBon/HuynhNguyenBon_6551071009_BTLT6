namespace FormNhapDiem
{
    partial class FormNhapDiem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtMaHS = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label3 = new Label();
            txtToan = new TextBox();
            label4 = new Label();
            txtVan = new TextBox();
            label5 = new Label();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã học sinh:";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(48, 77);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(125, 27);
            txtMaHS.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 35);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 2;
            label2.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(200, 77);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 35);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 4;
            label3.Text = "Điểm Toán:";
            // 
            // txtToan
            // 
            txtToan.Location = new Point(349, 77);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(125, 27);
            txtToan.TabIndex = 2;
            txtToan.TextChanged += txtToan_TextChanged;
            txtToan.Enter += txtToan_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(509, 35);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 6;
            label4.Text = "Điểm Văn:";
            // 
            // txtVan
            // 
            txtVan.Location = new Point(509, 77);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(125, 27);
            txtVan.TabIndex = 3;
            txtVan.Enter += txtVan_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(655, 35);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 8;
            label5.Text = "Điểm Anh:";
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(655, 77);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(125, 27);
            txtAnh.TabIndex = 4;
            txtAnh.Enter += txtAnh_Enter;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(128, 255, 128);
            btnLuu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(48, 127);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 34);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTrang.Location = new Point(186, 127);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(124, 34);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(48, 188);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(732, 244);
            lstKetQua.TabIndex = 12;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(label5);
            Controls.Add(txtVan);
            Controls.Add(label4);
            Controls.Add(txtToan);
            Controls.Add(label3);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(txtMaHS);
            Controls.Add(label1);
            Name = "FormNhapDiem";
            Text = "Nhập điểm học sinh";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaHS;
        private Label label2;
        private TextBox txtHoTen;
        private Label label3;
        private TextBox txtToan;
        private Label label4;
        private TextBox txtVan;
        private Label label5;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
        private ErrorProvider errorProvider1;
    }
}
