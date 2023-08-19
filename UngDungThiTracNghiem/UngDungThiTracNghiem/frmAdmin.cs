using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungThiTracNghiem
{
    public partial class frmAdmin : Form
    {
        string sqlConnection = @"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=TracNghiemDB;User ID=sa;Password=sa";
        SqlConnection conn = null;
        public frmAdmin()
        {
            InitializeComponent();
        }

        public string HoTen = "";

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clickCauHoi(object sender, EventArgs e)
        {
            frmCauHoi cauhoi = new frmCauHoi();
            cauhoi.ShowDialog();
        }

        private void loadData()
        {

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

        private void clickTaiKhoan(object sender, EventArgs e)
        {
            frmTaiKhoan taiKhoan = new frmTaiKhoan();
            taiKhoan.ShowDialog();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lbHoTen.Text = this.HoTen;
            if (conn == null)
            {
                conn = new SqlConnection(sqlConnection);
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int tatca = 0, dau = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from KetQua";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbLuotThi.Text = reader.GetInt32(0).ToString();
                tatca = reader.GetInt32(0);
            }
            reader.Close();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select count(*) from KetQua where Diem>=5";
            cmd1.Connection = conn;
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                lbDau.Text = reader1.GetInt32(0).ToString();
                dau = reader1.GetInt32(0);
            }
            reader1.Close();

            lbTruot.Text = (tatca - dau).ToString();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select ROUND(AVG(Cast(Diem as Float)), 2) from KetQua";
            cmd2.Connection = conn;
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                lbTB.Text = reader2.GetDouble(0).ToString();
            }
            reader2.Close();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select max(Diem) from KetQua";
            cmd3.Connection = conn;
            SqlDataReader reader3 = cmd3.ExecuteReader();
            if (reader3.Read())
            {
                lbCao.Text = reader3.GetInt32(0).ToString();
            }
            reader3.Close();

            string thisinh = "";
            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "Select MaKQ, KetQua.MaTK, HoTen, Diem, NgayThi from KetQua join TaiKhoan on TaiKhoan.MaTK = KetQua.MaTK where KetQua.Diem = (select max(Diem) from KetQua )";
            cmd4.Connection = conn;
            SqlDataReader reader4 = cmd4.ExecuteReader();
            if (reader4.Read())
            {
                thisinh += reader4.GetString(2) + " ";
            }
            lbThiSinh.Text = thisinh;
            reader4.Close();

            conn.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doiMK = new frmDoiMatKhau();
            doiMK.ShowDialog();
        }

        private void clickLichSu(object sender, EventArgs e)
        {
            frmLichSu ls = new frmLichSu();
            ls.ShowDialog();
        }

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            string ngayBD = dateNgayBD.Value.ToShortDateString();
            string ngayKT = dateNgayKT.Value.ToShortDateString();
            if (conn == null)
            {
                conn = new SqlConnection(sqlConnection);
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int tatca = 0, dau = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from KetQua where NgayThi >= '" + ngayBD + "' and NgayThi <= '" + ngayKT + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbLuotThi.Text = reader.GetInt32(0).ToString();
                tatca = reader.GetInt32(0);
            }
            reader.Close();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select count(*) from KetQua where Diem>=5 and NgayThi >= '" + ngayBD + "' and NgayThi <= '" + ngayKT + "'";
            cmd1.Connection = conn;
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                lbDau.Text = reader1.GetInt32(0).ToString();
                dau = reader1.GetInt32(0);
            }
            reader1.Close();

            lbTruot.Text = (tatca - dau).ToString();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select ROUND(AVG(Cast(Diem as Float)), 2) from KetQua where NgayThi >= '" + ngayBD + "' and NgayThi <= '" + ngayKT + "'";
            cmd2.Connection = conn;
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                lbTB.Text = reader2.GetDouble(0).ToString();
            }
            reader2.Close();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select max(Diem) from KetQua";
            cmd3.Connection = conn;
            SqlDataReader reader3 = cmd3.ExecuteReader();
            if (reader3.Read())
            {
                lbCao.Text = reader3.GetInt32(0).ToString();
            }
            reader3.Close();

            string thisinh = "";
            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "Select MaKQ, KetQua.MaTK, HoTen, Diem, NgayThi from KetQua join TaiKhoan on TaiKhoan.MaTK = KetQua.MaTK where KetQua.Diem = (select max(Diem) from KetQua ) and KetQua.NgayThi >= '" + ngayBD + "' and KetQua.NgayThi <= '" + ngayKT + "'";
            cmd4.Connection = conn;
            SqlDataReader reader4 = cmd4.ExecuteReader();
            if (reader4.Read())
            {
                thisinh += reader4.GetString(2) + " ";
            }
            lbThiSinh.Text = thisinh;
            reader4.Close();

            conn.Close();

        }
    }
}
