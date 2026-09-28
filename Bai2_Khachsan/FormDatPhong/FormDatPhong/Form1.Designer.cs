namespace FormDatPhong
{
    partial class FormDatPhong
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
            txtHoTen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCCCD = new TextBox();
            label3 = new Label();
            txtNgayNhan = new TextBox();
            label4 = new Label();
            txtNgayTra = new TextBox();
            label5 = new Label();
            txtSoNguoiLon = new TextBox();
            label6 = new Label();
            txtSoTreEm = new TextBox();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(336, 51);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(222, 27);
            txtHoTen.TabIndex = 0;
            txtHoTen.Validating += txtHoTen_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 51);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 1;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 96);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 2;
            label2.Text = "CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(336, 96);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(222, 27);
            txtCCCD.TabIndex = 3;
            txtCCCD.Validating += txtCCCD_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(205, 143);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 4;
            label3.Text = "Ngày nhận:";
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(336, 143);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(222, 27);
            txtNgayNhan.TabIndex = 5;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(205, 190);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 6;
            label4.Text = "Ngày trả:";
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(336, 190);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(222, 27);
            txtNgayTra.TabIndex = 7;
            txtNgayTra.Validating += txtNgayTra_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(205, 238);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 8;
            label5.Text = "Số người lớn:";
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(336, 238);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(222, 27);
            txtSoNguoiLon.TabIndex = 9;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(205, 285);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 10;
            label6.Text = "Số trẻ em:";
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(336, 285);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(222, 27);
            txtSoTreEm.TabIndex = 11;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            // 
            // btnDatPhong
            // 
            btnDatPhong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatPhong.Location = new Point(336, 340);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(110, 35);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = true;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoTreEm);
            Controls.Add(label6);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(label5);
            Controls.Add(txtNgayTra);
            Controls.Add(label4);
            Controls.Add(txtNgayNhan);
            Controls.Add(label3);
            Controls.Add(txtCCCD);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Name = "FormDatPhong";
            Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private Label label1;
        private Label label2;
        private TextBox txtCCCD;
        private Label label3;
        private TextBox txtNgayNhan;
        private Label label4;
        private TextBox txtNgayTra;
        private Label label5;
        private TextBox txtSoNguoiLon;
        private Label label6;
        private TextBox txtSoTreEm;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
