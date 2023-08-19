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
    public partial class frmTaiKhoan : Form
    {
        string sqlConnection = @"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=TracNghiemDB;User ID=sa;Password=sa";
        SqlConnection conn = null;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds;
        DataTable dt;

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConnection);
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "select * from TaiKhoan";
            adapter = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds, "TaiKhoan");
            dt = ds.Tables["TaiKhoan"];

            gvTaiKhoan.DataSource = dt;
            txtMaTK.Enabled = false;

            conn.Close();
        }

        private void resetData()
        {
            txtHoTen.Clear();
            txtMaTK.Clear();
            txtTenDN.Clear();
            txtMatKhau.Clear();
            rdThiSinh.Checked = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void onLoading(object sender, EventArgs e)
        {
            loadData();
            resetData();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            
            string tenDN = txtTenDN.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            int vaitro = 1; 

            if (rdAdmin.Checked)
            {
                vaitro = 0;
            } else if (rdThiSinh.Checked)
            {
                vaitro = 1;
            }

            if (tenDN == "" || matkhau == "" || hoten == "")
            {
                MessageBox.Show("Không thể thêm mới. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn == null)
                {
                    conn = new SqlConnection(sqlConnection);
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string maTK = getLastMaTK();
                string sql = "insert into TaiKhoan values ('" + maTK + "', N'" + tenDN + "', N'" + matkhau + "', N'" + hoten + "','" + vaitro + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                loadData();
                resetData();
                conn.Close();

            }
           
        }

        private string getLastMaTK()
        {

            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MaTK  FROM TaiKhoan ORDER BY LEN(MaTK), MaTK offset (select count(*)-1 from TaiKhoan) rows";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            string maTK;
            if (reader.Read())
            {
                string lastMaTK = reader.GetString(0).Trim();
                int nextID = Convert.ToInt32(lastMaTK.Substring(2)) + 1;
                maTK = "TK" + nextID.ToString();
            }
            else
            {
                maTK = "TK1";
            }
            reader.Close();
            return maTK;
        }

        private void gvTaiKhoan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaTK.Text = dt.Rows[row]["MaTK"].ToString().Trim();
            txtTenDN.Text = dt.Rows[row]["TenDN"].ToString().Trim();
            txtMatKhau.Text = dt.Rows[row]["MatKhau"].ToString().Trim();
            txtHoTen.Text = dt.Rows[row]["HoTen"].ToString().Trim();
            string vaitro = dt.Rows[row]["VaiTro"].ToString().Trim();
            if (vaitro == "0")
            {
                rdAdmin.Checked = true;
            } else
            {
                rdThiSinh.Checked = true;
            }
            if (row == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            } else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            txtMaTK.Enabled = false;
            btnThem.Enabled = false;

        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            

            string maTK = txtMaTK.Text.Trim();
            string tenDN = txtTenDN.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            int vaitro = 1;

            if (rdAdmin.Checked)
            {
                vaitro = 0;
            }
            else if (rdThiSinh.Checked)
            {
                vaitro = 1;
            }

            if (tenDN == "" || matkhau == "" || hoten == "")
            {
                MessageBox.Show("Không thể cập nhật. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (conn == null)
                {
                    conn = new SqlConnection(sqlConnection);
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "update TaiKhoan set TenDN=N'" + tenDN + "', MatKhau=N'" + matkhau + "', HoTen=N'" + hoten + "', VaiTro='" + vaitro + "' where MaTK=N'" + maTK + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                loadData();
                resetData();

                conn.Close();
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTK.Text.Trim();
            string tenDN = txtTenDN.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();
            string hoten = txtHoTen.Text;
            if (tenDN == "" || matkhau == "" || hoten == "")
            {
                MessageBox.Show("Không thể thêm mới. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    if (conn == null)
                    {
                        conn = new SqlConnection(sqlConnection);
                    }

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    

                    string sql = "delete from TaiKhoan where MaTK='" + maTK + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    loadData();
                    resetData();
                    conn.Close();
                }
            }
            
                
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
