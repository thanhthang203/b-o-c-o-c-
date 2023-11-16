using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
            Application.Exit();
        }

        private void mnuLoaihang_Click(object sender, EventArgs e)
        {
            frmLoaiHang frmLoaiHang = new frmLoaiHang();
            frmLoaiHang.ShowDialog(); 

        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanvien frmNhanVien = new frmNhanvien();
            frmNhanVien.ShowDialog();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.ShowDialog();
        }

        private void mnuHanghoa_Click(object sender, EventArgs e)
        {
            frmHang frmHang = new frmHang();
            frmHang.ShowDialog();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.ShowDialog();
        }
    }
}
