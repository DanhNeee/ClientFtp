namespace FTPClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnread = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.Lbs = new System.Windows.Forms.ListBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowDB = new System.Windows.Forms.Button();
            this.btnUs = new System.Windows.Forms.Button();
            this.lbPhut = new System.Windows.Forms.Label();
            this.lbGiay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFsql = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBg = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(634, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(50, 14);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 5;
            this.txtHost.Text = "127.0.0.1";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(219, 14);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(387, 14);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 7;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(539, 14);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(54, 20);
            this.txtPort.TabIndex = 8;
            this.txtPort.Text = "21";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status:";
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(262, 210);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(93, 23);
            this.btnread.TabIndex = 12;
            this.btnread.Text = "Read File";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btndown
            // 
            this.btndown.Location = new System.Drawing.Point(262, 239);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(93, 23);
            this.btndown.TabIndex = 13;
            this.btndown.Text = "DownLoads File";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // Lbs
            // 
            this.Lbs.FormattingEnabled = true;
            this.Lbs.Location = new System.Drawing.Point(13, 66);
            this.Lbs.Name = "Lbs";
            this.Lbs.Size = new System.Drawing.Size(342, 95);
            this.Lbs.TabIndex = 14;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(262, 178);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(93, 23);
            this.btnGet.TabIndex = 16;
            this.btnGet.Text = "Get Files";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnDB
            // 
            this.btnDB.Location = new System.Drawing.Point(625, 331);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(93, 23);
            this.btnDB.TabIndex = 19;
            this.btnDB.Text = "Lưu vào DB";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(361, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(460, 262);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã tài liệu";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá trị";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn vị";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trạng thái";
            // 
            // ShowDB
            // 
            this.ShowDB.Location = new System.Drawing.Point(724, 331);
            this.ShowDB.Name = "ShowDB";
            this.ShowDB.Size = new System.Drawing.Size(92, 23);
            this.ShowDB.TabIndex = 22;
            this.ShowDB.Text = "Xem CSDL";
            this.ShowDB.UseVisualStyleBackColor = true;
            this.ShowDB.Click += new System.EventHandler(this.ShowDB_Click);
            // 
            // btnUs
            // 
            this.btnUs.Location = new System.Drawing.Point(736, 11);
            this.btnUs.Name = "btnUs";
            this.btnUs.Size = new System.Drawing.Size(75, 23);
            this.btnUs.TabIndex = 23;
            this.btnUs.Text = "Insert DB";
            this.btnUs.UseVisualStyleBackColor = true;
            this.btnUs.Click += new System.EventHandler(this.btnUs_Click);
            // 
            // lbPhut
            // 
            this.lbPhut.AutoSize = true;
            this.lbPhut.Location = new System.Drawing.Point(681, 41);
            this.lbPhut.Name = "lbPhut";
            this.lbPhut.Size = new System.Drawing.Size(16, 13);
            this.lbPhut.TabIndex = 24;
            this.lbPhut.Text = "...";
            // 
            // lbGiay
            // 
            this.lbGiay.AutoSize = true;
            this.lbGiay.Location = new System.Drawing.Point(718, 41);
            this.lbGiay.Name = "lbGiay";
            this.lbGiay.Size = new System.Drawing.Size(16, 13);
            this.lbGiay.TabIndex = 25;
            this.lbGiay.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(702, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = ":";
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvShow.Location = new System.Drawing.Point(12, 173);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(244, 159);
            this.dgvShow.TabIndex = 27;
            this.dgvShow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellDoubleClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name_folder";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // btnFsql
            // 
            this.btnFsql.Location = new System.Drawing.Point(263, 268);
            this.btnFsql.Name = "btnFsql";
            this.btnFsql.Size = new System.Drawing.Size(92, 41);
            this.btnFsql.TabIndex = 28;
            this.btnFsql.Text = "Xem Folder Đã Tải";
            this.btnFsql.UseVisualStyleBackColor = true;
            this.btnFsql.Click += new System.EventHandler(this.btnFsql_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "After";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(739, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Auto Connect";
            // 
            // btnBg
            // 
            this.btnBg.Location = new System.Drawing.Point(262, 331);
            this.btnBg.Name = "btnBg";
            this.btnBg.Size = new System.Drawing.Size(92, 23);
            this.btnBg.TabIndex = 31;
            this.btnBg.Text = "Chạy ngầm";
            this.btnBg.UseVisualStyleBackColor = true;
            this.btnBg.Click += new System.EventHandler(this.btnBg_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(361, 331);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(111, 23);
            this.btnOff.TabIndex = 32;
            this.btnOff.Text = "Tắt BG service";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 359);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnBg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFsql);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbGiay);
            this.Controls.Add(this.lbPhut);
            this.Controls.Add(this.btnUs);
            this.Controls.Add(this.ShowDB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.Lbs);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FTP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.ListBox Lbs;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button ShowDB;
        private System.Windows.Forms.Button btnUs;
        private System.Windows.Forms.Label lbPhut;
        private System.Windows.Forms.Label lbGiay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnFsql;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBg;
        private System.Windows.Forms.Button btnOff;
    }
}

