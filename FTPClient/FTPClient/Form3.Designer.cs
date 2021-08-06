namespace FTPClient
{
    partial class Form3
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
            this.dgvShowFolder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowFolder
            // 
            this.dgvShowFolder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowFolder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.TrangThai,
            this.User_id});
            this.dgvShowFolder.Location = new System.Drawing.Point(2, 43);
            this.dgvShowFolder.Name = "dgvShowFolder";
            this.dgvShowFolder.Size = new System.Drawing.Size(736, 158);
            this.dgvShowFolder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder đã đọc files";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name_folder";
            this.Name.FillWeight = 148.7661F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "Trang_thai";
            this.TrangThai.FillWeight = 36.12616F;
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            // 
            // User_id
            // 
            this.User_id.DataPropertyName = "id_login";
            this.User_id.FillWeight = 52.33622F;
            this.User_id.HeaderText = "User_id";
            this.User_id.Name = "User_id";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShowFolder);
            //this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowFolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_id;
    }
}