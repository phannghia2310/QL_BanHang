using QLBanHangDB.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLBanHangDB.Forms
{
    public partial class frmChartMoney : Form
    {
        SqlConnection cnn = new SqlConnection(DataAccess.strConnection);
        string currentMonth;
        public frmChartMoney(string _currentMonth)
        {
            InitializeComponent();
            this.currentMonth = _currentMonth;
            ChartMoneydaybyDate();
        }
        private void ChartMoneydaybyDate()
        {
            chart1.Series["Series1"].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM";
            DataSet ds = new DataSet();
            if(cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select CAST(NgayBan AS DATE) as Ngay, sum(TongTienHD) AS tien from HoaDonBanHang where MONTH(NgayBan) = '" + currentMonth + "' group by CAST(NgayBan AS DATE) ORDER by CAST(NgayBan AS DATE)", cnn);
            sqlDataAdapter.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["Series1"].XValueMember = "Ngay";
            chart1.Series["Series1"].YValueMembers = "tien";
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            cnn.Close();
        }
    }
}
