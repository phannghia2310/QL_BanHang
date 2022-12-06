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
    class ChiTietPhieuNhapBLL
    {
        DataAccess da = new DataAccess();
        public DataTable GetListChiTietPNByMaPN(string MaPhieuNhap)
        {
            string select = "Select a.MaHang, a.GiaNhap, a.SoLuong, a.ChietKhau, a.ThanhTien, b.TenHang, b.DVT from ChiTietPhieuNhap a, HangHoa b" +
                               " where a.MaHang=b.MaHang and a.MaPN='" + MaPhieuNhap + "'";
            return da.GetDataTable(select);

        }
        public DataTable GetListChiTietPNByMaPNandMaHang(string MaPhieuNhap, string Mahang)
        {
            string select = "Select a.MaHang, a.GiaNhap, a.SoLuong, a.ChietKhau, a.ThanhTien, b.TenHang, b.DVT from ChiTietPhieuNhap a, HangHoa b" +
                                " where a.MaHang=b.MaHang and a.MaPN='" + MaPhieuNhap + "' and a.MaHang='" + Mahang + "'";
            return da.GetDataTable(select);

        }
        public void Insert(ChiTietPhieuNhap DeTailPhieuNhap)
        {
            string query = "Insert into ChiTietPhieuNhap Values ('" + DeTailPhieuNhap.MaPN +
                                                                "','" + DeTailPhieuNhap.MaHang +
                                                                "','" + DeTailPhieuNhap.SoLuong +
                                                                "','" + DeTailPhieuNhap.GiaNhap +
                                                                "','" + DeTailPhieuNhap.ChietKhau +
                                                                "')";
            da.ExecuteNonQuery(query);
        }
        public void Update(ChiTietPhieuNhap DeTailPhieuNhap)
        {
            string query;
            query = "Update ChiTietPhieuNhap set SoLuong=N'" + DeTailPhieuNhap.SoLuong + "'," +
                                        "GiaNhap='" + DeTailPhieuNhap.GiaNhap + "'," +
                                        "ChietKhauMatHang=N'" + DeTailPhieuNhap.ChietKhau + "'," +
                                    "where MaPN='" + DeTailPhieuNhap.MaPN + "'" +
                                    " and MaHang='" + DeTailPhieuNhap.MaHang + "'";

            da.ExecuteNonQuery(query);
        }
        public void Delete(ChiTietPhieuNhap DeTailPhieuNhap)
        {
            string query = "Delete from ChiTietPhieuNhap where MaPN='" + DeTailPhieuNhap.MaPN + "'" +
                                                            " and MaHang='" + DeTailPhieuNhap.MaHang + "'";
            da.ExecuteNonQuery(query);

        }
    }
}
