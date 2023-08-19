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
    public partial class frmDangNhap : Form
    {

        string sqlConnection = @"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=TracNghiemDB;User ID=sa;Password=sa";
        SqlConnection conn = null;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void onLoading(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(sqlConnection);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();

            if (conn == null)
            {
                conn = new SqlConnection(sqlConnection);
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            if (tenDN == "" || matkhau == "")
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from TaiKhoan where TenDN='" + tenDN + "' and MatKhau='" + matkhau + "'";
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int vaitro = reader.GetByte(4);
                    if (vaitro == 0)
                    {
                        frmAdmin admin = new frmAdmin();
                        admin.HoTen = reader.GetString(3);
                        admin.Show();


                    }
                    else
                    {
                        frmNguoiDung nguoiDung = new frmNguoiDung();
                        nguoiDung.HoTen = reader.GetString(3);
                        nguoiDung.MaTK = reader.GetString(0);
                        nguoiDung.Show();


                    }
                    reader.Close();
                    this.Hide();
                    conn.Close();
                }
                else
                {

                    MessageBox.Show("Đăng nhập không thành công. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
