
namespace UngDungThiTracNghiem
{
    partial class frmAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCâuHỏiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNgayKT = new System.Windows.Forms.DateTimePicker();
            this.btnLayDuLieu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbLuotThi = new System.Windows.Forms.Label();
            this.lbDau = new System.Windows.Forms.Label();
            this.lbTruot = new System.Windows.Forms.Label();
            this.lbTB = new System.Windows.Forms.Label();
            this.lbCao = new System.Windows.Forms.Label();
            this.lbThiSinh = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.clickThoat);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýCâuHỏiToolStripMenuItem,
            this.lịchSửThiToolStripMenuItem});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.clickTaiKhoan);
            // 
            // quảnLýCâuHỏiToolStripMenuItem
            // 
            this.quảnLýCâuHỏiToolStripMenuItem.Name = "quảnLýCâuHỏiToolStripMenuItem";
            this.quảnLýCâuHỏiToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.quảnLýCâuHỏiToolStripMenuItem.Text = "Quản lý câu hỏi";
            this.quảnLýCâuHỏiToolStripMenuItem.Click += new System.EventHandler(this.clickCauHoi);
            // 
            // lịchSửThiToolStripMenuItem
            // 
            this.lịchSửThiToolStripMenuItem.Name = "lịchSửThiToolStripMenuItem";
            this.lịchSửThiToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.lịchSửThiToolStripMenuItem.Text = "Xem lịch sử thi";
            this.lịchSửThiToolStripMenuItem.Click += new System.EventHandler(this.clickLichSu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Người dùng";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AllowDrop = true;
            this.lbHoTen.Location = new System.Drawing.Point(543, 72);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbHoTen.Size = new System.Drawing.Size(235, 51);
            this.lbHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "BÁO CÁO TỔNG HỢP";
            // 
            // dateNgayBD
            // 
            this.dateNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dateNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayBD.Location = new System.Drawing.Point(147, 201);
            this.dateNgayBD.Name = "dateNgayBD";
            this.dateNgayBD.Size = new System.Drawing.Size(200, 22);
            this.dateNgayBD.TabIndex = 5;
            this.dateNgayBD.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đến";
            // 
            // dateNgayKT
            // 
            this.dateNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dateNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayKT.Location = new System.Drawing.Point(407, 201);
            this.dateNgayKT.Name = "dateNgayKT";
            this.dateNgayKT.Size = new System.Drawing.Size(200, 22);
            this.dateNgayKT.TabIndex = 8;
            // 
            // btnLayDuLieu
            // 
            this.btnLayDuLieu.Location = new System.Drawing.Point(628, 198);
            this.btnLayDuLieu.Name = "btnLayDuLieu";
            this.btnLayDuLieu.Size = new System.Drawing.Size(115, 25);
            this.btnLayDuLieu.TabIndex = 10;
            this.btnLayDuLieu.Text = "Lấy dữ liệu";
            this.btnLayDuLieu.UseVisualStyleBackColor = true;
            this.btnLayDuLieu.Click += new System.EventHandler(this.btnLayDuLieu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lượt thi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ĐIểm trung bình";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Điểm cao nhất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(116, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Thí sinh có điểm cao nhất:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(366, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Số lượng đậu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(598, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số lượng trượt:";
            // 
            // lbLuotThi
            // 
            this.lbLuotThi.AutoSize = true;
            this.lbLuotThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuotThi.Location = new System.Drawing.Point(192, 265);
            this.lbLuotThi.Name = "lbLuotThi";
            this.lbLuotThi.Size = new System.Drawing.Size(0, 20);
            this.lbLuotThi.TabIndex = 17;
            // 
            // lbDau
            // 
            this.lbDau.AutoSize = true;
            this.lbDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDau.Location = new System.Drawing.Point(483, 265);
            this.lbDau.Name = "lbDau";
            this.lbDau.Size = new System.Drawing.Size(0, 20);
            this.lbDau.TabIndex = 18;
            // 
            // lbTruot
            // 
            this.lbTruot.AutoSize = true;
            this.lbTruot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTruot.Location = new System.Drawing.Point(743, 265);
            this.lbTruot.Name = "lbTruot";
            this.lbTruot.Size = new System.Drawing.Size(0, 20);
            this.lbTruot.TabIndex = 19;
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.Location = new System.Drawing.Point(262, 304);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(0, 20);
            this.lbTB.TabIndex = 20;
            // 
            // lbCao
            // 
            this.lbCao.AutoSize = true;
            this.lbCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCao.Location = new System.Drawing.Point(262, 339);
            this.lbCao.Name = "lbCao";
            this.lbCao.Size = new System.Drawing.Size(0, 20);
            this.lbCao.TabIndex = 21;
            // 
            // lbThiSinh
            // 
            this.lbThiSinh.AutoSize = true;
            this.lbThiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThiSinh.Location = new System.Drawing.Point(345, 374);
            this.lbThiSinh.Name = "lbThiSinh";
            this.lbThiSinh.Size = new System.Drawing.Size(0, 20);
            this.lbThiSinh.TabIndex = 22;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(833, 449);
            this.Controls.Add(this.lbThiSinh);
            this.Controls.Add(this.lbCao);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.lbTruot);
            this.Controls.Add(this.lbDau);
            this.Controls.Add(this.lbLuotThi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLayDuLieu);
            this.Controls.Add(this.dateNgayKT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateNgayBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCâuHỏiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửThiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgayBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateNgayKT;
        private System.Windows.Forms.Button btnLayDuLieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbLuotThi;
        private System.Windows.Forms.Label lbDau;
        private System.Windows.Forms.Label lbTruot;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Label lbCao;
        private System.Windows.Forms.Label lbThiSinh;
    }
}