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
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmTimKiemKH : Form
    {
        DataTable tblKH; // khách hàng
        public frmTimKiemKH()
        {
           
            InitializeComponent();
        }

        private void frmTimKiemKH_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvDanhSachKH.DataSource = null;
        }

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaKhach.Focus();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaKhach.Text == "") && (txtTenKhach.Text == "") && (txtDiaChi.Text == "") &&
               (mtbDienThoai.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblKhach WHERE 1=1";
            if (txtMaKhach.Text != "")
                sql = sql + " AND MaKhach Like N'%" + txtMaKhach.Text + "%'";
          
            if (txtTenKhach.Text != "")
                sql = sql + " AND TenKhach Like N'%" + txtTenKhach.Text + "%'";
            if (txtDiaChi.Text != "")
                sql = sql + " AND DiaChi Like N'%" + txtDiaChi.Text + "%'";
            if (mtbDienThoai.Text != "")
                sql = sql + " AND DienThoai <=" + mtbDienThoai.Text;
            tblKH = Functions.GetDataToTable(sql);
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblKH.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvDanhSachKH.DataSource = tblKH;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            
                dgvDanhSachKH.Columns[0].HeaderText = "Mã Khách hàng";
                dgvDanhSachKH.Columns[1].HeaderText = "Tên Khách hàng";
                dgvDanhSachKH.Columns[2].HeaderText = "Địa chỉ";
                dgvDanhSachKH.Columns[3].HeaderText = "Điện thoại";
                dgvDanhSachKH.Columns[0].Width = 150;
                dgvDanhSachKH.Columns[1].Width = 100;
                dgvDanhSachKH.Columns[2].Width = 80;
                dgvDanhSachKH.Columns[3].Width = 80;
                dgvDanhSachKH.AllowUserToAddRows = false;
                dgvDanhSachKH.EditMode = DataGridViewEditMode.EditProgrammatically;
            
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvDanhSachKH.DataSource = null;
        }

       
    }
}
