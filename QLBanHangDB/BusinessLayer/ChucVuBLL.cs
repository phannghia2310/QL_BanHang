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
    class ChucVuBLL
    {
        DataAccess da = new DataAccess();
        public DataTable GetListChucVu()
        {
            string select;
            select = "select * from ChucVu";
            return da.GetDataTable(select);

        }
        public DataTable GetChucVuById(string id)
        {
            string select;
            select = "Select cv.MaCV, cv.TenCV from ChucVu cv where cv.MaCV='" + id + "'";
            return da.GetDataTable(select);
        }
        public void Insert(ChucVu cv)
        {
            string query;
            query = "Insert into ChucVu values(N'" + cv.MaCV + "',N'" + cv.TenCV + "')";
            da.ExecuteNonQuery(query);
        }
        public void Delete(ChucVu cv)
        {
            string query;
            query = "Delete from ChucVu where MaCV=N'" + cv.MaCV + "'";
            da.ExecuteNonQuery(query);
        }
        public void Update(ChucVu cv)
        {
            string query;
            query = "Update ChucVu set TenCV=N'" + cv.TenCV + "' where MaCV=N'" + cv.MaCV + "'";
            da.ExecuteNonQuery(query);
        }
        public DataTable Search(ChucVu cv, string MaCV, string TenCV)
        {
            string condition = "";
            string select;
            if (MaCV != "")
                condition = condition + " MaCV like N'%" + cv.MaCV + "%' and";
            if (TenCV != "")
                condition = condition + " TenCV like N'%" + cv.TenCV + "%' and";
            condition = condition.Remove(condition.Length - 3, 3);
            select = "Select * from ChucVu where " + condition;
            return da.GetDataTable(select);
        }
    }
}
