using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class HoaDonBanHang
    {
        private string _MaHD;
        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }

        private string _MaKH;
        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        private string _MaNV;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private DateTime _NgayBan = DateTime.Parse("01/01/1900");
        public DateTime NgayBan
        {
            get { return _NgayBan; }
            set { _NgayBan = value; }
        }

        private int _TongTienHD;
        public int TongTienHD
        {
            get { return _TongTienHD; }
            set { _TongTienHD = value; }
        }

        private List<ChiTietHoaDon> _ListCTHoaDon;
        public List<ChiTietHoaDon> ListCTHoaDon
        {
            get { return _ListCTHoaDon; }
            set { _ListCTHoaDon = value; }
        }

        public HoaDonBanHang()
        {
        }
    }
}
