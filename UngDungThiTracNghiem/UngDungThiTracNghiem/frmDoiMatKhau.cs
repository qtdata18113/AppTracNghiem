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
    public partial class frmDoiMatKhau : Form
    {
        public string MaTK;
        string sqlConnection = @"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=TracNghiemDB;User ID=sa;Password=sa";
        SqlConnection conn = null;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtXacNhan.Clear();
            txtMatKhauCu.Focus();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string mkDB = "";
            string mkCu = txtMatKhauCu.Text.Trim();
            string mkMoi = txtMatKhauMoi.Text.Trim();
            string mkXN = txtXacNhan.Text.Trim();
            if (conn == null)
            {
                conn = new SqlConnection(sqlConnection);
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MatKhau from TaiKhoan where MaTK='"+MaTK.Trim()+"'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                mkDB = reader.GetString(0).Trim();
            }
            reader.Close();
            if (mkDB != mkCu)
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (mkMoi != mkXN)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                SqlCommand cmd1;
                string sql = "update TaiKhoan set  MatKhau=N'" + mkMoi + "' where MaTK=N'" + MaTK + "'";
                cmd1 = new SqlCommand(sql, conn);
                cmd1.ExecuteNonQuery();
                DialogResult rs =  MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(rs == DialogResult.OK)
                {
                    this.Close();
                }
            }

            conn.Close();
        }
    }
}
