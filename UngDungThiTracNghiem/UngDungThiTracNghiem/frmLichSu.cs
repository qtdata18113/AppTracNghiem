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
    public partial class frmLichSu : Form
    {
        string sqlConnection = @"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=TracNghiemDB;User ID=sa;Password=sa";
        SqlConnection conn = null;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds;
        DataTable dt;
        public string MaTK;
        public frmLichSu()
        {
            InitializeComponent();
        }

        private void onLoading(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConnection);
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            
            string sql = "Select MaKQ, KetQua.MaTK, HoTen, Diem, NgayThi from KetQua join TaiKhoan on TaiKhoan.MaTK = KetQua.MaTK";

            if (MaTK != null)
            {
                sql = "Select MaKQ, KetQua.MaTK, HoTen, Diem, NgayThi from KetQua join TaiKhoan on TaiKhoan.MaTK = KetQua.MaTK where KetQua.MaTK='"+MaTK.Trim()+"'";
            }
            adapter = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds, "KetQua");
            dt = ds.Tables["KetQua"];

            gvLichSu.DataSource = dt;


            conn.Close();
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

            string sql = "Select MaKQ, KetQua.MaTK, HoTen, Diem, NgayThi from KetQua join TaiKhoan on TaiKhoan.MaTK = KetQua.MaTK where KetQua.NgayThi >= '"+ngayBD+"' and KetQua.NgayThi <= '"+ngayKT+"'";
            if (MaTK != "")
            {
                sql = "Select MaKQ, KetQua.MaTK, HoTen, Diem, NgayThi from KetQua join TaiKhoan on TaiKhoan.MaTK = KetQua.MaTK where KetQua.NgayThi >= '" + ngayBD + "' and KetQua.NgayThi <= '" + ngayKT + "' and  KetQua.MaTK='" + MaTK.Trim() + "'";
                
            }
            adapter = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds, "KetQua");
            dt = ds.Tables["KetQua"];

            gvLichSu.DataSource = dt;


            conn.Close();

        }
    }
}
