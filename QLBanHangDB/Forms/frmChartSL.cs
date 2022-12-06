using QLBanHangDB.DataLayer;
using QLBanHangDB.Entities;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace QLBanHangDB.Forms
{
    public partial class frmChartSL : Form
    {
        SqlConnection cnn = new SqlConnection(DataAccess.strConnection);
        string currentMonth;
        public frmChartSL(string _currentMonth)
        {
            InitializeComponent();
            this.currentMonth = _currentMonth;
            ChartSLSPdaybydate();
        }
        private void ChartSLSPdaybydate()
        {
            chart1.Series["Series1"].XValueType = ChartValueType.DateTime;
            chart1.Series["Series1"].YValueType = ChartValueType.Int32;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM";
            DataSet ds = new DataSet();
            cnn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select cast(NgayBan as date) as Ngay, sum(cast(SoLuong as int)) as SL from HoaDonBanHang, ChiTietHoaDon " +
                                                        "where HoaDonBanHang.MaHD = ChiTietHoaDon.MaHD and month(NgayBan) = '" + currentMonth + "'" +
                                                        "group by cast(NgayBan as date) order by cast(NgayBan as date)", cnn);
            adapt.Fill(ds);
            chart1.DataSource = ds; 
            chart1.Series["Series1"].XValueMember = "Ngay";
            chart1.Series["Series1"].YValueMembers = "SL";
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            cnn.Close();
        }
    }
}
