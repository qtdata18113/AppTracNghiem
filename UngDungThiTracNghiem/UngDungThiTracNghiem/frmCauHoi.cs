using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungThiTracNghiem
{
    public partial class frmCauHoi : Form
    {
        string sqlConnection = @"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=TracNghiemDB;User ID=sa;Password=sa";
        SqlConnection conn = null;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds;
        DataTable dt;
        OpenFileDialog file = new OpenFileDialog();


        public frmCauHoi()
        {
            InitializeComponent();
        }

        private void onLoading(object sender, EventArgs e)
        {
            loadData();
            resetData();
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

            string sql = "select * from CauHoi";
            adapter = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds, "CauHoi");
            dt = ds.Tables["CauHoi"];

            gvCauHoi.DataSource = dt;
            txtMaCH.Enabled = false;

            conn.Close();
        }

        private void resetData()
        {
            txtMaCH.Clear();
            txtNoiDung.Clear();
            txtDapAn1.Clear();
            txtDapAn2.Clear();
            txtDapAn3.Clear();
            txtDapAn4.Clear();
            cbDung.Text = "";

            
            btnThem.Enabled = true;
            btnHinhAnh.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            

           
            string noidung = txtNoiDung.Text;
            string dapan1 = txtDapAn1.Text;
            string dapan2 = txtDapAn2.Text;
            string dapan3 = txtDapAn3.Text;
            string dapan4 = txtDapAn4.Text;
            string dapandung = cbDung.Text;
            string hinhanh = txtHinhAnh.Text;

            if (noidung == "" || dapan1 == "" || dapan2 == "" || dapan3 == "" || dapan4 == "" || dapandung == "")
            {
                MessageBox.Show("Không thể thêm mới. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string maCH = getLastMaCH();
                if (hinhanh != "")
                {
                    string filename = file.FileName;
                    string file1 = Path.GetFileName(file.FileName);
                    string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    File.Copy(filename, path + "\\Image\\" + file1);

                    string sql = "insert into CauHoi values ('" + maCH + "', N'" + noidung + "', N'" + dapan1 + "', N'" + dapan2 + "', N'" + dapan3 + "', N'" + dapan4 + "', '" + hinhanh + "', '" + dapandung + "')";
                    cmd = new SqlCommand(sql, conn);
                }
                else
                {
                    string sql = "insert into CauHoi values ('" + maCH + "', N'" + noidung + "', N'" + dapan1 + "', N'" + dapan2 + "', N'" + dapan3 + "', N'" + dapan4 + "', null, '" + dapandung + "')";
                    cmd = new SqlCommand(sql, conn);
                }




                cmd.ExecuteNonQuery();
                loadData();
                resetData();

                conn.Close();
            }
            
        }

        private string getLastMaCH()
        {

            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MaCH  FROM CauHoi ORDER BY LEN(MaCH), MaCH offset (select count(*)-1 from CauHoi) rows";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            string maCH;
            if (reader.Read())
            {
                string lastMaCH = reader.GetString(0).Trim();
                int nextID = Convert.ToInt32(lastMaCH.Substring(2)) + 1;
                maCH = "CH" + nextID.ToString();
            }
            else
            {
                maCH = "CH1";
            }
            reader.Close();
            return maCH;
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void gvCauHoi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaCH.Text = dt.Rows[row]["MaCH"].ToString();
            txtNoiDung.Text = dt.Rows[row]["NoiDung"].ToString();
            txtDapAn1.Text = dt.Rows[row]["DapAn1"].ToString();
            txtDapAn2.Text = dt.Rows[row]["DapAn2"].ToString();
            txtDapAn3.Text = dt.Rows[row]["DapAn3"].ToString();
            txtDapAn4.Text = dt.Rows[row]["DapAn4"].ToString();
            cbDung.Text = dt.Rows[row]["DapAnDung"].ToString();
            string hinhanh = dt.Rows[row]["HinhAnh"].ToString().Trim();

            if ( hinhanh != "")
            {
                picHinhAnh.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Image\\" + hinhanh);
                txtHinhAnh.Text = dt.Rows[row]["HinhAnh"].ToString();
                btnHinhAnh.Enabled = false;
            } else
            {
                txtHinhAnh.Clear();
                picHinhAnh.Image = null;
                btnHinhAnh.Enabled = true;
            }
           
            txtMaCH.Enabled = false;
            btnThem.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            

            string maCH = txtMaCH.Text;
            string noidung = txtNoiDung.Text;
            string dapan1 = txtDapAn1.Text;
            string dapan2 = txtDapAn2.Text;
            string dapan3 = txtDapAn3.Text;
            string dapan4 = txtDapAn4.Text;
            string dapandung = cbDung.Text;
            string hinhanh = txtHinhAnh.Text.Trim();

            if (noidung == "" || dapan1 == "" || dapan2 == "" || dapan3 == "" || dapan4 == "" || dapandung == "")
            {
                MessageBox.Show("Không thể cập nhật. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (hinhanh != "")
                {
                    string filename = file.FileName;
                    string file1 = Path.GetFileName(file.FileName);
                    string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    File.Copy(filename, path + "\\Image\\" + file1);
                    string sql = "update CauHoi set NoiDung=N'" + noidung + "', DapAn1=N'" + dapan1 + "', DapAn2=N'" + dapan2 + "', DapAn3=N'" + dapan3 + "', DapAn4=N'" + dapan4 + "', HinhAnh='" + hinhanh + "', DapAnDung='" + dapandung + "' where MaCH='" + maCH + "'";
                    cmd = new SqlCommand(sql, conn);
                }
                else
                {
                    string sql = "update CauHoi set NoiDung=N'" + noidung + "', DapAn1=N'" + dapan1 + "', DapAn2=N'" + dapan2 + "', DapAn3=N'" + dapan3 + "', DapAn4=N'" + dapan4 + "', DapAnDung='" + dapandung + "' where MaCH='" + maCH + "'";
                    cmd = new SqlCommand(sql, conn);
                }
                cmd.ExecuteNonQuery();
                loadData();

                conn.Close();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCH.Text == "")
            {
                MessageBox.Show("Không thể xóa. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa câu hỏi này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
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

                    string maCH = txtMaCH.Text;

                    string sql = "delete from CauHoi where MaCH='" + maCH + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    loadData();

                    conn.Close();
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            
            file.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = new Bitmap(file.FileName);
                txtHinhAnh.Text = file.SafeFileName;
            }
        }
    }
}
