using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class ChiTietHoaDon
    {
        private string _MaHD;
        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }

        private string _MaHang;
        public string MaHang
        {
            get { return _MaHang; }
            set { _MaHang = value; }
        }

        private int _GiaBan;
        public int GiaBan
        {
            get { return _GiaBan; }
            set { _GiaBan = value; }
        }

        private int _SoLuong;
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private int _VAT;
        public int VAT
        {
            get { return _VAT; }
            set { _VAT = value; }
        }

        private int _ThanhTien;
        public int ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }

        public ChiTietHoaDon()
        {
        }
    }
}
