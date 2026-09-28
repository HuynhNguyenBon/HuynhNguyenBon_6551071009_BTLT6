namespace FormBanVe
{
    partial class FormBanVe
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
            label1 = new Label();
            txtTenKhach = new TextBox();
            label2 = new Label();
            cboPhim = new ComboBox();
            label3 = new Label();
            cboSuatChieu = new ComboBox();
            label4 = new Label();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(45, 72);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(322, 27);
            txtTenKhach.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 111);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 2;
            label2.Text = "Phim:";
            // 
            // cboPhim
            // 
            cboPhim.FormattingEnabled = true;
            cboPhim.Items.AddRange(new object[] { "Doraemon", "Avengers", "Lật Mặt", "Thám Tử Lừng Danh Conan" });
            cboPhim.Location = new Point(45, 152);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(322, 28);
            cboPhim.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 193);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 4;
            label3.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Items.AddRange(new object[] { "09:00", "13:00", "17:00", "20:00" });
            cboSuatChieu.Location = new Point(45, 234);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(322, 28);
            cboSuatChieu.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 284);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 6;
            label4.Text = "Ghế đã chọn:";
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(45, 326);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(322, 27);
            txtGheDaChon.TabIndex = 7;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(173, 386);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(138, 35);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(317, 386);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(139, 35);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(462, 386);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(136, 35);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += this.btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(label4);
            Controls.Add(cboSuatChieu);
            Controls.Add(label3);
            Controls.Add(cboPhim);
            Controls.Add(label2);
            Controls.Add(txtTenKhach);
            Controls.Add(label1);
            Name = "FormBanVe";
            Text = "Bán vé xem phim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenKhach;
        private Label label2;
        private ComboBox cboPhim;
        private Label label3;
        private ComboBox cboSuatChieu;
        private Label label4;
        private TextBox txtGheDaChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
