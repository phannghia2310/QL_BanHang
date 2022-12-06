using QLBanHangDB.DataLayer;
using QLBanHangDB.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.BusinessLayer
{
    class HangSXBLL
    {
        DataAccess da = new DataAccess();
        public DataTable GetListHangSX()
        {
            string select;
            select = "select * from HangSX";
            return da.GetDataTable(select);

        }
        public DataTable GetListHangSXByID(string id)
        {
            string select = "select * from HangSX where MaHangSX='" + id + "'";
            return da.GetDataTable(select);
        } 
        public void Insert(HangSX hsx)
        {
            string query;
            query = "Insert into HangSX values(N'" + hsx.MaHangSX +
                "',N'" + hsx.TenHangSX + "')";
            da.ExecuteNonQuery(query);
        }
        public void Delete(HangSX hsx)
        {
            string query;
            query = "Delete from HangSX where MaHangSX=N'" + hsx.MaHangSX + "'";
            da.ExecuteNonQuery(query);
        }
        public void Update(HangSX hsx)
        {
            string query;
            query = "Update HangSX set TenHangSX=N'" +
                hsx.TenHangSX + "' where MaHangSX=N'" + hsx.MaHangSX + "'";
            da.ExecuteNonQuery(query);
        }
        public DataTable Search(HangSX hsx)
        {
            string condition = "";
            string select;
            if (hsx.MaHangSX != "")
                condition = condition + " MaHangSX like N'%" + hsx.MaHangSX + "%' and";
            if (hsx.TenHangSX != "")
                condition = condition + " TenHangSX like N'%" + hsx.TenHangSX + "%' and";
            condition = condition.Remove(condition.Length - 3, 3);
            select = "Select * from HangSX where " + condition; 
            return da.GetDataTable(select);
        }
    }
}
