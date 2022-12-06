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
    class QuyenDangNhapBLL
    {
        DataAccess da = new DataAccess();
        public void Insert(QuyenDangNhap us)
        {
            string query = "Insert into QuyenDangNhap values(N'" + us.TenDangNhap + "','" + us.MaNV + "','" + us.MaCV + "',N'" + us.MatKhau + "')";
            da.ExecuteNonQuery(query);
        }
        public DataTable GetListUser()
        {
            string select = "Select * from QuyenDangNhap";
            return da.GetDataTable(select);
        }
        public bool ExistUser(QuyenDangNhap us)
        {
            string sql = "Select * from QuyenDangNhap where TenDangNhap=N'" + us.TenDangNhap + "' and MatKhau=N'" + us.MatKhau + "'";
            if (da.GetDataTable(sql).Rows.Count > 0)
            {
                UserLogin.TenDangNhap = da.GetDataTable(sql).Rows[0]["TenDangNhap"].ToString();
                UserLogin.MaCV = da.GetDataTable(sql).Rows[0]["MaCV"].ToString();
                UserLogin.MatKhau = da.GetDataTable(sql).Rows[0]["MatKhau"].ToString();
                SqlHelper.MaCV = Convert.ToInt32(UserLogin.MaCV); 
                return true;
            }
            else
                return false;
        }
        public bool ExistUser(string TenDangNhap)
        {
            string sql = "Select * from QuyenDangNhap where TenDangNhap=N'" + TenDangNhap + "'";
            if (da.GetDataTable(sql).Rows.Count != 0)
            {
                return true;
            }
            else
                return false;
        }
        public void ChangePassword(string NewPassword)
        {
            string query = "Update QuyenDangNhap set MatKhau=N'" + NewPassword + "' where TenDangNhap=N'" + UserLogin.TenDangNhap + "'";
            UserLogin.MatKhau = NewPassword;
            da.ExecuteNonQuery(query);
        }
        public void Update(QuyenDangNhap us)
        {
            string query = "Update QuyenDangNhap set MatKhau=N'" + us.MatKhau+ "', MaNV='" + us.MaNV + "', MaCV='" + us.MaCV + "' where TenDangNhap=N'" + us.TenDangNhap + "'";
            da.ExecuteNonQuery(query);
        }
        public void Delete(QuyenDangNhap us)
        {
            string query = "Delete  from QuyenDangNhap Where TenDangNhap=N'" + us.TenDangNhap + "'";
            da.ExecuteNonQuery(query);
        }
        public DataTable Search(QuyenDangNhap us, string tenDangNhap, string matKhau, string maNV, string maCV)
        {
            string condition = "";
            if (tenDangNhap != "")
                condition += " TenDangNhap like N'%" + us.TenDangNhap + "%' and";
            if (matKhau != "")
                condition += " MatKhau like N'%" + us.MatKhau + "%' and";
            if (maNV != "")
                condition += " MaNV = '" + us.MaNV + "' and";
            if (maCV != "")
                condition += " MaCV = '" + us.MaCV + "' and";
            condition = condition.Remove(condition.Length - 3, 3);
            string select = "Select * from QuyenDangNhap Where" + condition; 
            return da.GetDataTable(select);
        }
    }
}
