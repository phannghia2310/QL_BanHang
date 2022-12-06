using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class ChiTietPhieuNhap
    {
        private string _MaPN;
        public string MaPN
        {
            get { return _MaPN; }
            set { _MaPN = value; }
        }

        private string _MaHang;
        public string MaHang
        {
            get { return _MaHang; }
            set { _MaHang = value; }
        }

        private int _GiaNhap;
        public int GiaNhap
        {
            get { return _GiaNhap; }
            set { _GiaNhap = value; }
        }

        private int _SoLuong;
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private int _ChietKhau;
        public int ChietKhau
        {
            get { return _ChietKhau; }
            set { _ChietKhau = value; }
        }

        private int _ThanhTien;
        public int ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }

        public ChiTietPhieuNhap()
        {
        }
    }
}
