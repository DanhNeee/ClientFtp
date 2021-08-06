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

namespace FTPClient
{
    public partial class Form2 : Form
    {
        string strCon = @"Data Source=" + System.Windows.Forms.SystemInformation.ComputerName + "\\SQLEXPRESS;Initial Catalog=QuanLyTaiLieuQTMT;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter daQTMT = null;
        DataTable dtQTMT = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            try
            {
                // Khởi động connection
                sqlCon = new SqlConnection(strCon);
                // Vận chuyển dữ liệu lên DataTable dtKhachHang
                daQTMT = new SqlDataAdapter("select * from TaiLieuQTMT", sqlCon);
                dtQTMT = new DataTable();
                dtQTMT.Clear();
                daQTMT.Fill(dtQTMT);
                // Đưa dữ liệu lên DataGridView
                dgv.DataSource = dtQTMT;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table TaiLieu.Lỗi rồi!!!");
            }

        }
    }
}
