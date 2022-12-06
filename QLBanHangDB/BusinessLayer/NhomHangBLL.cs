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
    class NhomHangBLL
    {
        DataAccess da = new DataAccess();
        public DataTable GetListNhomHang()
        {
            string select;
            select = "Select NhomHang.MaNhomHang, NhomHang.TenNhomHang, NganhHang.TenNganhHang from NhomHang,NganhHang " +
                " where NhomHang.MaNganhHang=NganhHang.MaNganhHang";
            return da.GetDataTable(select);
        }
        public DataTable GetNhomHangByID(string id)
        {
            string select;
            select = "Select NhomHang.MaNhomHang, NhomHang.TenNhomHang, NganhHang.TenNganhHang from NhomHang,NganhHang" +
                " where NhomHang.MaNganhHang=NganhHang.MaNganhHang and NhomHang.MaNhomHang='" + id + "'";
            return da.GetDataTable(select);
        }
        public DataTable GetListNhomHangByNganhHang(string maNganh)
        {
            string select;
            select = "Select NhomHang.MaNhomHang, NhomHang.TenNhomHang, NganhHang.TenNganhHang from NhomHang,NganhHang " +
                " where NhomHang.MaNganhHang=NganhHang.MaNganhHang and NhomHang.MaNganhHang='" + maNganh + "'";
            return da.GetDataTable(select);
        }
        public void Insert(NhomHang nh)
        {
            string query;
            query = "Insert into NhomHang values(N'" + nh.MaNhomHang +
                "',N'" + nh.MaNganhHang + "',N'" + nh.TenNhomHang + "')";
            da.ExecuteNonQuery(query);
        }
        public void Delete(NhomHang nh)
        {
            string query;
            query = "Delete from NhomHang where MaNhomHang=N'" + nh.MaNhomHang + "'";
            da.ExecuteNonQuery(query);
        }
        public void Update(NhomHang nh)
        {
            string query;
            query = "Update NhomHang set TenNhomHang=N'" +
                nh.TenNhomHang + "', MaNganhHang=N'" + nh.MaNganhHang + "' where MaNhomHang=N'" + nh.MaNhomHang + "'";
            da.ExecuteNonQuery(query);
        }
        public DataTable Search(NhomHang nh)
        {
            string condition = "";
            string select;
            if (nh.MaNhomHang != "")
                condition = condition + " NhomHang.MaNhomHang like N'%" + nh.MaNhomHang + "%' and";
            if (nh.TenNhomHang != "")
                condition = condition + " NhomHang.TenNhomHang like N'%" + nh.TenNhomHang + "%' and";
            //lỗi
            //if (nh.MaNganhHang != "")
            //    condition = condition + " NganhHang.MaNganhHang like N'%" + nh.MaNganhHang + "%' and";
            condition = condition.Remove(condition.Length - 3, 3);
            select = "Select NhomHang.MaNhomHang,NhomHang.TenNhomHang,NganhHang.TenNganhHang from NhomHang,NganhHang " +
                "where NhomHang.MaNganhHang=NganhHang.MaNganhHang and " + condition;
            return da.GetDataTable(select);
        }
    }
}
