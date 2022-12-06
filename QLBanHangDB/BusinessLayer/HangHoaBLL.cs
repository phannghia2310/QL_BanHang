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
    class HangHoaBLL
    {
        DataAccess da = new DataAccess();
        public DataTable GetListMatHang()
        {
            string select = "Select hh.MaHang, hh.TenHang, hh.DVT, hh.DonGia, hh.VAT," +
                                    " nh.TenNhomHang, hsx.TenHangSX from HangHoa hh, NhomHang nh, HangSX hsx" +
                                    " where hh.MaHangSX = hsx.MaHangSX and hh.MaNhomHang = nh.MaNhomHang";
            
            return da.GetDataTable(select);
        }
        public DataTable GetMatHangById(string id)
        {
            string select = "Select hh.MaHang, hh.TenHang, hh.DVT, hh.DonGia, hh.VAT," +
                                    " nh.TenNhomHang, hsx.TenHangSX from HangHoa hh, NhomHang nh, HangSX hsx" +
                                    " where hh.MaHangSX=hsx.MaHangSX and hh.MaNhomHang=nh.MaNhomHang" +
                                    " and hh.MaHang='" + id + "'";

            return da.GetDataTable(select);
        }
        public DataTable GetLoHang(string MaHang)
        {
            string select = "select SoLo,ConLai from View_TonLoHang where MaHang='" + MaHang + "'" +
                                                        "Order by SoLo";
            return da.GetDataTable(select);
        }
        public DataTable GetSLLoHang(string MaHang, string SoLo)
        {
            string select = "select ConLai from View_TonLoHang where MaHang='" + MaHang + "'" +
                                                        "and SoLo='" + SoLo + "'";
            return da.GetDataTable(select);
        }

        public void Insert(HangHoa hh)
        {
            string query = "Insert into HangHoa Values(N'" + hh.MaHang + "'" +
                                                    ",N'" + hh.MaNhomHang + "'" +
                                                    ",N'" + hh.MaHangSX + "'" +
                                                    ",N'" + hh.TenHang + "'" +
                                                    ",N'" + hh.DVT + "'" +
                                                    ",'" + hh.DonGia + "'" +
                                                    ",'" + hh.VAT + "')";
            da.ExecuteNonQuery(query);

        }
        public void Update(HangHoa hh)
        {
            string query = "Update HangHoa Set MaNhomHang=N'" + hh.MaNhomHang + "'" +
                                           ",MaHangSX=N'" + hh.MaHangSX + "'" +
                                           ",TenHang=N'" + hh.TenHang + "'" +
                                           ",DVT=N'" + hh.DVT + "'" +
                                           ",DonGia='" + hh.DonGia + "'" +
                                           ",VAT='" + hh.VAT + "'";
            da.ExecuteNonQuery(query);
        }
        public void Delete(HangHoa hh)
        {
            string query = "Delete  from HangHoa Where MaHang='" + hh.MaHang + "'";
            da.ExecuteNonQuery(query);
        }
        public DataTable Search(HangHoa hh)
        {
            string condition = "";
            if (hh.MaHang != "")
                condition = condition + " hh.MaHang like N'%" + hh.MaHang + "%' and";
            if (hh.TenHang != "")
                condition = condition + " hh.TenHang like N'%" + hh.TenHang + "%' and";
            if (hh.DVT != "")
                condition = condition + " hh.DVT=N'" + hh.DVT + "' and";
            //lỗi
            //if (hh.MaNhomHang != "")
            //    condition = condition + " hh.MaNhomHang=N'" + hh.MaNhomHang + "' and";
            //if (hh.MaHangSX != "")
            //    condition = condition + " hh.MaHangSX=N'" + hh.MaHangSX + "' and";
            condition = condition.Remove(condition.Length - 3, 3);
            string select = "Select hh.MaHang, hh.TenHang, hh.DVT, hh.DonGia, hh.VAT," +
                                    " hsx.TenHangSX, nh.TenNhomHang from HangHoa hh, NhomHang nh, HangSX hsx" +
                                    " where hh.MaHangSX=hsx.MaHangSX and hh.MaNhomHang=nh.MaNhomHang and" + condition;

            return da.GetDataTable(select);
        }
    }
}
