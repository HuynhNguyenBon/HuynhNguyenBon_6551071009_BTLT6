namespace FormBanVe
{
    partial class FormChonGhe
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
            lstGhe = new ListBox();
            lblGheDaChon = new Label();
            btnXacNhan = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // lstGhe
            // 
            lstGhe.FormattingEnabled = true;
            lstGhe.Location = new Point(82, 43);
            lstGhe.Name = "lstGhe";
            lstGhe.Size = new Size(626, 244);
            lstGhe.TabIndex = 0;
            lstGhe.SelectedIndexChanged += lstGhe_SelectedIndexChanged;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGheDaChon.Location = new Point(82, 310);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(143, 28);
            lblGheDaChon.TabIndex = 1;
            lblGheDaChon.Text = "Chưa chọn ghế";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.Location = new Point(483, 370);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(109, 35);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBoQua.Location = new Point(598, 370);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(110, 35);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FormChonGhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoQua);
            Controls.Add(btnXacNhan);
            Controls.Add(lblGheDaChon);
            Controls.Add(lstGhe);
            Name = "FormChonGhe";
            Text = "Chọn ghế";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGhe;
        private Label lblGheDaChon;
        private Button btnXacNhan;
        private Button btnBoQua;
    }
}