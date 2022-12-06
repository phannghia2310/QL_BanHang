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
    class ChiTietHoaDonBLL
    {
        DataAccess da = new DataAccess();
        public DataTable GetListChiTietHDByMaHD(string MaHD)
        {
            string select = "Select a.MaHang, a.GiaBan, a.SoLuong, a.VAT, a.ThanhTien, b.TenHang, b.DVT from ChiTietHoaDon a, HangHoa b" +
                               " where a.MaHang=b.MaHang and a.MaHD='" + MaHD + "'";
            return da.GetDataTable(select);

        }
        public DataTable GetListChiTietHDByMaHDandMaHang(string MaHD, string Mahang)
        {
            string select = "Select a.MaHang, a.GiaBan, a.SoLuong, a.VAT, a.ThanhTien, b.TenHang, b.DVT from ChiTietHoaDon a, HangHoa b" +
                                " where a.MaHang=b.MaHang and a.MaHD='" + MaHD + "' and a.MaHang='" + Mahang + "'";
            return da.GetDataTable(select);

        }
        public void Insert(ChiTietHoaDon DeTailHoaDon)
        {
            string query = "Insert into ChiTietHoaDon Values ('" + DeTailHoaDon.MaHD +
                                                                "','" + DeTailHoaDon.MaHang +
                                                                "','" + DeTailHoaDon.GiaBan +
                                                                "','" + DeTailHoaDon.SoLuong +
                                                                "','" + DeTailHoaDon.VAT +
                                                                "','" + DeTailHoaDon.ThanhTien +
                                                                "')";
            da.ExecuteNonQuery(query);
        }
        public void Update(ChiTietHoaDon DeTailHoaDon)
        {
            string query;
            query = "Update ChiTietHoaDon set SoLuong=N'" + DeTailHoaDon.SoLuong + "'," +
                                        "GiaBan='" + DeTailHoaDon.GiaBan + "'," +
                                        "VAT=N'" + DeTailHoaDon.VAT + "'," +
                                    "where MaHD='" + DeTailHoaDon.MaHD + "'" +
                                    " and MaHang='" + DeTailHoaDon.MaHang + "'";

            da.ExecuteNonQuery(query);
        }
        public void Delete(ChiTietHoaDon DeTailHoaDon)
        {
            string query = "Delete from ChiTietHoaDon where MaHD='" + DeTailHoaDon.MaHD + "'" +
                                                            " and MaHang='" + DeTailHoaDon.MaHang + "'";
            da.ExecuteNonQuery(query);

        }
    }
}
