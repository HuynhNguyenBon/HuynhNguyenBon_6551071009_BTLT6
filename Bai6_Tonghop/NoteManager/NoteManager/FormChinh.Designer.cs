namespace NoteManager
{
    partial class FormChinh
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
            menuStrip1 = new MenuStrip();
            mnuTep = new ToolStripMenuItem();
            mnuMoGhiChu = new ToolStripMenuItem();
            mnuSapXep = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuCuaSo = new ToolStripMenuItem();
            mnuXepTang = new ToolStripMenuItem();
            mnuXepNgang = new ToolStripMenuItem();
            mnuXepDoc = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblSoLuongGhiChu = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTep, mnuCuaSo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuTep
            // 
            mnuTep.DropDownItems.AddRange(new ToolStripItem[] { mnuMoGhiChu, mnuSapXep, mnuThoat });
            mnuTep.Name = "mnuTep";
            mnuTep.Size = new Size(48, 24);
            mnuTep.Text = "Tệp";
            // 
            // mnuMoGhiChu
            // 
            mnuMoGhiChu.Name = "mnuMoGhiChu";
            mnuMoGhiChu.Size = new Size(224, 26);
            mnuMoGhiChu.Text = "Mở ghi chú mới";
            mnuMoGhiChu.Click += mnuMoGhiChu_Click;
            // 
            // mnuSapXep
            // 
            mnuSapXep.Name = "mnuSapXep";
            mnuSapXep.Size = new Size(224, 26);
            mnuSapXep.Text = "Sắp xếp cửa sổ";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(224, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += this.mnuThoat_Click;
            // 
            // mnuCuaSo
            // 
            mnuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuXepTang, mnuXepNgang, mnuXepDoc });
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new Size(68, 24);
            mnuCuaSo.Text = "Cửa sổ";
            // 
            // mnuXepTang
            // 
            mnuXepTang.Name = "mnuXepTang";
            mnuXepTang.Size = new Size(224, 26);
            mnuXepTang.Text = "Xếp tầng";
            mnuXepTang.Click += mnuXepTang_Click;
            // 
            // mnuXepNgang
            // 
            mnuXepNgang.Name = "mnuXepNgang";
            mnuXepNgang.Size = new Size(224, 26);
            mnuXepNgang.Text = "Xếp ngang";
            mnuXepNgang.Click += mnuXepNgang_Click;
            // 
            // mnuXepDoc
            // 
            mnuXepDoc.Name = "mnuXepDoc";
            mnuXepDoc.Size = new Size(224, 26);
            mnuXepDoc.Text = "Xếp dọc";
            mnuXepDoc.Click += mnuXepDoc_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoLuongGhiChu });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSoLuongGhiChu
            // 
            lblSoLuongGhiChu.Name = "lblSoLuongGhiChu";
            lblSoLuongGhiChu.Size = new Size(157, 20);
            lblSoLuongGhiChu.Text = "Số ghi chú đang mở: 0";
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormChinh";
            Text = "Quản lý ghi chú";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuTep;
        private ToolStripMenuItem mnuMoGhiChu;
        private ToolStripMenuItem mnuSapXep;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuCuaSo;
        private ToolStripMenuItem mnuXepTang;
        private ToolStripMenuItem mnuXepNgang;
        private ToolStripMenuItem mnuXepDoc;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSoLuongGhiChu;
    }
}
