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
    class NhanVienBLL
    {
        DataAccess da = new DataAccess();
        public DataTable GetListNhanVien()
        {
            string select;
            select = "Select nv.MaNV, nv.TenNV, nv.MaQL, nv.GioiTinh, nv.NgaySinh," +
                " nv.DiaChi, nv.SDT, cv.TenCV from NhanVien nv, ChucVu cv where nv.MaCV = cv.MaCV";
            return da.GetDataTable(select);
        }
        public DataTable GetMaQuanLyByID(string id)
        {
            string select;
            select = "select distinct nv.MaQL from NhanVien nv Where nv.MaCV='" + id + "'";
            return da.GetDataTable(select);
        }
        public DataTable GetListNhanVienBanHang()
        {
            string select;
            select = "Select nv.MaNV,nv.TenNV,nv.MaQL,nv.GioiTinh,nv.NgaySinh," +
                 "nv.DiaChi,nv.SDT, cv.TenCV from NhanVien nv, ChucVu cv " +
                 "where nv.MaCV = cv.MaCV and cv.MaCV in('06','07')";
            return da.GetDataTable(select);
        }
        public DataTable GetListNhanVienNhapHang()
        {
            string select;
            select = "Select nv.MaNV,nv.TenNV,nv.MaQL,nv.GioiTinh,nv.NgaySinh," +
                 "nv.DiaChi,nv.SDT, cv.TenCV from NhanVien nv, ChucVu cv " +
                 "where nv.MaCV = cv.MaCV and cv.MaCV in ('02','03')";
            return da.GetDataTable(select);
        }
        public DataTable GetNhanVienById(string id)
        {
            string select;
            select = "Select nv.MaNV,nv.TenNV,nv.MaQL,nv.GioiTinh,nv.NgaySinh," +
                "nv.DiaChi,nv.SDT from NhanVien nv, ChucVu cv where nv.MaCV = cv.MaCV"
                + " and MaNV='" + id + "'";
            return da.GetDataTable(select);
        }
        public string GetMaxNhanVienID()
        {
            string MaNV = "";
            string select = "select top 1 MaNV from NhanVien order by MaNV DESC ";
            if (da.GetDataTable(select).Rows.Count == 1)
            {
                return MaNV = da.GetDataTable(select).Rows[0]["MaNV"].ToString();
            }
            else
                return MaNV;
        }
        public void Insert(NhanVien nv)
        {
            string query;
            query = "Insert into NhanVien Values ('" + nv.MaNV + "','" +
                                                       nv.MaCV + "','" +
                                                       nv.MaQL + "','" +
                                                       nv.TenNV + "',N'" +
                                                       nv.GioiTinh + "', convert(datetime,'" +
                                                       nv.NgaySinh + "',101),N'" +
                                                       nv.DiaChi + "','" +
                                                       nv.SDT + "')";
            da.ExecuteNonQuery(query);
        }
        public void Delete(NhanVien nv)
        {
            string query;
            query = "Delete from NhanVien where MaNV='" + nv.MaNV + "'";
            da.ExecuteNonQuery(query);
        }
        public void Update(NhanVien nv)
        {
            string query;
            query = "Update NhanVien set TenNV=N'" + nv.TenNV + "'," +
                                        "MaCV='" + nv.MaCV + "'," +
                                        "MaQL='" + nv.MaQL + "'," +
                                        "GioiTinh=N'" + nv.GioiTinh + "'," +
                                        "NgaySinh= convert(datetime,'" + nv.NgaySinh + "',101)," +
                                        "DiaChi=N'" + nv.DiaChi + "'," +
                                        "SDT='" + nv.SDT + "'" +
                                    " where MaNV='" + nv.MaNV + "'";

            da.ExecuteNonQuery(query);
        }
        public DataTable Search(NhanVien nv)
        {
            string condition = "";
            string select;
            if (nv.MaNV != "")
                condition = condition + " nv.MaNV like N'%" + nv.MaNV + "%' and";
            if (nv.TenNV != "")
                condition = condition + " nv.TenNV like N'%" + nv.TenNV + "%' and";
            if (nv.DiaChi != "")
                condition = condition + " nv.DiaChi like N'%" + nv.DiaChi + "%' and";
            if (nv.SDT != "")
                condition = condition + " nv.SDT like N'%" + nv.SDT + "%' and";
            if (nv.GioiTinh != "")
                condition = condition + " nv.GioiTinh = N'" + nv.GioiTinh + "' and";
            //lỗi không thực thi được
            //if (nv.MaCV != "")
            //    condition += " nv.MaCV = '" + nv.MaCV + "' and";
            //if (nv.NgaySinh.Equals(DateTime.Now) == false)
            //    condition += " nv.NgaySinh like convert(datetime,'" + nv.NgaySinh + "', 101) and";
            condition = condition.Remove(condition.Length - 3, 3);
            select = "Select nv.MaNV,nv.TenNV,nv.MaQL,nv.GioiTinh,nv.NgaySinh," +
                            "nv.DiaChi, nv.SDT, cv.TenCV from NhanVien nv, ChucVu cv " +
                            "Where nv.MaCV=cv.MaCV and " + condition;
            return da.GetDataTable(select);
        }
    }
}
