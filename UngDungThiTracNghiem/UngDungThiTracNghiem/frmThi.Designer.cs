
namespace UngDungThiTracNghiem
{
    partial class frmThi
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
            this.components = new System.ComponentModel.Container();
            this.lbCau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.pictureHinhAnh = new System.Windows.Forms.PictureBox();
            this.rdDapAn1 = new System.Windows.Forms.RadioButton();
            this.rdDapAn4 = new System.Windows.Forms.RadioButton();
            this.rdDapAn3 = new System.Windows.Forms.RadioButton();
            this.rdDapAn2 = new System.Windows.Forms.RadioButton();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnNop = new System.Windows.Forms.Button();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbCauHoi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCau
            // 
            this.lbCau.AutoSize = true;
            this.lbCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCau.Location = new System.Drawing.Point(33, 106);
            this.lbCau.Name = "lbCau";
            this.lbCau.Size = new System.Drawing.Size(71, 20);
            this.lbCau.TabIndex = 0;
            this.lbCau.Text = "Câu hỏi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(995, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Người dùng";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AllowDrop = true;
            this.lbHoTen.Location = new System.Drawing.Point(844, 26);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbHoTen.Size = new System.Drawing.Size(235, 62);
            this.lbHoTen.TabIndex = 4;
            // 
            // pictureHinhAnh
            // 
            this.pictureHinhAnh.Location = new System.Drawing.Point(120, 305);
            this.pictureHinhAnh.Name = "pictureHinhAnh";
            this.pictureHinhAnh.Size = new System.Drawing.Size(331, 219);
            this.pictureHinhAnh.TabIndex = 6;
            this.pictureHinhAnh.TabStop = false;
            // 
            // rdDapAn1
            // 
            this.rdDapAn1.AutoSize = true;
            this.rdDapAn1.Location = new System.Drawing.Point(495, 322);
            this.rdDapAn1.Name = "rdDapAn1";
            this.rdDapAn1.Size = new System.Drawing.Size(110, 21);
            this.rdDapAn1.TabIndex = 7;
            this.rdDapAn1.TabStop = true;
            this.rdDapAn1.Text = "radioButton1";
            this.rdDapAn1.UseVisualStyleBackColor = true;
            this.rdDapAn1.CheckedChanged += new System.EventHandler(this.rdDapAn1_CheckedChanged);
            // 
            // rdDapAn4
            // 
            this.rdDapAn4.AutoSize = true;
            this.rdDapAn4.Location = new System.Drawing.Point(495, 503);
            this.rdDapAn4.Name = "rdDapAn4";
            this.rdDapAn4.Size = new System.Drawing.Size(110, 21);
            this.rdDapAn4.TabIndex = 8;
            this.rdDapAn4.TabStop = true;
            this.rdDapAn4.Text = "radioButton2";
            this.rdDapAn4.UseVisualStyleBackColor = true;
            this.rdDapAn4.CheckedChanged += new System.EventHandler(this.rdDapAn4_CheckedChanged);
            // 
            // rdDapAn3
            // 
            this.rdDapAn3.AutoSize = true;
            this.rdDapAn3.Location = new System.Drawing.Point(495, 443);
            this.rdDapAn3.Name = "rdDapAn3";
            this.rdDapAn3.Size = new System.Drawing.Size(110, 21);
            this.rdDapAn3.TabIndex = 9;
            this.rdDapAn3.TabStop = true;
            this.rdDapAn3.Text = "radioButton3";
            this.rdDapAn3.UseVisualStyleBackColor = true;
            this.rdDapAn3.CheckedChanged += new System.EventHandler(this.rdDapAn3_CheckedChanged);
            // 
            // rdDapAn2
            // 
            this.rdDapAn2.AutoSize = true;
            this.rdDapAn2.Location = new System.Drawing.Point(495, 382);
            this.rdDapAn2.Name = "rdDapAn2";
            this.rdDapAn2.Size = new System.Drawing.Size(110, 21);
            this.rdDapAn2.TabIndex = 10;
            this.rdDapAn2.TabStop = true;
            this.rdDapAn2.Text = "radioButton4";
            this.rdDapAn2.UseVisualStyleBackColor = true;
            this.rdDapAn2.CheckedChanged += new System.EventHandler(this.rdDapAn2_CheckedChanged);
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(955, 567);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(121, 33);
            this.btnSau.TabIndex = 11;
            this.btnSau.Text = "Câu sau >>";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(835, 567);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(114, 33);
            this.btnTruoc.TabIndex = 12;
            this.btnTruoc.Text = "<< Câu trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnNop
            // 
            this.btnNop.Location = new System.Drawing.Point(484, 606);
            this.btnNop.Name = "btnNop";
            this.btnNop.Size = new System.Drawing.Size(121, 33);
            this.btnNop.TabIndex = 13;
            this.btnNop.Text = "Nộp bài";
            this.btnNop.UseVisualStyleBackColor = true;
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(510, 23);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(0, 29);
            this.lbThoiGian.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.BackColor = System.Drawing.SystemColors.Window;
            this.lbCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauHoi.Location = new System.Drawing.Point(120, 106);
            this.lbCauHoi.Multiline = true;
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.ReadOnly = true;
            this.lbCauHoi.Size = new System.Drawing.Size(956, 178);
            this.lbCauHoi.TabIndex = 15;
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1098, 651);
            this.Controls.Add(this.lbCauHoi);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.btnNop);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.rdDapAn2);
            this.Controls.Add(this.rdDapAn3);
            this.Controls.Add(this.rdDapAn4);
            this.Controls.Add(this.rdDapAn1);
            this.Controls.Add(this.pictureHinhAnh);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCau);
            this.Name = "frmThi";
            this.Text = "Thi";
            this.Load += new System.EventHandler(this.onLoading);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.PictureBox pictureHinhAnh;
        private System.Windows.Forms.RadioButton rdDapAn1;
        private System.Windows.Forms.RadioButton rdDapAn4;
        private System.Windows.Forms.RadioButton rdDapAn3;
        private System.Windows.Forms.RadioButton rdDapAn2;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnNop;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox lbCauHoi;
    }
}