using QuanLyBanHang.DataAccessLayer;
using QuanLyBanHang.Reporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBanHang
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            HienThiTKDT();
            
        }

        private void HienThiTKDT()
        {
            using (var _dbContext = new QuanLyBanHangDbContext())
            {
                string truyvanSQL = "Select b.MaHDBan, a.MaKhach, TenKhach, c.MaHang, TenHang, NgayBan From dbo.tblKhach a, dbo.tblHDBan b, dbo.tblHang c, dbo.tblChiTietHDBan d Where a.MaKhach = b.MaKhach and c.MaHang = d.MaHang and b.MaHDBan = d.MaHDBan";
                List<ThongKeDaonhThu> doanhthu = _dbContext.Database.SqlQuery<ThongKeDaonhThu>(truyvanSQL).ToList ();

            }    
        }
    }
}
