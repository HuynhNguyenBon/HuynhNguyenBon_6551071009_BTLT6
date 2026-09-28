namespace FormDangKy
{
    partial class FormDangKy
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
            txtSDT = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            label5 = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(365, 72);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(257, 27);
            txtHoTen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 71);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 1;
            label1.Text = "Họ tên:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(365, 122);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(257, 27);
            txtSDT.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 122);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 3;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(178, 167);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(365, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 27);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(178, 210);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(365, 211);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(257, 27);
            txtMatKhau.TabIndex = 7;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(365, 258);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(257, 27);
            txtXacNhanMK.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(178, 260);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 9;
            label5.Text = "Xác nhận mật khẩu:";
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.Location = new Point(265, 319);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 33);
            btnDangKy.TabIndex = 10;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(419, 319);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 33);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(label5);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSDT);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Name = "FormDangKy";
            Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private Label label1;
        private TextBox txtSDT;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private Label label5;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
