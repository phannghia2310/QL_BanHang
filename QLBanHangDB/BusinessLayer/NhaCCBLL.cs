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
    class NhaCCBLL
    {
        DataAccess da = new DataAccess();

        public DataTable GetListNhaCC()
        {
            string select = "Select * from NhaCungCap";
            return da.GetDataTable(select);
        }
        public DataTable GetNhaCCByID(string id)
        {
            string select = "select * from NhaCungCap where MaNCC='" + id + "'";
            return da.GetDataTable(select);
        }
        public void Insert(NhaCC ncc)
        {
            string query = "Insert into NhaCungCap values ('" + ncc.MaNCC +
                                                           "',N'" + ncc.TenNCC +
                                                           "',N'" + ncc.DiaChi +
                                                           "','" + ncc.SDT +
                                                           "','" + ncc.Fax +
                                                           "',N'" + ncc.Email + "')";
            da.ExecuteNonQuery(query);
        }
        public void Update(NhaCC ncc)
        {
            string query = "Update NhaCungCap Set TenNCC=N'" + ncc.TenNCC + "'" +
                                                 ",DiaChi=N'" + ncc.DiaChi + "'" +
                                                 ",SDT='" + ncc.SDT + "'" +
                                                 ",Fax='" + ncc.Fax + "'" +
                                                 ",Email=N'" + ncc.Email + "'" +
                                                 " where MaNCC='" + ncc.MaNCC + "'";
            da.ExecuteNonQuery(query);
        }
        public void Delete(NhaCC ncc)
        {
            string query = "Delete NhaCungCap where MaNCC='" + ncc.MaNCC + "'";
            da.ExecuteNonQuery(query);
        }
        public DataTable Search(NhaCC ncc)
        {
            string condition = "";
            string select;
            if (ncc.MaNCC != "")
                condition = condition + " MaNCC like '%" + ncc.MaNCC + "%' and";
            if (ncc.TenNCC != "")
                condition = condition + " TenNCC like N'%" + ncc.TenNCC + "%' anđ";
            if (ncc.DiaChi != "")
                condition = condition + " DiaChi like N'%" + ncc.DiaChi + "%' and";
            if (ncc.SDT != "")
                condition = condition + " SDT like '%" + ncc.SDT + "%' and";
            if (ncc.Fax != "")
                condition = condition + " Fax like '%" + ncc.Fax + "%' and";
            if (ncc.Email != "")
                condition = condition + " Email like N'%" + ncc.Email + "%' and";
            condition = condition.Remove(condition.Length - 3, 3);
            select = "Select * from NhaCungCap where " + condition;
            return da.GetDataTable(select);
        }
    }
}
