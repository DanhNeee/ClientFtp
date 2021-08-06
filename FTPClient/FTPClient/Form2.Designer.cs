namespace FTPClient
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaTL,
            this.GiaTri,
            this.DonVi,
            this.NgayThang,
            this.TrangThai});
            this.dgv.Location = new System.Drawing.Point(2, 32);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(691, 224);
            this.dgv.TabIndex = 21;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "Stt_QTMT";
            this.STT.FillWeight = 42.4058F;
            this.STT.HeaderText = "So TT";
            this.STT.Name = "STT";
            // 
            // MaTL
            // 
            this.MaTL.DataPropertyName = "MaTaiLieu";
            this.MaTL.FillWeight = 92.6617F;
            this.MaTL.HeaderText = "Ma TL";
            this.MaTL.Name = "MaTL";
            // 
            // GiaTri
            // 
            this.GiaTri.DataPropertyName = "GiaTri";
            this.GiaTri.FillWeight = 143.8769F;
            this.GiaTri.HeaderText = "Gia Tri";
            this.GiaTri.Name = "GiaTri";
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.FillWeight = 85.44505F;
            this.DonVi.HeaderText = "Don Vi";
            this.DonVi.Name = "DonVi";
            // 
            // NgayThang
            // 
            this.NgayThang.DataPropertyName = "NgayThang";
            this.NgayThang.FillWeight = 144.24F;
            this.NgayThang.HeaderText = "Ngay Thang";
            this.NgayThang.Name = "NgayThang";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.FillWeight = 91.37057F;
            this.TrangThai.HeaderText = "Trang Thai";
            this.TrangThai.Name = "TrangThai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "DỮ LIỆU TRONG CƠ SỞ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "SQL Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label label1;
    }
}