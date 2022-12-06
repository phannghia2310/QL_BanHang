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
using QLBanHangDB.DataLayer;

namespace QLBanHangDB.Forms
{
    public partial class frmChartSPHet : Form
    {
        SqlConnection cnn = new SqlConnection(DataAccess.strConnection);
        public frmChartSPHet()
        {
            InitializeComponent();
            SanphamSapHet();
        }
        private void SanphamSapHet()
        {

            DataSet ds = new DataSet();
            cnn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select tensp as Ten,soluongsp as SL from tonkho where  soluongsp <= 30", cnn);

            adapt.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["Series1"].XValueMember = "Ten";
            chart1.Series["Series1"].YValueMembers = "SL";
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            cnn.Close();
        }
    }
}
