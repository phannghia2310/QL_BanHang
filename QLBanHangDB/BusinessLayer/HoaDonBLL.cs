using QLBanHangDB.DataLayer;
using QLBanHangDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.BusinessLayer
{
    class HoaDonBLL
    {
        DataAccess da = new DataAccess();

        public void Insert(HoaDonBanHang hd)
        {

            string query;
            query = " Insert into HoaDonBanHang values('" + hd.MaHD +
                                              "','" + hd.MaKH +
                                              "','" + hd.MaNV +
                                              "',convert(datetime,'" + hd.NgayBan + "',101) " +
                                              "','" + hd.TongTienHD +
                                              "')";

            da.ExecuteNonQuery(query);

            foreach (ChiTietHoaDon ct in hd.ListCTHoaDon)
            {
                string query1;
                query1 = "Insert into ChiITietHoaDon Values ('" + ct.MaHD +
                                                            "','" + ct.MaHang +
                                                            "','" + ct.GiaBan +
                                                            "','" + ct.SoLuong +
                                                            "','" + ct.VAT +
                                                            "','" + ct.ThanhTien +
                                                            "')";

                da.ExecuteNonQuery(query1);
            }

        }
        public DataTable GetListHoaDon()
        {
            string select = "Select * from HoaDonBanHang";
            return da.GetDataTable(select);
        }
        public DataTable GetListHoaDonByID(string mahd)
        {
            string select = "Select * from HoaDonBanHang where MaHD='" + mahd + "'";
            return da.GetDataTable(select);
        }

        public DataTable GetListHoaDonByDate(string TuNgay, string DenNgay)
        {
            string select = "Select * from HoaDonBanHang where" +
                              " convert(datetime,NgayBan,101) between convert(datetime,'" + TuNgay +
                              "',101) and convert(datetime,'" + DenNgay +
                              "',101)";
            return da.GetDataTable(select);
        }

        public DataTable GetListHoaDonByMaKH(string MaKH)
        {
            string select = "Select * from HoaDonBanHang where" +
                              " MaKH='" + MaKH + "'";
            return da.GetDataTable(select);
        }

        public DataTable GetListHoaDonByMaNV(string MaNV)
        {
            string select = "Select * from HoaDonBanHang where" +
                              " MaNV='" + MaNV + "'";
            return da.GetDataTable(select);
        }
        public void Delete(string MaHD)
        {
            string query;
            query = "Delete from ChiTietHoaDon where MaHD='" + MaHD + "' ;" +
                    " Delete from HoaDonBanHang where MaHD='" + MaHD + "'";
            da.ExecuteNonQuery(query);
        }
        public void UpdateNguoiLapHD(string MaHD, string MaNV)
        {
            string query = "Update HoaDonBanHang Set MaNV='" + MaNV + "'" +
                            " where MaHD='" + MaHD + "'";
            da.ExecuteNonQuery(query);
        }
        public void Update(string MaHD, string MaNV, string TongTienHD)
        {
            string query = "Update HoaDonBanHang Set MaNV='" + MaNV + "'," +
                                                    " TongTienHD='" + TongTienHD + "'" +
                                                " where MaHD='" + MaHD + "'";
            da.ExecuteNonQuery(query);
        }
    }
}
