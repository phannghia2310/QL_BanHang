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
    class NganhHangBLL
    {
        DataAccess da = new DataAccess();
        public DataTable GetListNganhHang()
        {
            string select;
            select = "select * from NganhHang";
            return da.GetDataTable(select);
        }
        public DataTable GetListNganhHangByID(string id)
        {
            string select = "Select * from NganHang where MaNganhHang='" + id + "'";
            return da.GetDataTable(select);
        }
        public void Insert(NganhHang ngh)
        {
            string query;
            query = "Insert into NganhHang values(N'" + ngh.MaNganhHang +
                "',N'" + ngh.TenNganhHang + "')";
            da.ExecuteNonQuery(query);
        }
        public void Delete(NganhHang ngh)
        {
            string query;
            query = "Delete from NganhHang where MaNganhHang=N'" + ngh.MaNganhHang + "'";
            da.ExecuteNonQuery(query);
        }
        public void Update(NganhHang ngh)
        {
            string query;
            query = "Update NganhHang set TenNganhHang=N'" +
                ngh.TenNganhHang + "' where MaNganhHang=N'" + ngh.MaNganhHang + "'";
            da.ExecuteNonQuery(query);
        }
        public DataTable Search(NganhHang ngh)
        {
            string condition = "";
            string select;
            if(ngh.MaNganhHang != "")
                condition = condition + " MaNganhHang like N'%" + ngh.MaNganhHang + "%' and";
            if(ngh.TenNganhHang != "")
                condition = condition + " TenNganhHang like N'%" + ngh.TenNganhHang + "%' and";
            condition = condition.Remove(condition.Length - 3, 3);
            select = "Select * from NganhHang where " + condition;
            return da.GetDataTable(select);
        }
    }
}
