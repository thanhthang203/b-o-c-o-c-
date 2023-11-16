namespace QLBH
{
    partial class frmLoaiHang
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
            this.lblTenDM = new System.Windows.Forms.Label();
            this.lblMaloaihang = new System.Windows.Forms.Label();
            this.lblTenloaihang = new System.Windows.Forms.Label();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.grpChucnang = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvLoaiHang = new System.Windows.Forms.DataGridView();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.grpChucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenDM
            // 
            this.lblTenDM.AutoSize = true;
            this.lblTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDM.ForeColor = System.Drawing.Color.Red;
            this.lblTenDM.Location = new System.Drawing.Point(304, 33);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Size = new System.Drawing.Size(322, 32);
            this.lblTenDM.TabIndex = 0;
            this.lblTenDM.Text = "DANH MỤC LOẠI HÀNG";
            // 
            // lblMaloaihang
            // 
            this.lblMaloaihang.AutoSize = true;
            this.lblMaloaihang.Location = new System.Drawing.Point(59, 101);
            this.lblMaloaihang.Name = "lblMaloaihang";
            this.lblMaloaihang.Size = new System.Drawing.Size(99, 20);
            this.lblMaloaihang.TabIndex = 1;
            this.lblMaloaihang.Text = "Mã loại hàng";
            // 
            // lblTenloaihang
            // 
            this.lblTenloaihang.AutoSize = true;
            this.lblTenloaihang.Location = new System.Drawing.Point(59, 151);
            this.lblTenloaihang.Name = "lblTenloaihang";
            this.lblTenloaihang.Size = new System.Drawing.Size(104, 20);
            this.lblTenloaihang.TabIndex = 2;
            this.lblTenloaihang.Text = "Tên loại hàng";
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(219, 101);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(157, 26);
            this.txtMaLoaiHang.TabIndex = 3;
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(219, 145);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(157, 26);
            this.txtTenLoaiHang.TabIndex = 4;
            // 
            // grpChucnang
            // 
            this.grpChucnang.Controls.Add(this.btnBoQua);
            this.grpChucnang.Controls.Add(this.btnDong);
            this.grpChucnang.Controls.Add(this.btnLuu);
            this.grpChucnang.Controls.Add(this.btnXoa);
            this.grpChucnang.Controls.Add(this.btnSua);
            this.grpChucnang.Controls.Add(this.btnThem);
            this.grpChucnang.Location = new System.Drawing.Point(63, 231);
            this.grpChucnang.Name = "grpChucnang";
            this.grpChucnang.Size = new System.Drawing.Size(313, 193);
            this.grpChucnang.TabIndex = 5;
            this.grpChucnang.TabStop = false;
            this.grpChucnang.Text = "Chức năng";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDong.Location = new System.Drawing.Point(177, 134);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 44);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(177, 84);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 44);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(67, 84);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 44);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(177, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 44);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(67, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvLoaiHang
            // 
            this.dgvLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHang.Location = new System.Drawing.Point(439, 101);
            this.dgvLoaiHang.Name = "dgvLoaiHang";
            this.dgvLoaiHang.RowHeadersWidth = 62;
            this.dgvLoaiHang.RowTemplate.Height = 28;
            this.dgvLoaiHang.Size = new System.Drawing.Size(484, 323);
            this.dgvLoaiHang.TabIndex = 6;
            this.dgvLoaiHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiHang_CellContentClick);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBoQua.Location = new System.Drawing.Point(67, 134);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 44);
            this.btnBoQua.TabIndex = 5;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // frmLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.dgvLoaiHang);
            this.Controls.Add(this.grpChucnang);
            this.Controls.Add(this.txtTenLoaiHang);
            this.Controls.Add(this.txtMaLoaiHang);
            this.Controls.Add(this.lblTenloaihang);
            this.Controls.Add(this.lblMaloaihang);
            this.Controls.Add(this.lblTenDM);
            this.Name = "frmLoaiHang";
            this.Text = "frmLoaiHang";
            this.Load += new System.EventHandler(this.frmLoaiHang_Load);
            this.grpChucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenDM;
        private System.Windows.Forms.Label lblMaloaihang;
        private System.Windows.Forms.Label lblTenloaihang;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.GroupBox grpChucnang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvLoaiHang;
        private System.Windows.Forms.Button btnBoQua;
    }
}