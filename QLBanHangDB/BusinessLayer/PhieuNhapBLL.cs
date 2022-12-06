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
    class PhieuNhapBLL
    {
        DataAccess da = new DataAccess();
        public void Insert(PhieuNhap pn)
        {

            string query;
            query = " Insert into PhieuNhap values('" + pn.MaPN +
                                              "','" + pn.MaNCC +
                                              "','" + pn.MaNV +
                                              "',convert(datetime,'" + pn.NgayNhap + "',101) " +
                                              "','" + pn.TongTienNhap +
                                              "')";

            da.ExecuteNonQuery(query);

            foreach (ChiTietPhieuNhap ct in pn.ListCTPhieuNhap)
            {
                string query1;
                query1 = "Insert into ChiTietPheuNhap Values ('" + ct.MaPN +
                                                            "','" + ct.MaHang +
                                                            "','" + ct.SoLuong +
                                                            "','" + ct.GiaNhap +
                                                            "','" + ct.ChietKhau +
                                                            "')";

                da.ExecuteNonQuery(query1);
            }

        }
        public DataTable GetListPhieuNhap()
        {
            string select = "Select * from PhieuNhap";
            return da.GetDataTable(select);
        }
        public DataTable GetListPhieuNhapByID(string mapn)
        {
            string select = "Select * from PhieuNhap where MaPN='" + mapn + "'";
            return da.GetDataTable(select);
        }

        public DataTable GetListPhieuNhapByDate(string TuNgay, string DenNgay)
        {
            string select = "Select * from PhieuNhap where" +
                              " convert(datetime,NgayNhap,101) between convert(datetime,'" + TuNgay +
                              "',101) and convert(datetime,'" + DenNgay +
                              "',101)";
            return da.GetDataTable(select);
        }

        public DataTable GetListPhieuNhapByMaNCC(string MaNCC)
        {
            string select = "Select * from PhieuNhap where" +
                              " MaNCC='" + MaNCC + "'";
            return da.GetDataTable(select);
        }

        public DataTable GetListPhieuNhapByMaNV(string MaNV)
        {
            string select = "Select * from PhieuNhap where" +
                              " MaNV='" + MaNV + "'";
            return da.GetDataTable(select);
        }
        public void Delete(string MaPN)
        {
            string query;
            query = "Delete from ChiTietPhieuNhap where MaPN='" + MaPN + "' ;" +
                    " Delete from PhieuNhap where MaPN='" + MaPN + "'";
            da.ExecuteNonQuery(query);
        }
        public void UpdateNguoiLapPhieu(string MaPN, string MaNV)
        {
            string query = "Update PhieuNhap Set MaNV='" + MaNV + "'" +
                            " where MaPN='" + MaPN + "'";
            da.ExecuteNonQuery(query);
        }
        public void Update(string MaPN, string MaNV, string TongTienNhap)
        {
            string query = "Update ChungTuNhapHang Set MaNV='" + MaNV + "'," +
                                                    " TongTienNhap='" + TongTienNhap + "'" +
                                                " where MaPN='" + MaPN + "'";
            da.ExecuteNonQuery(query);
        }
    }
}
