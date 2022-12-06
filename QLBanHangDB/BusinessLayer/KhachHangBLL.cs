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
    class KhachHangBLL
    {
        DataAccess da = new DataAccess();
        public DataTable GetListKhachHang()
        {
            string select = "Select * from KhachHang";
            return da.GetDataTable(select);
        }
        public DataTable GetListKhachHangByID(string MaKH)
        {
            string select = "Select * from KhachHang where MaKH='" + MaKH + "'";
            return da.GetDataTable(select);
        }
        public string GetMaxKhachHangID()
        {
            string MaKhach = "";
            string select = "select top 1 MaKH from KhachHang order by MaKH DESC ";
            if (da.GetDataTable(select).Rows.Count == 1)
            {
                return MaKhach = da.GetDataTable(select).Rows[0]["MaKhH"].ToString();
            }
            else
                return MaKhach;
        }

        public void Insert(KhachHang kh)
        {
            string query = "Insert into KhachHang Values(N'" + kh.MaKH + "'" +
                                                    ",N'" + kh.TenKH + "'" +
                                                    ",N'" + kh.GioiTinh + "'" +
                                                    ",N'" + kh.DiaChi + "'" +
                                                    ",'" + kh.SDT + "')";
            da.ExecuteNonQuery(query);
        }
        public void Update(KhachHang kh)
        {
            string query = "Update KhachHang Set TenKH=N'" + kh.TenKH + "'" +
                                           ",GioiTinh=N'" + kh.GioiTinh + "'" + 
                                           ",DiaChi=N'" + kh.DiaChi + "'" +
                                           ",SDT='" + kh.SDT + "'" +
                                         " Where MaKH='" + kh.MaKH + "'";
            da.ExecuteNonQuery(query);

        }

        public void Delete(KhachHang kh)
        {
            string query = "Delete  from KhachHang Where MaKH='" + kh.MaKH + "'";
            da.ExecuteNonQuery(query);
        }
        public DataTable Search(KhachHang kh)
        {
            string condition = "";
            string select;
            if (kh.MaKH != "")
                condition = condition + " MaKH like N'%" + kh.MaKH + "%' and";
            if (kh.TenKH != "")
                condition = condition + " TenKH like N'%" + kh.TenKH + "%' and";
            if (kh.DiaChi != "")
                condition = condition + " DiaChi like N'%" + kh.DiaChi + "%' and";
            if (kh.SDT != "")
                condition = condition + " SDT like N'%" + kh.SDT + "%' and";
            if (kh.GioiTinh != "")
                condition = condition + " GioiTinh = N'" + kh.GioiTinh + "' and";
            condition = condition.Remove(condition.Length - 3, 3);
            select = "Select * from KhachHang where " + condition;
            return da.GetDataTable(select);
        }
    }
}
