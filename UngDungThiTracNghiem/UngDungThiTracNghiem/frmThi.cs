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
    public partial class frmThi : Form
    {
        public string HoTen;
        public string MaTK;
        List<DapAnThi> listDA = new List<DapAnThi>();
        string sqlConnection = @"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=TracNghiemDB;User ID=sa;Password=sa";
        SqlConnection conn = null;
        int stt = 0;
        int phut = 19;
        int giay = 00;
        

        public frmThi()
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
            timer1.Enabled = true;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 6 * FROM CauHoi ORDER BY newid()";
            cmd.Connection = conn;
            
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
                DapAnThi dapAnThi = new DapAnThi(stt, reader["NoiDung"].ToString(), reader["DapAn1"].ToString(), reader["DapAn2"].ToString(), reader["DapAn3"].ToString(), reader["DapAn4"].ToString(), reader["HinhAnh"].ToString(),  reader["DapAnDung"].ToString(), "");
                listDA.Add(dapAnThi);
            }

            conn.Close();
            lbHoTen.Text = HoTen;
            stt = 0;
            Next(stt);
            btnTruoc.Enabled = false;
            lbCau.Text = "Câu hỏi " + (stt + 1).ToString();
            

        }

        private void Next(int i)
        {
            rdDapAn1.Visible = true;
            rdDapAn2.Visible = true;
            rdDapAn3.Visible = true;
            rdDapAn4.Visible = true;
            rdDapAn1.Checked = false;
            rdDapAn2.Checked = false;
            rdDapAn3.Checked = false;
            rdDapAn4.Checked = false;


            lbCauHoi.Text = listDA[i].NoiDung.Trim()/*.Substring(0, listDA[i].NoiDung.Trim().Length-1)*/;
            rdDapAn1.Text = listDA[i].DapAn1.Trim();
            rdDapAn2.Text = listDA[i].DapAn2.Trim();
            rdDapAn3.Text = listDA[i].DapAn3.Trim();
            rdDapAn4.Text = listDA[i].DapAn4.Trim();

            if(listDA[i].HinhAnh.Trim() != "")
            {
                pictureHinhAnh.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Image\\" + listDA[i].HinhAnh.Trim());
            } else
            {
                pictureHinhAnh.Image = null;
            }

            if (listDA[i].DapAn.Trim() == "")
            {
                rdDapAn1.Checked = false;
                rdDapAn2.Checked = false;
                rdDapAn3.Checked = false;
                rdDapAn4.Checked = false;
            } else if (listDA[i].DapAn.Trim() == "1")
            {
                rdDapAn1.Checked = true;
            }
            else if (listDA[i].DapAn.Trim() == "2")
            {
                rdDapAn2.Checked = true;
            }
            else if (listDA[i].DapAn.Trim() == "3")
            {
                rdDapAn3.Checked = true;
            }
            else if (listDA[i].DapAn.Trim() == "4")
            {
                rdDapAn4.Checked = true;
            }


            if (rdDapAn1.Text == "")
            {
                rdDapAn1.Visible = false;
            }
            if (rdDapAn2.Text == "")
            {
                rdDapAn2.Visible = false;
            }
            if (rdDapAn3.Text == "")
            {
                rdDapAn3.Visible = false;
            }
            if (rdDapAn4.Text == "")
            {
                rdDapAn4.Visible = false;
            }
        }

        private void lbCauHoi_Click(object sender, EventArgs e)
        {

        }

        private string getLastMaKQ()
        {

            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT MaKQ  FROM KetQua ORDER BY LEN(MaKQ), MaKQ offset (select count(*)-1 from KetQua) rows";
            cmd1.Connection = conn;
            SqlDataReader reader = cmd1.ExecuteReader();
            string maKQ;
            if (reader.Read())
            {
                string lastMaTK = reader.GetString(0).Trim();
                int nextID = Convert.ToInt32(lastMaTK.Substring(2)) + 1;
                maKQ = "KQ" + nextID.ToString();
            }
            else
            {
                maKQ = "KQ1";
            }
            reader.Close();
            return maKQ;
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            btnSau.Enabled = true;
            btnTruoc.Enabled = true;
            stt++;
            if (stt == listDA.Count - 1)
            {
               
                btnSau.Enabled = false;
            }
            Next(stt);
            lbCau.Text = "Câu hỏi " + (stt + 1).ToString();


        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            btnSau.Enabled = true;
            btnTruoc.Enabled = true;
            stt--;
            if (stt == 0)
            {
                btnTruoc.Enabled = false;
            } 
            
                Next(stt);
                lbCau.Text = "Câu hỏi " + (stt + 1).ToString();
            
            

        }

        private void rdDapAn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDapAn1.Checked == true)
            {
                listDA[stt].DapAn = "1";
            }
            
        }

        private void rdDapAn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDapAn2.Checked == true)
            {
                listDA[stt].DapAn = "2";
            }
            
        }

        private void rdDapAn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDapAn3.Checked  == true)
            {
                listDA[stt].DapAn = "3";
            }
            
        }

        private void rdDapAn4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDapAn4.Checked == true)
            {
                listDA[stt].DapAn = "4";
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (giay == 0)
            {
                giay = 60;
                phut--;
                
            }
            giay--;
            string sPhut, sGiay;
            if (phut < 10)
            {
                sPhut = "0" + phut.ToString();
            } else
            {
                sPhut = phut.ToString();
            }

            if (giay < 10)
            {
                sGiay = "0" + giay.ToString();
            }
            else
            {
                sGiay = giay.ToString();
            }
            lbThoiGian.Text = sPhut + ":" + sGiay;
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn nộp bài không?", "Xác nhận nộp bài", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int diem = 0;
                string kq = "Trượt";
                for(int i = 0; i <= listDA.Count - 1; i++){
                    if (listDA[i].DapAn.Trim() == listDA[i].DapAnDung.Trim())
                    {
                        diem++;
                    }
                }
                if (diem >= 5)
                {
                    kq = "Đậu";
                }

                if (conn == null)
                {
                    conn = new SqlConnection(sqlConnection);
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string maKQ = getLastMaKQ();
                SqlCommand cmd1;
                string sql = "insert into KetQua values ('" + maKQ + "', N'" + MaTK + "', '" + diem + "', '" + DateTime.Today + "')";
                cmd1 = new SqlCommand(sql, conn);
                cmd1.ExecuteNonQuery();

                conn.Close();

                DialogResult result2 = MessageBox.Show("Thí sinh: " + HoTen + "\r\n Điểm: "+diem+"\r\n" + "Kết quả: "+ kq, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    frmNguoiDung nguoiDung = new frmNguoiDung();
                    nguoiDung.HoTen = HoTen;
                    nguoiDung.Show();
                    this.Close();
                }
            }
        }
    }

    public class DapAnThi
    {
        public int stt { get; set; }
        public string NoiDung { get; set; }
        public string DapAn1 { get; set; }
        public string DapAn2 { get; set; }
        public string DapAn3 { get; set; }
        public string DapAn4 { get; set; }
        public string HinhAnh { get; set; }
        public string DapAnDung { get; set; }
        public string DapAn { get; set; }

        public DapAnThi(int stt, string NoiDung, string DapAn1, string DapAn2, string DapAn3, string DapAn4, string HinhAnh, string DapAnDung, string DapAn)
        {
            this.stt = stt;
            this.NoiDung = NoiDung;
            this.DapAn1 = DapAn1;
            this.DapAn2 = DapAn2;
            this.DapAn3 = DapAn3;
            this.DapAn4 = DapAn4;
            this.HinhAnh = HinhAnh;
            this.DapAnDung = DapAnDung;
            this.DapAn = DapAn;
        }

    }
}
