
namespace UngDungThiTracNghiem
{
    partial class frmCauHoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDung = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtDapAn1 = new System.Windows.Forms.TextBox();
            this.txtDapAn3 = new System.Windows.Forms.TextBox();
            this.txtDapAn2 = new System.Windows.Forms.TextBox();
            this.txtDapAn4 = new System.Windows.Forms.TextBox();
            this.gvCauHoi = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHinhAnh = new System.Windows.Forms.Button();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã câu hỏi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đáp án 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đáp án 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đáp án 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đáp án 4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đáp án đúng:";
            // 
            // cbDung
            // 
            this.cbDung.FormattingEnabled = true;
            this.cbDung.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbDung.Location = new System.Drawing.Point(122, 292);
            this.cbDung.Name = "cbDung";
            this.cbDung.Size = new System.Drawing.Size(202, 24);
            this.cbDung.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 490);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 34);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(122, 27);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(218, 22);
            this.txtMaCH.TabIndex = 9;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(122, 62);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(1164, 57);
            this.txtNoiDung.TabIndex = 10;
            // 
            // txtDapAn1
            // 
            this.txtDapAn1.Location = new System.Drawing.Point(122, 135);
            this.txtDapAn1.Multiline = true;
            this.txtDapAn1.Name = "txtDapAn1";
            this.txtDapAn1.Size = new System.Drawing.Size(520, 55);
            this.txtDapAn1.TabIndex = 11;
            // 
            // txtDapAn3
            // 
            this.txtDapAn3.Location = new System.Drawing.Point(766, 135);
            this.txtDapAn3.Multiline = true;
            this.txtDapAn3.Name = "txtDapAn3";
            this.txtDapAn3.Size = new System.Drawing.Size(520, 55);
            this.txtDapAn3.TabIndex = 12;
            // 
            // txtDapAn2
            // 
            this.txtDapAn2.Location = new System.Drawing.Point(122, 205);
            this.txtDapAn2.Multiline = true;
            this.txtDapAn2.Name = "txtDapAn2";
            this.txtDapAn2.Size = new System.Drawing.Size(520, 55);
            this.txtDapAn2.TabIndex = 13;
            // 
            // txtDapAn4
            // 
            this.txtDapAn4.Location = new System.Drawing.Point(766, 208);
            this.txtDapAn4.Multiline = true;
            this.txtDapAn4.Name = "txtDapAn4";
            this.txtDapAn4.Size = new System.Drawing.Size(520, 55);
            this.txtDapAn4.TabIndex = 14;
            // 
            // gvCauHoi
            // 
            this.gvCauHoi.AllowUserToAddRows = false;
            this.gvCauHoi.AllowUserToDeleteRows = false;
            this.gvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCauHoi.Location = new System.Drawing.Point(27, 541);
            this.gvCauHoi.Name = "gvCauHoi";
            this.gvCauHoi.ReadOnly = true;
            this.gvCauHoi.RowHeadersWidth = 51;
            this.gvCauHoi.RowTemplate.Height = 24;
            this.gvCauHoi.Size = new System.Drawing.Size(1254, 260);
            this.gvCauHoi.TabIndex = 15;
            this.gvCauHoi.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCauHoi_RowEnter);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(150, 490);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 34);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(278, 490);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 34);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(409, 490);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(107, 34);
            this.btnXoaAll.TabIndex = 18;
            this.btnXoaAll.Text = "Xóa tất cả";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(532, 490);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(110, 34);
            this.btnTroVe.TabIndex = 19;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnHinhAnh
            // 
            this.btnHinhAnh.Location = new System.Drawing.Point(380, 286);
            this.btnHinhAnh.Name = "btnHinhAnh";
            this.btnHinhAnh.Size = new System.Drawing.Size(110, 34);
            this.btnHinhAnh.TabIndex = 20;
            this.btnHinhAnh.Text = "Chọn ảnh";
            this.btnHinhAnh.UseVisualStyleBackColor = true;
            this.btnHinhAnh.Click += new System.EventHandler(this.btnHinhAnh_Click);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Location = new System.Drawing.Point(766, 292);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(515, 232);
            this.picHinhAnh.TabIndex = 22;
            this.picHinhAnh.TabStop = false;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Enabled = false;
            this.txtHinhAnh.Location = new System.Drawing.Point(496, 292);
            this.txtHinhAnh.Multiline = true;
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(264, 25);
            this.txtHinhAnh.TabIndex = 23;
            // 
            // frmCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 813);
            this.Controls.Add(this.txtHinhAnh);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.btnHinhAnh);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gvCauHoi);
            this.Controls.Add(this.txtDapAn4);
            this.Controls.Add(this.txtDapAn2);
            this.Controls.Add(this.txtDapAn3);
            this.Controls.Add(this.txtDapAn1);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtMaCH);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbDung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCauHoi";
            this.Text = "Quản lý câu hỏi";
            this.Load += new System.EventHandler(this.onLoading);
            ((System.ComponentModel.ISupportInitialize)(this.gvCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtDapAn1;
        private System.Windows.Forms.TextBox txtDapAn3;
        private System.Windows.Forms.TextBox txtDapAn2;
        private System.Windows.Forms.TextBox txtDapAn4;
        private System.Windows.Forms.DataGridView gvCauHoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHinhAnh;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.TextBox txtHinhAnh;
    }
}