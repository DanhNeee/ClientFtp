using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTPClient;
using System.Net.Sockets;
using System.Collections;
using System.IO;
using FTPManager;
using FileTransferProtocolLib;
using System.Net;
using System.Data.SqlClient;
using FTPClient.Acces;
using System.Diagnostics;

namespace FTPClient
{
    public partial class Form1 : Form
    {
        FTPManagerClass client;
        string strCon = @"Data Source=" + System.Windows.Forms.SystemInformation.ComputerName + "\\SQLEXPRESS;Initial Catalog=QuanLyTaiLieuQTMT;Integrated Security=True";
        SqlConnection sqlCon = null;
        public NetworkStream nStr;
        public StreamReader rStr;
        List<taiLieu> ltl = new List<taiLieu>();
        int phut = 4;
        int giay = 60;
        int countid = 1;
        public static int id = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public string sendFTPcmd(String cmd)
        {
            byte[] messe;
            rStr = new StreamReader(nStr);
            messe = Encoding.ASCII.GetBytes(cmd.ToCharArray());
            nStr.Write(messe, 0, messe.Length);
            return rStr.ReadLine();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try {
                string txt = "ftp://" + txtHost.Text;
                client = new FTPManagerClass(txtUser.Text, txtPass.Text, txt);
                TcpClient ftpSocket = new TcpClient(txtHost.Text, int.Parse(txtPort.Text));
                nStr = ftpSocket.GetStream();
                rStr = new StreamReader(nStr);
                Lbs.Items.Add(rStr.ReadLine());
                Lbs.Items.Add("USER " + txtUser.Text);
                Lbs.Items.Add(sendFTPcmd("USER " + txtUser.Text + "\r\n"));
                Lbs.Items.Add("PASS ***");
                Lbs.Items.Add(sendFTPcmd("PASS " + txtPass.Text + "\r\n"));
                ATlist();
                if (Lbs.Items[4].ToString().Substring(0, 3) != "230")
                {
                    //no code
                }
            }catch(Exception er)
            {
                Lbs.Items.Add("Kiểm tra lại Host DM");
            }
            String sel = "Select [id_login] from [QLUSER].[dbo].[login_check] where [TK]='"+txtUser.Text+"' ";
            SqlCommand cmd1 = new SqlCommand(sel, sqlCon);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                id = reader1.GetInt32(0);
            }

            reader1.Close();
            reader1.Dispose();
            
        }
        public void Connect(String user, String pass, String host){
            try {
                client = new FTPManagerClass(user, pass, host);
                TcpClient ftpSocket = new TcpClient(host, int.Parse("21"));
                nStr = ftpSocket.GetStream();
                rStr = new StreamReader(nStr);
                Lbs.Items.Add(rStr.ReadLine());
                Lbs.Items.Add("USER " + user);
                Lbs.Items.Add(sendFTPcmd("USER " + user + "\r\n"));
                Lbs.Items.Add("PASS ***");
                Lbs.Items.Add(sendFTPcmd("PASS " + pass + "\r\n"));
                ATlist();
                if (Lbs.Items[4].ToString().Substring(0, 3) != "230")
                {
                    //no code
                }
            }
            catch (Exception e) { Lbs.Items.Add(e); }
        }




        private void btnGet_Click(object sender, EventArgs e)
        {
            try {
                List<String> files = Get_file();
                List<String> folder = Get_folder();
                dgvShow.Rows.Clear();
                foreach (String file in files)
                {

                    dgvShow.Rows.Add(file);


                }
               foreach (String folders in folder)
                {

                    dgvShow.Rows.Add(folders);


                }
            }
            catch(Exception er)
            {
                Lbs.Items.Add("Login Please!");
                Lbs.Items.Add(er);
                txtUser.Focus();
                ATlist();
            }
 
        }

        private void btndown_Click(object sender, EventArgs e)
        {
 
            try {
                List<String> files = Get_file();
                foreach (String file in files)
                {
                    GetDownload(file);
                    Lbs.Items.Add("File Đã tải về:"+file);

                }
                
                ATlist();
            } catch(Exception error) { 
                Lbs.Items.Add("Login Please!");
                Lbs.Items.Add(error);
                txtUser.Focus();
                ATlist();
            }
        }
     
        private String GetDownload(String Filename)//down file in /root
        {
                String FtpInfo = "ftp://" + txtHost.Text + "/";
                String result = String.Empty;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FtpInfo + Filename);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(txtUser.Text, txtPass.Text);
                FtpWebResponse reponse = (FtpWebResponse)request.GetResponse();
                Stream res = reponse.GetResponseStream();
                StreamReader reader = new StreamReader(res);
                result = reader.ReadToEnd();
                using (StreamWriter file = File.CreateText("D:/FTP/"+Filename))
                {
                    file.WriteLine(result);
                    file.Close();
                }
                reader.Close();
                res.Close();

