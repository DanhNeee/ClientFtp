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
    public partial class Form3 : Form
    {
        string strCon = @"Data Source=" + System.Windows.Forms.SystemInformation.ComputerName + "\\SQLEXPRESS;Initial Catalog=QLUSER;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter daQTuser = null;
        DataTable dtQTuser = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
                int id = Form1.id;
                // Khởi động connection
                sqlCon = new SqlConnection(strCon);
                // Vận chuyển dữ liệu lên DataTable dtKhachHang
                daQTuser = new SqlDataAdapter("select [Name_folder],[Trang_thai],[id_login] from [QLUSER].[dbo].[folder_check] where [id_login] =" + id+"", sqlCon);
                dtQTuser = new DataTable();
                dtQTuser.Clear();
                daQTuser.Fill(dtQTuser);
                // Đưa dữ liệu lên DataGridView
                dgvShowFolder.DataSource = dtQTuser;
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table TaiLieu.Lỗi rồi!!!");
            }
            
        }
    }
}
