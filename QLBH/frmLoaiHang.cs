using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBH.Class;

namespace QLBH
{
    public partial class frmLoaiHang : Form
    {
        DataTable tblLH;
        public frmLoaiHang()
        {
            InitializeComponent();
        }

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            txtMaLoaiHang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatLieu
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaLoaiHang, TenLoaiHang FROM LoaiHang";
            tblLH = Class.Functions.GetDataToTable(sql); 
            dgvLoaiHang.DataSource = tblLH;          
            dgvLoaiHang.Columns[0].HeaderText = "Mã loại hàng";
            dgvLoaiHang.Columns[1].HeaderText = "Tên loại hàng";
            dgvLoaiHang.Columns[0].Width = 100;
            dgvLoaiHang.Columns[1].Width = 300;
            dgvLoaiHang.AllowUserToAddRows = false;
            dgvLoaiHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiHang.Focus();
                return;
            }
            if (tblLH.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaLoaiHang.Text = dgvLoaiHang.CurrentRow.Cells["MaLoaiHang"].Value.ToString();
            txtTenLoaiHang.Text = dgvLoaiHang.CurrentRow.Cells["TenLoaiHang"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaLoaiHang.Enabled = true; //cho phép nhập mới
            txtMaLoaiHang.Focus();
        }
        private void ResetValue()
        {
            txtMaLoaiHang.Text = "";
            txtTenLoaiHang.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaLoaiHang.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiHang.Focus();
                return;
            }
            if (txtTenLoaiHang.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiHang.Focus();
                return;
            }
            sql = "Select MaLoaiHang From LoaiHang where MaLoaiHang=N'" + txtMaLoaiHang.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã loại hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoaiHang.Focus();
                return;
            }

            sql = "INSERT INTO LoaiHang VALUES(N'" +
                txtMaLoaiHang.Text + "',N'" + txtTenLoaiHang.Text + "')";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaLoaiHang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; 
            if (tblLH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLoaiHang.Text == "") 
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLoaiHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE LoaiHang SET TenLoaiHang=N'" +
                txtTenLoaiHang.Text.ToString() +
                "' WHERE MaLoaiHang=N'" + txtMaLoaiHang.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLoaiHang.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE LoaiHang WHERE MaLoaiHang=N'" + txtMaLoaiHang.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtTenLoaiHang.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
