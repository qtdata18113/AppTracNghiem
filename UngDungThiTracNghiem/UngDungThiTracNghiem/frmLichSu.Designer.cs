
namespace UngDungThiTracNghiem
{
    partial class frmLichSu
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
            this.btnLayDuLieu = new System.Windows.Forms.Button();
            this.dateNgayKT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateNgayBD = new System.Windows.Forms.DateTimePicker();
            this.gvLichSu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLayDuLieu
            // 
            this.btnLayDuLieu.Location = new System.Drawing.Point(508, 23);
            this.btnLayDuLieu.Name = "btnLayDuLieu";
            this.btnLayDuLieu.Size = new System.Drawing.Size(115, 25);
            this.btnLayDuLieu.TabIndex = 15;
            this.btnLayDuLieu.Text = "Lấy dữ liệu";
            this.btnLayDuLieu.UseVisualStyleBackColor = true;
            this.btnLayDuLieu.Click += new System.EventHandler(this.btnLayDuLieu_Click);
            // 
            // dateNgayKT
            // 
            this.dateNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dateNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayKT.Location = new System.Drawing.Point(302, 26);
            this.dateNgayKT.Name = "dateNgayKT";
            this.dateNgayKT.Size = new System.Drawing.Size(200, 22);
            this.dateNgayKT.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Từ";
            // 
            // dateNgayBD
            // 
            this.dateNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dateNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayBD.Location = new System.Drawing.Point(43, 26);
            this.dateNgayBD.Name = "dateNgayBD";
            this.dateNgayBD.Size = new System.Drawing.Size(200, 22);
            this.dateNgayBD.TabIndex = 11;
            // 
            // gvLichSu
            // 
            this.gvLichSu.AllowUserToAddRows = false;
            this.gvLichSu.AllowUserToDeleteRows = false;
            this.gvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLichSu.Location = new System.Drawing.Point(43, 69);
            this.gvLichSu.Name = "gvLichSu";
            this.gvLichSu.ReadOnly = true;
            this.gvLichSu.RowHeadersWidth = 51;
            this.gvLichSu.RowTemplate.Height = 24;
            this.gvLichSu.Size = new System.Drawing.Size(580, 390);
            this.gvLichSu.TabIndex = 16;
            // 
            // frmLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(654, 503);
            this.Controls.Add(this.gvLichSu);
            this.Controls.Add(this.btnLayDuLieu);
            this.Controls.Add(this.dateNgayKT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateNgayBD);
            this.Name = "frmLichSu";
            this.Text = "Lịch sử thi";
            this.Load += new System.EventHandler(this.onLoading);
            ((System.ComponentModel.ISupportInitialize)(this.gvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLayDuLieu;
        private System.Windows.Forms.DateTimePicker dateNgayKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateNgayBD;
        private System.Windows.Forms.DataGridView gvLichSu;
    }
}