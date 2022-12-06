using FontAwesome.Sharp;
using QLBanHangDB.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace QLBanHangDB.Forms
{
    public partial class frmDashBoard : Form
    {
        SqlConnection cnn = new SqlConnection(DataAccess.strConnection);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        SqlDataAdapter ada;
        DataAccess da = new DataAccess();
        private Form activeForm;
        public frmDashBoard()
        {
            InitializeComponent();
        }
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Chart.Controls.Add(childForm);
            panel_Chart.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void doanhsobanhang()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                // SqlCommand cmdCountTongHD = new SqlCommand("select COUNT(IDhoadon) from HoaDon", connect);
                SqlCommand cmdCountTongHDThang = new SqlCommand("SELECT count( MONTH([NgayBan])) as Thang from HoaDonBanHang where MONTH(NgayBan) = '" + num_Thang.Value.ToString() + "'", cnn);
                SqlCommand cmdCountHDToday = new SqlCommand("select count(MaHD) from HoaDonBanHang where cast ([NgayBan] as date) = cast(getdate() as date)", cnn);
                SqlCommand cmdCountTongTienThang = new SqlCommand("select sum(TongTienHD) from HoaDonBanHang where MONTH(NgayBan) = '" + num_Thang.Value.ToString()+ "'", cnn);
                SqlCommand cmdCountTienToday = new SqlCommand("select sum(TongTienHD) from HoaDonBanHang where cast ([NgayBan] as date) = cast(getdate() as date)", cnn);
                SqlCommand cmdCountDistinctMasp = new SqlCommand("SELECT COUNT(DISTINCT value) FROM HoaDonBanHang, ChiTietHoaDon CROSS APPLY STRING_SPLIT(MaHang, ',') " +
                                                                                                    "where HoaDonBanHang.MaHD=ChiTietHoaDon.MaHD and MONTH(NgayBan) = '" + num_Thang.Value.ToString()+ "'", cnn);
                SqlCommand cmdCountDistinctMaspToday = new SqlCommand("SELECT COUNT(DISTINCT value) FROM HoaDonBanHang, ChiTietHoaDon CROSS APPLY STRING_SPLIT(MaHang, ',') " +
                    "                                                                                       where HoaDonBanHang.MaHD=ChiTietHoaDon.MaHD " +
                                                                                                                  "and cast([NgayBan] as date) = cast(getdate() as date) ", cnn);

                int CountTongHD = Convert.ToInt32(cmdCountTongHDThang.ExecuteScalar());
                int CountHDtoday = Convert.ToInt32(cmdCountHDToday.ExecuteScalar());
                var CountTongTienThang = (cmdCountTongTienThang.ExecuteScalar());
                var CountTienToday = (cmdCountTienToday.ExecuteScalar());
                int CountDistinctMasp = Convert.ToInt32(cmdCountDistinctMasp.ExecuteScalar());
                int CountDistinctMaspToday = Convert.ToInt32(cmdCountDistinctMaspToday.ExecuteScalar());
                if (CountTienToday == DBNull.Value)
                {
                    lbDoanhSoToday.Text = "Hôm nay: " + 0;
                }
                else
                {
                    lbDoanhSoToday.Text = "Hôm nay: " + CountTienToday.ToString();
                }
                if (CountTongTienThang == DBNull.Value)
                {
                    lbTongDoanhSo.Text = "0";
                    lbDoanhSoToday.Text = "Hôm nay: " + 0;
                }
                else
                {
                    lbTongDoanhSo.Text = CountTongTienThang.ToString();
                }
                lbSumHD.Text = CountTongHD.ToString();
                lbHDtoday.Text = "Hôm nay: " + CountHDtoday.ToString();
                lbSumSP.Text = CountDistinctMasp.ToString();
                lbSPtoday.Text = "Hôm nay: " + CountDistinctMaspToday.ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!" + ex.Message);
                cnn.Close();
            }
        }
        private void tongslsptrongkho()
        {
            try
            {
                string sql = "Select * from VW_TongTonHang";
                DataTable table = da.GetDataTable(sql);
                lbTongSP.Text = table.Rows[0]["HangTon"].ToString();
                string sql1 = "select sum(ct.SoLuong) as TongNhapHomNay " +
                        "FROM ChiTietPhieuNhap ct, PhieuNhap pn where ct.MaPN=pn.MaPN and cast([NgayNhap] as date )  = cast(getdate() as date)";
                DataTable table1 = da.GetDataTable(sql1);
                string tongHomNay = table1.Rows[0]["TongNhapHomNay"].ToString();
                if(tongHomNay == null || tongHomNay == "")
                {
                    tongHomNay = "0";
                }
                lbNhapKhoToday.Text = "Nhập kho hôm nay: " + tongHomNay + " sản phẩm";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loaisptrongkho()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                SqlCommand cmdCountLoaiSPTrongkho = new SqlCommand("select count(distinct value) as TongLoaiHang from ChiTietPhieuNhap ct CROSS APPLY STRING_SPLIT(MaHang, ',')", cnn);
                int CountCountLoaiSPTrongkho = Convert.ToInt32(cmdCountLoaiSPTrongkho.ExecuteScalar());
                lbTongLoaiSp.Text = CountCountLoaiSPTrongkho.ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            doanhsobanhang();
            tongslsptrongkho();
            loaisptrongkho();
        }
        private void btnChartMoney_Click(object sender, EventArgs e)
        {
            openChildForm(new frmChartMoney(num_Thang.Value.ToString()));
        }
        private void btnChartSL_Click(object sender, EventArgs e)
        {
            openChildForm(new frmChartSL(num_Thang.Value.ToString()));
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            
            //doanhsobanhang();
            //tongslsptrongkho();
            //loaisptrongkho();
            openChildForm(new frmChartMoney(DateTime.Now.Month.ToString()));

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