                return result;
            

        }

        private String GetDownloadFileInFolder(String Folder,String Filename) //down file in folder
        {
                String FtpInfo = "ftp://" + txtHost.Text + "/"+Folder+"/";
                String result = String.Empty;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FtpInfo + Filename);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(txtUser.Text, txtPass.Text);
                FtpWebResponse reponse = (FtpWebResponse)request.GetResponse();
                Stream res = reponse.GetResponseStream();
                StreamReader reader = new StreamReader(res);
                result = reader.ReadToEnd();
                using (StreamWriter file = File.CreateText("D:/FTP/" + Filename))
                {
                    file.WriteLine(result);
                    file.Close();
                }
                reader.Close();
                res.Close();
            
            return result;


        }
        private List<String> Get_file() // đọc file in /root
        {
            String FtpInfo = "ftp://" + txtHost.Text;
            List<String> files_lsst = new List<string>();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FtpInfo);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(txtUser.Text, txtPass.Text);
            FtpWebResponse reponse = (FtpWebResponse)request.GetResponse();
            Stream res = reponse.GetResponseStream();
            StreamReader reader = new StreamReader(res);
            String line = String.Empty;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(".txt"))
                {
                    files_lsst.Add(line);
                }
            }
            reader.Close();
            reponse.Close();
            return files_lsst;

        }
        private List<String> Get_fileInf(String folder) // đọc file in folder
        {
            String FtpInfo = "ftp://" + txtHost.Text +"/"+folder+"/";
            List<String> files_lsst = new List<string>();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FtpInfo);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(txtUser.Text, txtPass.Text);
            FtpWebResponse reponse = (FtpWebResponse)request.GetResponse();
            Stream res = reponse.GetResponseStream();
            StreamReader reader = new StreamReader(res);
            String line = String.Empty;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(".txt"))
                {
                    files_lsst.Add(line);
                }
            }
            reader.Close();
            reponse.Close();
            return files_lsst;

        }
        private List<String> Get_folder() // đọc folder
        {
            String FtpInfo = "ftp://" + txtHost.Text;
            List<String> files_lsst = new List<string>();
            List<String> folder = new List<string>();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FtpInfo);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(txtUser.Text, txtPass.Text);
            FtpWebResponse reponse = (FtpWebResponse)request.GetResponse();
            Stream res = reponse.GetResponseStream();
            StreamReader reader = new StreamReader(res);
            String line = String.Empty;
            while ((line = reader.ReadLine()) != null)
            {
                if (!line.Contains("."))
                {
                    files_lsst.Add(line);
                }
            }
            reader.Close();
            reponse.Close();
            return files_lsst;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ATlist()
        {
            Lbs.SelectedIndex = Lbs.Items.Count - 1;
            Lbs.SelectedIndex = -1;
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvShow.CurrentCell.RowIndex;
                string str0 = dgvShow.Rows[r].Cells[0].Value.ToString();
                int str1 = str0.IndexOf('/');
                if (str1 == -1)
                {
                    string path = "D:/FTP/" + str0;
                    Lbs.Items.Add("Read File:" + str0);
                    ATlist();
                    if (System.IO.File.Exists(path))
                    {
                        ltl = files.readFile(path);

                        hienThiDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("File không tồn tại!");
                    }
                }
                else
                {
                    int strcut = str0.Length -1;
                    string p =str0.Substring(str1+1);
                    string path = "D:/FTP/" + p;
                    Lbs.Items.Add("Read File:" + p);
                    ATlist();
                    if (System.IO.File.Exists(path))
                    {
                        ltl = files.readFile(path);

                        hienThiDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("File không tồn tại!");
                    }

                }


            }
            catch (Exception)
            {
                Lbs.Items.Add("Login Please!");
                txtUser.Focus();
                ATlist();

            }

        }
        private void hienThiDuLieu()
        {
            listView1.Items.Clear();
            foreach (taiLieu itemTl in ltl)
            {
                ListViewItem lvi = new ListViewItem(itemTl.maTL);
                lvi.SubItems.Add(itemTl.giaTri);
                lvi.SubItems.Add(itemTl.donVi);
                lvi.SubItems.Add(itemTl.date);
                lvi.SubItems.Add(itemTl.trangThai);
                listView1.Items.Add(lvi);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            String sel = "Select * from [QLUSER].[dbo].[login_check]";
            SqlCommand cmd1 = new SqlCommand(sel, sqlCon);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            int count = 0;
            while (reader1.Read())
            {
                count++;
            }
            reader1.Close();
            reader1.Dispose();
            if (count == 0)
            {
                this.timer.Enabled = false;
            }
            else { this.timer.Enabled = true; }
            
            string path = "D:/FTP/";
            if (!Directory.Exists(path))
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
        }
        

        private void btnDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                int i = 0;
                string select = "SELECT MAX(stt_QTMT) FROM[QuanLyTaiLieuQTMT].[dbo].[TaiLieuQTMT]";
                SqlCommand cmd = new SqlCommand(select, sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    i = reader.GetInt32(0);
                }
                reader.Close();
                reader.Dispose();


                List<String> files = Get_file();

                foreach (String file in files)
                {
                    string path = "D:/FTP/" + file;
                    StreamReader sr = new StreamReader(path);
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] arr = line.Split('\t');
                        if (arr.Length == 5)
                        {

                            string maTL = arr[0].Trim();
                            string giaTri = arr[1].Trim();
                            string donVi = arr[2].Trim();

                            string str = arr[3].Trim();
                            string str1 = str.Substring(0, 4);
                            string str2 = str.Substring(4, 2);
                            string str3 = str.Substring(6, 2);
                            string str4 = str.Substring(8, 2);
                            string str5 = str.Substring(10, 2);
                            string str6 = str.Substring(12, 2);

                            string date = str1 + "/" + str2 + "/" + str3;
                            string time = str4 + ":" + str5 + ":" + str6;

                            string trangThai = arr[4].Trim();

                            i++;

                            String sel = "Select * from [QuanLyTaiLieuQTMT].[dbo].[TaiLieuQTMT] where (MaTaiLieu ='" + maTL + "' and GiaTri=" + giaTri + " and DonVi='" + donVi + "' and NgayThang='" + date + " " + time + "' and TrangThai=" + trangThai + ")";
                            SqlCommand cmd1 = new SqlCommand(sel, sqlCon);
                            SqlDataReader reader1 = cmd1.ExecuteReader();
                            int count = 0;
                            while (reader1.Read())
                            {
                                count++;

                            }
                            reader1.Close();
                            reader1.Dispose();
                            if (count <= 0)
                            {
                                SqlCommand sqlCmd = new SqlCommand();
                                sqlCmd.CommandType = CommandType.Text;
                                sqlCmd.CommandText = "insert into TaiLieuQTMT values (N'" + i + "','" + maTL + "'," + giaTri + ",'" + donVi + "','" + date + " " + time + "'," + trangThai + ")";

                                sqlCmd.Connection = sqlCon;
                                try
                                {
                                    int kq = sqlCmd.ExecuteNonQuery();
                                    if (kq > 0)
                                    {          
                                        Lbs.Items.Add("Thêm dữ liệu thành công");                                       
                                        ATlist();
                                    }

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    Lbs.Items.Add("Thêm dữ liệu thất bại!");
                                    ATlist();
                                }
                            }
                            else
                            {

                                Lbs.Items.Add("Dữ liệu đã tồn tại,Thêm thất bại!");
                                ATlist();
                            }


                        }
                        line = sr.ReadLine();
                    }
                    sr.Close();

                }

            }
            catch (Exception er)
            {
                Lbs.Items.Add("Login Please!"+er+"");
                txtUser.Focus();
                ATlist();
            }
        }

        private void ShowDB_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                this.lbPhut.Text = phut.ToString();
                this.lbGiay.Text = giay.ToString();
                giay--;
                if (giay < 0)
                {
                    phut -= 1;
                    giay = 60;
                }
                if (phut == 0 && giay == 0)
                {
                    phut = 4;
                    String sel = "Select [id_login],[TK],[Pass],[Host] from [QLUSER].[dbo].[login_check] where id_login = " + countid + "";
                    SqlCommand cmd1 = new SqlCommand(sel, sqlCon);
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    String user, pass, host;
                    //int id = 0;
                    while (reader1.Read())
                    {
                        id = reader1.GetInt32(0);
                        txtUser.Text = reader1.GetString(1);
                        txtPass.Text = reader1.GetString(2);
                        txtHost.Text = reader1.GetString(3);
                        user = reader1.GetString(1);
                        pass = reader1.GetString(2);
                        host = reader1.GetString(3);
                        Connect(user, pass, host);
                    }
                    reader1.Close();
                    reader1.Dispose();
                    countid += 1;
                    String sel1 = "Select * from [QLUSER].[dbo].[login_check]";
                    SqlCommand cmd2 = new SqlCommand(sel1, sqlCon);
                    SqlDataReader reader3 = cmd2.ExecuteReader();
                    int count = 1;
                    while (reader3.Read())
                    {
                        count++;
                    }
                    reader3.Close();
                    reader3.Dispose();
                    if (countid == count++)
                    {
                        countid = 1;
                    }
                    List<String> files = Get_file();
                    foreach (String file in files)
                    {
                        String path = "D:/FTP/" + file;
                        if (File.Exists(path))
                        {
                            Lbs.Items.Add("File Đã Tồn Tại:" + file);
                        }
                        else
                        {
                            GetDownload(file);
                            Lbs.Items.Add("File Đã tải về:" + file);
                        }

                        String selx = "Select * from [QLUSER].[dbo].[folder_check]";
                        SqlCommand cmd1x = new SqlCommand(selx, sqlCon);
                        SqlDataReader reader1x = cmd1x.ExecuteReader();
                        int countx = 1;
                        while (reader1x.Read())
                        {
                            countx++;
                        }
                        reader1x.Close();
                        reader1x.Dispose();
                        String selfolder = "Select * from [QLUSER].[dbo].[folder_check] where [Name_folder] ='/" + file + "'and [Trang_thai] ='" + 1 + "'and [id_login]='" + id + "'";
                        SqlCommand cmd1folder = new SqlCommand(selfolder, sqlCon);
                        SqlDataReader reader1f = cmd1folder.ExecuteReader();
                        int countf = 0;
                        while (reader1f.Read())
                        {
                            countf++;

                        }
                        reader1f.Close();
                        reader1f.Dispose();
                        if (countf <= 0)
                        {
                            SqlCommand sqlCmd = new SqlCommand();
                            sqlCmd.CommandType = CommandType.Text;
                            sqlCmd.CommandText = "insert into [QLUSER].[dbo].[folder_check] values (" + countx + " ,'/" + file + "','" + 1 + "'," + id + ") ";
                            sqlCmd.Connection = sqlCon;
                            try
                            {
                                int kq = sqlCmd.ExecuteNonQuery();
                                if (kq > 0)
                                {
                                    Lbs.Items.Add("Thêm dữ liệu Folder thành công");
                                    ATlist();
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                Lbs.Items.Add("Thêm dữ liệu Folder thất bại!");
                                ATlist();
                            }
                        }
                        else
                        {
                            Lbs.Items.Add("Thêm dữ liệu thất bại! Folder tồn tại!");
                        }

                    }
                    ATlist();
                    List<String> folers = Get_folder();
                    List<String> fileDir = new List<string>();

                    foreach (string folder in folers)
                    {
                        fileDir.Clear();
                        List<String> FileInf = Get_fileInf(folder);
                        if (FileInf.All(s => string.IsNullOrWhiteSpace(s)))
                        {
                            fileDir.Add("Empty");
                        }
                        else
                        {
                            foreach (String Fileinfs in FileInf)
                            {
                                    fileDir.Add(Fileinfs);
                            String path = "D:/FTP/" + Fileinfs;
                                if (File.Exists(path))
                                {
                                    Lbs.Items.Add("File Đã Tồn Tại:" + Fileinfs);
                                }
                                else
                                {
                                    GetDownloadFileInFolder(folder, Fileinfs);
                                    Lbs.Items.Add("File Đã tải về:" + folder + "/" + Fileinfs);
                                    
                                }
                            }
                        }


                        foreach (String filesDir in fileDir)
                        {
                            String selx = "Select * from [QLUSER].[dbo].[folder_check]";
                            SqlCommand cmd1x = new SqlCommand(selx, sqlCon);
                            SqlDataReader reader1x = cmd1x.ExecuteReader();
                            int countx = 1;
                            while (reader1x.Read())
                            {
                                countx++;
                            }
                            reader1x.Close();
                            reader1x.Dispose();
                            String selfolder = "Select * from [QLUSER].[dbo].[folder_check] where [Name_folder] ='" + folder + "/" + filesDir + "'and [Trang_thai] ='" + 1 + "'and [id_login]='" + id + "'";
                            SqlCommand cmd1folder = new SqlCommand(selfolder, sqlCon);
                            SqlDataReader reader1f = cmd1folder.ExecuteReader();
                            int countf = 0;
                            while (reader1f.Read())
                            {
                                countf++;

                            }
                            reader1f.Close();
                            reader1f.Dispose();
                            if (countf <= 0)
                            {
                                SqlCommand sqlCmd = new SqlCommand();
                                sqlCmd.CommandType = CommandType.Text;
                                sqlCmd.CommandText = "insert into [QLUSER].[dbo].[folder_check] values (" + countx + " ,'" + folder + "/" + filesDir + "','" + 1 + "'," + id + ") ";
                                sqlCmd.Connection = sqlCon;
                                try
                                {
                                    int kq = sqlCmd.ExecuteNonQuery();
                                    if (kq > 0)
                                    {
                                        Lbs.Items.Add("Thêm dữ liệu Folder thành công");
                                        ATlist();
                                    }

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("lỗi: " + ex.Message);
                                    Lbs.Items.Add("Thêm dữ liệu Folder thất bại!");
                                    ATlist();
                                }
                            }
                            else
                            {
                                Lbs.Items.Add("Thêm dữ liệu thất bại! Folder tồn tại!");
                            }
                        }
                    }
                    ATlist();
                }
            
        }

        private void btnUs_Click(object sender, EventArgs e)
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
                string txt = "ftp://" + txtHost.Text;
                client = new FTPManagerClass(txtUser.Text, txtPass.Text, txt);
                TcpClient ftpSocket = new TcpClient(txtHost.Text, int.Parse(txtPort.Text));
                nStr = ftpSocket.GetStream();
                rStr = new StreamReader(nStr);
                Lbs.Items.Clear();
                Lbs.Items.Add(rStr.ReadLine());
                Lbs.Items.Add("USER " + txtUser.Text);
                Lbs.Items.Add(sendFTPcmd("USER " + txtUser.Text + "\r\n"));
                Lbs.Items.Add("PASS ***");
                Lbs.Items.Add(sendFTPcmd("PASS " + txtPass.Text + "\r\n"));
                ATlist();
                if (Lbs.Items[4].ToString().Substring(0, 3) != "230")
                {
                    //no code
                }
            }
            catch (Exception)
            {
                Lbs.Items.Add("Kiểm... ");
                Lbs.Items.Add("Kiểm tra... ");
                Lbs.Items.Add("Kiểm tra lại...");
                Lbs.Items.Add("Kiểm tra lại Host DM");
            }
            String sel = "Select * from [QLUSER].[dbo].[login_check]";
            SqlCommand cmd1 = new SqlCommand(sel, sqlCon);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            int count = 1;
            while (reader1.Read())
            {
                count++;
            }

            reader1.Close();
            reader1.Dispose();
            String selfolder = "Select * from [QLUSER].[dbo].[login_check] where [TK] ='" + txtUser.Text + "'and [Pass] ='" + txtPass.Text + "'";
            SqlCommand cmd1folder = new SqlCommand(selfolder, sqlCon);
            SqlDataReader reader1f = cmd1folder.ExecuteReader();
            int countf = 0;
            while (reader1f.Read())
            {
                countf++;

            }
            reader1f.Close();
            reader1f.Dispose();
            if (countf <= 0 && (Lbs.Items[4].ToString().Substring(0, 3) == "230"))
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "insert into [QLUSER].[dbo].[login_check] values (" + count + ",'" + txtUser.Text + "','" + txtPass.Text + "','"+txtHost.Text+"') ";
                Lbs.Items.Add(sqlCmd.CommandText);
                sqlCmd.Connection = sqlCon;
                try
                {
                    int kq = sqlCmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        Lbs.Items.Add("Thêm dữ liệu thành công");
                        this.timer.Enabled = true;
                        ATlist();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Lbs.Items.Add("Thêm dữ liệu thất bại!");
                    ATlist();
                }
            }
            else {
                Lbs.Items.Add("Thêm dữ liệu thất bại! User tồn tại! hoặc Sai TK");
                ATlist();
            }
        }

        private void dgvShow_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (Convert.ToString(dgvShow.Rows[e.RowIndex].Cells[0].Value).Contains("."))
                {
                    return;
                }
                else
                {
                    string[] files = client.getFilesOnServer(dgvShow.Rows[e.RowIndex].Cells[0].Value.ToString());
                    dgvShow.Rows.Clear();
                    foreach (string file in files)
                    {
                        dgvShow.Rows.Add(file);
                    }
                }
            }
            catch (Exception)
            {
                Lbs.Items.Add("Folder Empty!");
                ATlist();
            }
             
        }

        private void btnFsql_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                Lbs.Items.Add("Login Please!");
                ATlist();
            }
            else
            {
                Form3 fr3 = new Form3();
                fr3.ShowDialog();
            }
        }

        public void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }
        private void btnBg_Click(object sender, EventArgs e)
        {
            ExecuteAsAdmin("C:/Program Files (x86)/FTPClient/Data/OnService.bat");
            Application.Exit();
            
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            ExecuteAsAdmin("C:/Program Files (x86)/FTPClient/Data/OffService.bat");
        }
    }
}
