using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungThiTracNghiem
{
    
    public partial class frmNguoiDung : Form
    {

        public string HoTen;
        public string MaTK;

        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void onLoading(object sender, EventArgs e)
        {
            lbHoTen.Text = HoTen;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            frmThi thi = new frmThi();
            thi.HoTen = HoTen;
            thi.MaTK = MaTK;
            thi.Show();
            this.Close();
        }

        private void clickLichSu(object sender, EventArgs e)
        {
            frmLichSu ls = new frmLichSu();
            ls.MaTK = MaTK.Trim();
            ls.ShowDialog();
        }

        private void clickThoat(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {

                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.Show();
                this.Hide();

            }
        }

        private void clickDoiMK(object sender, EventArgs e)
        {
            frmDoiMatKhau mk = new frmDoiMatKhau();
            mk.MaTK = MaTK.Trim();
            mk.ShowDialog();

        }
    }


    
}
