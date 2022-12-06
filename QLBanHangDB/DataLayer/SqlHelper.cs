using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.DataLayer
{
    class SqlHelper
    {
        public static int MaCV;
        public static string ConnectString = @"Data Source=DESKTOP-S8GR5NF\PHANNGHIA;Initial Catalog=QLBanHangDB;Integrated Security=True";
        public static SqlConnection cnn;
    }
}
